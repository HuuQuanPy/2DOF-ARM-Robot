/*
 * Robot Nhom15.c
 *
 * Created: 16/04/2023 04:33:15 PM
 * Author : ADMIN
 */ 

#include "USART.h"
#include "ModbusSlave.h"

#define  SH_CP1_Pin PINA0
#define  Data1_Pin PINA1
#define  ST_CP1_Pin PINA2

#define  SH_CP_Pin PINB0
#define  Data_Pin PINB1
#define  ST_CP_Pin PINB2


int theta1, theta2;
float xAxis, yAxis;
uint8_t RxData[20];
uint8_t TxData[20];
int index = 0;
const float pi = M_PI/180;
const float L1 = 12, L2 = 7.5;
unsigned char LED7[10] = {0xC0, 0xF9, 0xA4, 0xB0, 0x99, 0x92, 0x82, 0xF8, 0x80, 0x90};

void SetTheta(int x1, int x2)
{
	OCR1A = 600 + x1 * 11;
	OCR1B = 600 + x2 * 11;
}


ISR(USART_RXC_vect)
{
	RxData[index] = receive();
	index++;
	if (index>7)
	{
		if (RxData[0] == SLAVE_ID)
		{
			switch (RxData[1])
			{
				case 0x01:
				readCoils();
				break;
				case 0x03:
				readHoldingRegs();
				break;
				case 0x05:
				writeSingleCoil();
				break;
				case 0x06:
				writeSingleReg();
				break;

				default:
				modbusException(ILLEGAL_FUNCTION);
				break;
			}
		}
		index=0;
	}
}

void ForwardKinematic(int _theta1 , int _theta2)
{
	xAxis = L1 * cos(_theta1*pi) + L2 * cos(_theta1*pi+_theta2*pi);
	yAxis = L1 * sin(_theta1*pi) + L2 * sin(_theta1*pi+_theta2*pi);
	
}

void InverseKinematic(float _XAxis, float _YAxis)
{
	float cos_theta2, sin_theta2, tang_theta1;
	cos_theta2 = (pow(_XAxis,2) + pow(_YAxis,2) - pow(L1,2) - pow(L2,2)) / (2*L1*L2);
	sin_theta2 = sqrt(1 - pow(cos_theta2,2));
	tang_theta1 = ((cos_theta2 * L2 + L1) * _YAxis - sin_theta2 * L2 * _XAxis) / ((cos_theta2 * L2 + L1) * _XAxis + sin_theta2 *  L2 * _YAxis);
	
	if (cos_theta2 >= -1 && cos_theta2 <= 1)
	{
		theta2 = (int) (acos(cos_theta2) / pi) ;
	}
	if (tang_theta1 < 0)
	{
		theta1 =  (atan(tang_theta1)/pi) + 180;
	}
	else
	{
		theta1 =  atan(tang_theta1)/pi;
	}
}

void GetDATAInIC(unsigned char dec)
{
	For(i,0,7)
	{
		if((dec << i) & 0x80)
		digitalHIGH(PORTB,Data_Pin);
		else
		digitalLOW(PORTB,Data_Pin);
		
		digitalHIGH(PORTB,SH_CP_Pin);
		_delay_us(10);
		digitalLOW(PORTB,SH_CP_Pin);
		_delay_us(10);
	}
}

void GetDATAOutIC()
{
	digitalHIGH(PORTB,ST_CP_Pin);
	_delay_us(10);
	digitalLOW(PORTB,ST_CP_Pin);	
}

void DisplayLED(int32_t _theta1, int32_t _theta2, float _XAxis, float _YAxis)
{
	int32_t temp1 , tr1, ch1, dv1, temp2, tr2, ch2, dv2;
	int16_t temp3, temp4, ch3, dv3, man1, ch4, dv4, man2;
	/* Display LED of theta1 and theta2  */
	temp1 = _theta1;
	dv1 = temp1 % 10;
	temp1 = temp1 / 10;
	ch1 = temp1	 % 10;
	temp1 = temp1 / 10;
	tr1 = temp1 % 10;
	/////////////
	temp2 = _theta2;
	dv2 = temp2 % 10;
	temp2 = temp2 / 10;
	ch2 = temp2	 % 10;
	temp2 = temp2 / 10;
	tr2 = temp2 % 10;
	/* Display LED of X axis and Y axis */
	temp3 = abs((int)(_XAxis));
	dv3 = temp3%10;
	temp3 = temp3/10;
	ch3 = temp3%10;
	man1 = abs((int)(_XAxis*10)) % 10;
	
	temp4 = abs((int)(_YAxis));
	dv4 = temp4%10;
	temp4 = temp4/10;
	ch4 = temp4%10;
	man2 = abs((int)(_YAxis*10)) % 10;

	GetDATAInIC(LED7[ch3]);
	GetDATAInIC(LED7[dv3] & 0x7F);
	GetDATAInIC(LED7[man1]);
	GetDATAInIC(LED7[ch4]);
	GetDATAInIC(LED7[dv4] & 0x7F);
	GetDATAInIC(LED7[man2]);
	GetDATAInIC(LED7[tr1]);
	GetDATAInIC(LED7[ch1]);
	GetDATAInIC(LED7[dv1]);
	GetDATAInIC(LED7[tr2]);
	GetDATAInIC(LED7[ch2]);
	GetDATAInIC(LED7[dv2]);
	GetDATAOutIC();
	//Sign 
	GetOUTDataSign(_YAxis,_XAxis);
}

void GetInDataSign(unsigned char dec)
{
	For(i,0,7)
	{
		if((dec << i) & 0x80)
		digitalHIGH(PORTA,Data1_Pin);
		else
		digitalLOW(PORTA,Data1_Pin);
		
		digitalHIGH(PORTA,SH_CP1_Pin);
		_delay_us(10);
		digitalLOW(PORTA,SH_CP1_Pin);
		_delay_us(10);
	}
}
void GetOUTDataSign(float _f1, float _f2)
{
	if (_f1 >= 0 && _f2 >= 0)
	{
		GetInDataSign(0xFF);
		GetInDataSign(0xFF);
		digitalHIGH(PORTA,ST_CP1_Pin);
		_delay_us(10);
		digitalLOW(PORTA,ST_CP1_Pin);
	}
	else if (_f1>=0 && _f2<0)
	{
		GetInDataSign(0xFF);
		GetInDataSign(0xBF);
		digitalHIGH(PORTA,ST_CP1_Pin);
		_delay_us(10);
		digitalLOW(PORTA,ST_CP1_Pin);
	}
	else if (_f1<0 && _f2>=0)
	{
		GetInDataSign(0xBF);
		GetInDataSign(0xFF);
		digitalHIGH(PORTA,ST_CP1_Pin);
		_delay_us(10);
		digitalLOW(PORTA,ST_CP1_Pin);
	}
	else 
	{
		GetInDataSign(0xBF);
		GetInDataSign(0xBF);
		digitalHIGH(PORTA,ST_CP1_Pin);
		_delay_us(10);
		digitalLOW(PORTA,ST_CP1_Pin);
	}
}

void UpdateAxisPoint()
{
	Holding_Registers_Database[2] = (int) xAxis;
	Holding_Registers_Database[3] = (int) yAxis;				
}
void UpdateTheta()
{
	Holding_Registers_Database[0] = theta1;
	Holding_Registers_Database[1] = theta2;
}

int main(void)
{
    /* Replace with your application code */
	init_usart();
	DDRA |= (1<<PINA0) | (1<<PINA1) | (1<<PINA2);
	PORTA|= 0x00;
	
	DDRB |= (1<<PINB0) | (1<<PINB1) | (1<<PINB2);
	PORTB|= 0x00;
	
	DDRD |= (1<<PIND1) | (1<<PIND4) | (1<<PIND5); 
	PORTD = 0xFF;
	
	//khai bao che do hoat dong Fast PWM va xung 1us 
	
	TCCR1A |= (1<<COM1A1) | (1<<COM1B1) | (1<<WGM11);
	TCCR1B |= (1<<WGM13) | (1<<WGM12) | (1<<CS11);
	
	OCR1A = 600; //  theta1 = 0 degree
	OCR1B = 600; //  theta2 = 0 degree
	ICR1 = 15000; 
	
	sei();
	
    while (1) 
    {
		// Register10 is valueMode 
		switch (Holding_Registers_Database[10])
		{
			case 1: //Forward Kinematic
				/* Your code here */
			theta1 = Holding_Registers_Database[0];
			theta2 = Holding_Registers_Database[1];
			ForwardKinematic(theta1,theta2);
			// Register 0 and 1 are theta1 , theta2 of AVR robot
			
			SetTheta(theta1,theta2);
			DisplayLED(theta1, theta2, xAxis, yAxis);
			UpdateAxisPoint();
			
			break;
			
			case 2: // Inverse Kinematic
				/* Your code here */
			xAxis = (float) Holding_Registers_Database[2];
			yAxis = (float) Holding_Registers_Database[3];
			InverseKinematic(xAxis,yAxis);
			// Register 2 and 3 are axisX, axisY of AVR robot
			SetTheta(theta1,theta2);
			DisplayLED(theta1,theta2,xAxis,yAxis);
			UpdateTheta();
			
			break;
			
			//////----------------///////////////
			int A_Xaxis, A_Yaxis, B_Xaxis, B_Yaxis;
			int theta1A, theta2A, theta1B, theta2B, gocLech1, gocLech2;
			
			case 3:
				/* Your code here */
			A_Xaxis = Holding_Registers_Database[4];
			A_Yaxis = Holding_Registers_Database[5];
			B_Xaxis = Holding_Registers_Database[6];
			B_Yaxis = Holding_Registers_Database[7];
			
			//// Search theta1, theta2 from APoint
			InverseKinematic(A_Xaxis,A_Yaxis);
			theta1A = theta1;
			theta2A = theta2;
			
			/// Search theta1, theta2 from BPoint
			InverseKinematic(B_Xaxis,B_Yaxis);
			theta1B = theta1;
			theta2B = theta2;
			
			//      Run from A to B
			gocLech1 = theta1B - theta1A;
			gocLech2 = theta2B - theta2A;
			
			if (gocLech2 >= 0)
			{
				for (int i=0 ; i<gocLech2 ; i++)
				{
					SetTheta(theta1A,theta2A + i);
					ForwardKinematic(theta1A,theta2A+i);
					DisplayLED(theta1A,theta2A+i,xAxis,yAxis);
					_delay_ms(20);
				}
			}
			else
			{
				for (int i=0 ; i<(gocLech2*-1) ; i++)
				{
					SetTheta(theta1A,theta2A - i);
					ForwardKinematic(theta1A,theta2A-i);
					DisplayLED(theta1A,theta2A-i,xAxis,yAxis);
					_delay_ms(20);
				}
			}
			
			if (gocLech1 >= 0)
			{
				for (int i=0 ; i<gocLech1 ; i++)
				{
					SetTheta(theta1A + i,theta2B);
					ForwardKinematic(theta1A+i, theta2B);
					DisplayLED(theta1A+i, theta2B, xAxis, yAxis);
					_delay_ms(10);
				}
			}
			else
			{
				for (int i=0 ; i<(gocLech1*-1) ; i++)
				{
					SetTheta(theta1A - i,theta2B);
					ForwardKinematic(theta1A-i, theta2B);
					DisplayLED(theta1A-i, theta2B, xAxis, yAxis);
					_delay_ms(10);
				}
			}
			_delay_ms(3000);
			
			//     RUN form B to A
			
			if (gocLech2 >= 0)
			{
				for (int i=0 ; i<gocLech2 ; i++)
				{
					SetTheta(theta1B,theta2B - i);
					ForwardKinematic(theta1B, theta2B-i);
					DisplayLED(theta1B, theta2B-i, xAxis, yAxis);
					_delay_ms(10);
				}
			}
			else
			{
				for (int i=0 ; i<(gocLech2*-1) ; i++)
				{
					SetTheta(theta1B,theta2B + i);
					ForwardKinematic(theta1B, theta2B+i);
					DisplayLED(theta1B, theta2B+i, xAxis, yAxis);
					_delay_ms(10);
				}
			}
			///
			if (gocLech1 >= 0)
			{
				for (int i=0 ; i<gocLech1 ; i++)
				{
					SetTheta(theta1B - i,theta2A);
					ForwardKinematic(theta1B-i, theta2A);
					DisplayLED(theta1B-i, theta2A, xAxis, yAxis);
					_delay_ms(10);
				}
			}
			else
			{
				for (int i=0 ; i<(gocLech1*-1) ; i++)
				{
					SetTheta(theta1B + i,theta2A);
					ForwardKinematic(theta1B+i, theta2A);
					DisplayLED(theta1B+i, theta2A, xAxis, yAxis);
					_delay_ms(10);
				}
			}
			_delay_ms(3000);
			break;
			
			int temp_XAxis, temp_YAxis;
			int temp_theta1, temp_theta2;
				
			case 4:
				/* Your code here */
			A_Xaxis = Holding_Registers_Database[4];
			A_Yaxis = Holding_Registers_Database[5];
			B_Xaxis = Holding_Registers_Database[6];
			B_Yaxis = Holding_Registers_Database[7];
			

			for (int i = 0 ; i<100 ; i++)
			{
		
				temp_XAxis =  A_Xaxis + (B_Xaxis - A_Xaxis)*i/100 ;
				temp_YAxis = ((B_Yaxis - A_Yaxis) / (B_Xaxis - A_Xaxis)) * (temp_XAxis - A_Xaxis) + A_Yaxis;
				
				InverseKinematic(temp_XAxis,temp_YAxis);
				temp_theta1 = theta1;
				temp_theta2 = theta2;

				SetTheta(temp_theta1,temp_theta2);
				_delay_ms(30);
			
			}
			_delay_ms(1000);
			
			for (int j = 100 ; j>0 ; j--)
			{
				temp_XAxis =  A_Xaxis + (B_Xaxis - A_Xaxis)*j/100 ;
				temp_YAxis = ((B_Yaxis - A_Yaxis) / (B_Xaxis - A_Xaxis)) * (temp_XAxis - A_Xaxis) + A_Yaxis;
				
				InverseKinematic(temp_XAxis,temp_YAxis);
				temp_theta1 = theta1;
				temp_theta2 = theta2;

				SetTheta(temp_theta1,temp_theta2);
				_delay_ms(30);
				
			}
			_delay_ms(3000);
			break;
			
			default:
			break;
		}
		//DisplayLED(theta1,theta2,xAxis,yAxis);
    }
}



