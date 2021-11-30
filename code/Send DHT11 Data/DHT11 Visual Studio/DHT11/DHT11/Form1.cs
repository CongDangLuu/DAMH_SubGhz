using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Thư viện serial
using System.IO;
using System.IO.Ports;
using System.Xml;

namespace DHT11
{
    public partial class Form1 : Form
    {
        string InputData = String.Empty;
        string temperature = String.Empty;
        string humidity = String.Empty;

        delegate void SetTextCallback(string str1, string str2);

        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceive);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            comboBox2.Items.AddRange(BaudRate);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
            comboBox2.SelectedIndex = 3;
        }
        //đọc dữ liệu uart.
        private void serialPort1_DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Chưa kết nối cổng COM!");
            }
            else if (serialPort1.IsOpen)
            {  
                try
                {
                    InputData = serialPort1.ReadLine(); // Đọc một dòng của Serial                    
                    string[] Data = InputData.Split('|');//Cắt chuỗi khi gặp ký tự |
                    temperature = Data[0]; // Chuỗi đầu tiên lưu vào t
                    humidity = Data[1]; // Chuỗi thứ hai lưu vào h   
                }
                catch { return; }
            }
        }

        //kiểm tra dữ liệu Uart.
        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBox1.Text = InputData;
            if (!serialPort1.IsOpen)
            {
                return;
            }
            else if (serialPort1.IsOpen)
            {
                if (InputData == string.Empty) 
                { 
                    temperature = "0";
                    humidity = "0";
                }

                SetText(temperature, humidity);
            }
        }

        private void SetText(string t, string h)
        {
            //in nhiệt độ
            if (this.Temp.InvokeRequired)
            {
                SetTextCallback c = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(c, new object[] { t });
            }
            else this.Temp.Text = t + " *C";

            //in độ ẩm
            if (this.Humi.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { h });
            }
            else this.Humi.Text = h + " %";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputData = "0|0";
            this.Temp.Text = "0 *C";
            this.Humi.Text = "0  %";
        }
        // kết nối cổng COM.
        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();

                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    status.Text = "   Connected";
                    status.ForeColor = Color.White;
                    status.BackColor = Color.Green;
                }
                catch
                {
                    MessageBox.Show("COM Port was not found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //ngắt kết nối cổng COM
        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            status.Text = " Disconnected";
            status.ForeColor = Color.Red;
            status.BackColor = Color.White;
        }

    }
}
