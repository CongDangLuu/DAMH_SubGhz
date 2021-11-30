using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//khai báo cho serial
using System.IO;
using System.IO.Ports;
using System.Xml;


namespace Send_txt
{
    public partial class Form1 : Form
    {
        bool modding_flag;
        string Data_txt = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        delegate void SetTextCallback(string str); // Khai bao delegate SetTextCallBack voi tham so string
        string txt;

        public Form1()
        {
            InitializeComponent();
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            Baud.Items.AddRange(BaudRate);
            string[] Modes = { "Transmit", "Receive" };
            Mode.Items.AddRange(Modes);            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            COM.DataSource = SerialPort.GetPortNames();
            Baud.SelectedIndex = 3; 
        }


        // connect button
        private void button1_Click(object sender, EventArgs e)
        {
            if (Mode.Text == "")
            {
                MessageBox.Show("Mode not found. Please choose another!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = COM.Text;
                    serialPort1.BaudRate = Convert.ToInt32(Baud.Text);
                    serialPort1.Open();

                    //thanh trạng thái.
                    Status.Text = "  Connected  ";
                    Status.ForeColor = Color.White;
                    Status.BackColor = Color.Green;
                    //khóa com + baud rate.
                    COM.Enabled = false;
                    Baud.Enabled = false;
                    Mode.Enabled = false;
                    //mở serialPort.
                    Mode_select();
                    timer2.Start();
                }
                catch
                {
                    MessageBox.Show("COM Port not found. Please choose another!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }

        // select modes:
        private void Mode_select()
        {
            Display.Text = "";
            if (Mode.Text == "Transmit")
            {
                modding_flag = true;
                btSave.Enabled = false;                
            }
            else if (Mode.Text == "Receive")
            {
                modding_flag = false;               
                btRead.Enabled = false;
                btSend.Enabled = false;
            }
        }


       /*************************************************************************************************/
        //Receive Data mode
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (modding_flag == false)
            {
                if (!serialPort1.IsOpen)
                {
                    return;
                }
                else
                {
                    try
                    {
                        string str = serialPort1.ReadLine();
                        if (str != string.Empty)
                        {
                            Data_txt = str;
                            SetText_RX(Data_txt);
                        }
                    }
                    catch { return; }
                }
                
            }

        }

        // hiển thị dữ liệu nhận về lên display.
        private void SetText_RX(string data_txt)
        { 
            if (this.Display.InvokeRequired)
            {
                SetTextCallback c = new SetTextCallback(SetText_RX); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(c, new object[] { data_txt });
            }
            else
            {
                this.Display.Text += data_txt + "\r\n";  
            } 
        }

        // nhấn nút save file.
        private void Button3_Click(object sender, EventArgs e)
        {
            if (Display.Text == "")
            {
                MessageBox.Show("Không có dữ liệu!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(save.FileName);
                    file.Write(Display.Text);
                    file.Close();
                }
            }
        }

        /**************************************************************/
        // Transmit data mode.

        //nhấn nút đọc file.
        private void btRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog link = new OpenFileDialog();
            if (link.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader filename = new StreamReader(link.FileName);
                while (filename.EndOfStream == false)
                txt = filename.ReadToEnd();
                File_Name.Text = link.FileName.ToString();
                filename.Close();
                Display.Text = txt;
                Display.Text += "\r\n" + txt.Length.ToString();

            }   
        }
   
        // nhấn nút gửi.
        private void btSend_Click(object sender, EventArgs e)
        {
            
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("COM Port not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt == "")
            {
                MessageBox.Show("Data not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                send_data.Start();
            }
        }

        //send_data
        private void timer1_Tick(object sender, EventArgs e)
        {
            txt += '\n';
            do
            {
                if (txt.Length > 60)
                {
                    Data_txt = txt.Substring(0, 59) ;
                    txt = txt.Remove(0, 59);
                }
                else
                {
                    Data_txt = txt;
                    txt = "";
                }
                Data_txt += '|';
                serialPort1.Write(Data_txt);
                Data_txt = "";
            } while (txt != "");
            send_data.Stop();       

        }


        /**************************************************************/
        // disconnect button
        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

            //thanh trạng thái.
            Status.Text = "Disconnected";
            Status.ForeColor = Color.Red;
            Status.BackColor = Color.White;
            //mở khóa com + baud rate.
            COM.Enabled = true;
            Baud.Enabled = true;
            Mode.Enabled = true;

            btSave.Enabled = true;
            btSend.Enabled = true;
            btRead.Enabled = true;

            modding.Text = "";
            modding.ForeColor = Color.White;

            timer2.Stop();
        }

        // nhấn nút clear textbox
        private void btClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            File_Name.Text = "";
        }

        //makecolor
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (modding.Text != "")
            {
                modding.Text = "";
            }
            else
            {
                if (modding_flag)
                {
                    modding.Text = "Sending";
                }
                else
                {
                    modding.Text = "Receiving";
                }
                modding.ForeColor = Color.White;
                modding.BackColor = Color.Green;
            }
        }
       
    }
}
