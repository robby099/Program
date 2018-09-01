using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Globalization;
using System.Data.SqlClient;

namespace BISMILLAH
{
    public partial class Form1 : Form
    {

        /**Inisialisasi databse
         * setup string koneksi 
         * **/
        SqlConnection cs = new SqlConnection("Data Source=localhost;Initial Catalog=db_sensor;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();

        //waktu mulai dalam milidetik
        double waktuStart = 100;
        //interval simpan ke database (menit)
        int intervalSimpan = 1;
        //pencacah interval
        int counter = 0;

        double
           dataSuhu,
           dataKekeruhanAir,
           dataPHAir,
           dataDO;
        string dataTerima;
        //string dataSuhu;
        //string dataKekeruhanAir;
        //delegate void stringInvoke(string text);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPort_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPort.Items.Add(port);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                radioButtonStatus.Text = "Status : Connected";
                radioButtonStatus.Checked = true;
            }
            else
            {
                radioButtonStatus.Text = "Status : Disconnected";
                radioButtonStatus.Checked = false;
            }

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPort.SelectedItem.ToString();
            serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.SelectedItem.ToString());

            serialPort1.Open();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void buttonTestLedOn_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("on");
        }

        private void buttonTestLedOff_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("off");
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                dataTerima = serialPort1.ReadLine();
                this.Invoke((MethodInvoker)delegate
                {
                    DataSensor();
                });
            }
            catch (Exception gagal)
            {
                //error handling
                //MessageBox.Show(gagal.ToString());
            }
        }

        private void DataSensor()
        {
            try
            {
                //label1.Text = dataTerima;
                string[] data = dataTerima.Split(',');
                if (dataTerima[0] == 'I')
                {
                    dataSuhu = (double.Parse(data[1]));
                    dataKekeruhanAir = (double.Parse(data[2]));
                    dataPHAir = (double.Parse(data[3]));
                    dataDO = (double.Parse(data[4]));

                    labelValTemperature.Text = data[1];
                    labelvalWaterTurbidity.Text = data[2];
                    labelValPH.Text = data[3];
                    labelValDO.Text = data[4];


                }
            }
            catch (Exception gagal)
            {
                //error handling
                //MessageBox.Show(gagal.ToString());
            }
        }




    }
}
