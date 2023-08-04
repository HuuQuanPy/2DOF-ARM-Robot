using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EasyModbus;
using EasyModbus.Exceptions;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace RobotCongNghiep
{
    public partial class Form1 : Form
    {
        ModbusClient mbCsharp = new ModbusClient();
        ModbusException mbExcep = new ModbusException();

        public Form1()
        {
            InitializeComponent();
        }
        const float L1 = 12, L2 = 7.5F;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            string[] baudrade = { "1200", "2400", "4800", "9600", "19200", "28800" ,"38400" , "57600" };
            CbxCom.Items.AddRange(ports);
            CbxBaudRate.Items.AddRange(baudrade);
            CbxCom.SelectedIndex = 0;
            CbxBaudRate.SelectedIndex = 6;

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (mbCsharp.Connected == false)
            {
                try
                {
                    mbCsharp.SerialPort = CbxCom.Text;
                    mbCsharp.Baudrate = int.Parse (CbxBaudRate.Text);
                    mbCsharp.StopBits = StopBits.One;
                    mbCsharp.Parity = Parity.None;
                    mbCsharp.Connect();
                    lblStatus.Text = "Connected";
                    lblStatus.ForeColor = Color.Blue;
                    BtnConnect.Text = "Disconnect";
                    BtnConnect.BackColor = Color.OrangeRed;
                    BtnRobotForward.BackColor = Color.LightGreen;
                    TimerAVR.Start();
                    TimerAVR.Interval = 500;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erros");
                }
            }
            else
            {
                mbCsharp.Disconnect();
                lblStatus.Text = "Disconnect";
                lblStatus.ForeColor = Color.Red;
                BtnConnect.Text = "Connect";
                BtnConnect.BackColor = Color.WhiteSmoke;
                txtModbusStatus.Text = null;
                TimerAVR.Stop();
            }
        }

        private bool Check_Connect()
        {
            if (mbCsharp.Connected == false)
            {
                MessageBox.Show("No connected", "Infor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void BtnRUN_Click(object sender, EventArgs e)
        {
            if (Check_Connect())
            {
                try
                {
                    mbCsharp.UnitIdentifier = 1;
                    mbCsharp.WriteSingleRegister(10, 3);
                }
                catch(Exception)
                {
                  
                }
            }
        }

        private void TrbTheta1_Scroll(object sender, EventArgs e)
        {
            if (Check_Connect())
            {
                mbCsharp.UnitIdentifier = 1;
                mbCsharp.WriteSingleRegister(0,TrbTheta1.Value);
            }
        }

        private void TrbTheta2_Scroll(object sender, EventArgs e)
        {
            if (Check_Connect())
            {
                mbCsharp.UnitIdentifier = 1;
                mbCsharp.WriteSingleRegister(1,TrbTheta2.Value);
            }
        }
        private void TrbPx_Scroll(object sender, EventArgs e) { }

        private void MyPorts_DataReceived(object sender, SerialDataReceivedEventArgs e) { }
   
        private void TrbPy_Scroll(object sender, EventArgs e) { }

        private void txtPx_TextChanged(object sender, EventArgs e)
        {
            if (txtPx.Text == "" || txtPy.Text == "")
            {
                BtnSetPoint.Enabled = false;
            }
            else
                BtnSetPoint.Enabled = true;
        }
        //int temp1, temp2, ch, dv, phay;

        private void TxtPoint_TextChanged(object sender, EventArgs e)
        {
            if (TxtSetA_Px.Text == "" || TxtSetA_Py.Text == "" || TxtSetB_Px.Text == "" || TxtSetB_Py.Text == "")
            {
                BtnSetP.Enabled = false;
            }
            else
                BtnSetP.Enabled = true;
        }

        private void UpdateDataModbus(int _theta1, int _theta2, int _Xaxis, int _Yaxis)
        {
            TrbTheta1.Value = _theta1;
            TrbTheta2.Value = _theta2;
            txtPx.Text = Convert.ToString(_Xaxis);
            txtPy.Text = Convert.ToString(_Yaxis);
        }

        private void TimerAVR_Tick(object sender, EventArgs e)
        {
            try
            {
                mbCsharp.UnitIdentifier = 1;
                int[] vals = mbCsharp.ReadHoldingRegisters(0, 11);

                lblTheta1.Text = vals[0].ToString();
                lblTheta2.Text = vals[1].ToString();
                lblPx.Text = vals[2].ToString();
                lblPy.Text = vals[3].ToString();
                txtModbusStatus.Text = "Respon OK";
            }
            catch (Exception)
            {
                txtModbusStatus.Text = "Modbus Response Errors";
            }


        }

        private void BtnRun_Line_Click(object sender, EventArgs e)
        {
            if (Check_Connect())
            {
                mbCsharp.UnitIdentifier = 1;
                mbCsharp.WriteSingleRegister(10, 4);
            }
        }

        private void BtnSetP_Click(object sender, EventArgs e)
        {
            if (Check_Connect())
            {
                mbCsharp.UnitIdentifier = 1;
                mbCsharp.WriteSingleRegister(4,int.Parse(TxtSetA_Px.Text));
                mbCsharp.WriteSingleRegister(5, int.Parse(TxtSetA_Py.Text));
                mbCsharp.WriteSingleRegister(6, int.Parse(TxtSetB_Px.Text));
                mbCsharp.WriteSingleRegister(7, int.Parse(TxtSetB_Py.Text));
            }
        }

        private void BtnSetPoint_Click(object sender, EventArgs e)
        {
            if (Check_Connect())
            {
                mbCsharp.UnitIdentifier = 1;
                mbCsharp.WriteSingleRegister(2,int.Parse(txtPx.Text));
                mbCsharp.WriteSingleRegister(3,int.Parse(txtPy.Text));

            }
        }

        //Dong hoc nghich ROBOT
        private void BtnRobotInverse_Click(object sender, EventArgs e)
        {
            if (Check_Connect())
            {
                BtnRobotInverse.BackColor = Color.LightGreen;
                BtnRobotForward.BackColor = Color.LightGray;

                TrbTheta1.Enabled = false;
                TrbTheta2.Enabled = false;
                txtPx.ReadOnly = false;
                txtPy.ReadOnly = false;
                mbCsharp.UnitIdentifier = 1;
                mbCsharp.WriteSingleRegister(10, 2);
            }
        }

        //Dong hoc thuan ROBOT
        private void BtnRobotForward_Click(object sender, EventArgs e)
        {
            if (Check_Connect())
            {
                BtnRobotForward.BackColor = Color.LightGreen;
                BtnRobotInverse.BackColor = Color.LightGray;

                TrbTheta1.Enabled = true;
                TrbTheta2.Enabled = true;
                txtPx.ReadOnly = true;
                txtPy.ReadOnly = true;
                mbCsharp.UnitIdentifier = 1;
                mbCsharp.WriteSingleRegister(10, 1);

                TrbTheta1.Value = 0;
                TrbTheta2.Value = 0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

    }
}
