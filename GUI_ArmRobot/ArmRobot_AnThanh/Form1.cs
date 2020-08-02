using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;// thu vien IO
namespace ArmRobot_AnThanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAvailablePort();// goi form l kich hoat luon getAvailablePort
        }
        void getAvailablePort()
        {
            string[] ports = SerialPort.GetPortNames();// tat ca thanh phan bien mang gan voi portnam
            comboBox1.Items.AddRange(ports);// cac item combobox1 gan voi port da chon
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // neu combox1 hoac combobox2 trong - ko co gi dc chon
                if (comboBox1.Text == "" || comboBox2.Text == "")// Neu khong co 1 trong 2 thong so Port va baurate
                {
                    textBox1.Text = "Please select port setting";
                }
                else // neu da chon com va baud
                {
                    serialPort1.PortName = comboBox1.Text;//combobox1 mang ten cong com => gan ten doi tuong port1 cho cho cong do
                    // combobox2 la kieu chuoi ki tu => chuyen toi dang so nguyen
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;

                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox1.Text = " Unauthorized Acesse ";// neu ko dc bao truy cap ko chuan
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;

        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            textBox1.Text = serialPort1.ReadLine();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("a");
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("0");
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("b");
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("0");
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("c");
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("0");
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("d");
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("0");
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("e");
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("0");
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("f");
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("0");
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("g");
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("0");
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("h");
        }

        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("0");
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            textBox1.Text = serialPort1.ReadLine();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("i");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            serialPort1.Write("k");
        }
    }
}
