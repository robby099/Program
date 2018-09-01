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
using System.Data.Odbc;
using MySql.Data.MySqlClient;


namespace BISMILLAH
{
    public partial class Form1 : Form
    {
        double
           dataSuhu,
           dataKekeruhanAir,
           dataPHAir,
           dataDO;
        string dataTerima;

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

        private void buttonTestLedOff_Click(object sender, EventArgs e)
        {
            
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

        private void buttonSaveRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3307;username=root;password=";
                string Query = "insert into db_sensor.tb_sensor(suhu_air,kekeruhan_air,ph_air,do_air) values('" + this.labelValTemperature.Text + "','" + this.labelvalWaterTurbidity.Text + "','" + this.labelValPH.Text + "','" + this.labelValDO.Text +"');";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                MessageBox.Show("save data");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                //error handling
                MessageBox.Show(ex.Message);
            }

        }

    }
}
