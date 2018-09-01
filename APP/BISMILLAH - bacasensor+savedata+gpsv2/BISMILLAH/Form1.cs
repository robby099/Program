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
using MySql.Data.MySqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Web;

namespace BISMILLAH
{
    public partial class Form1 : Form
    {
        MySqlConnection Connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        double
           dataSuhu,
           dataKekeruhanAir,
           dataPHAir,
           dataDO,
           lattitude,
           longitude;
        string currentLocation;
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
            catch (Exception ex)
            {
                //error handling
                MessageBox.Show(ex.ToString());
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
                    lattitude = (double.Parse(data[5]));
                    longitude = (double.Parse(data[6]));

                    labelValTemperature.Text = data[1];
                    labelvalWaterTurbidity.Text = data[2];
                    labelValPH.Text = data[3];
                    labelValDO.Text = data[4];
                    labelLattitude.Text = data[5];
                    labelLongitude.Text = data[6];

                    currentLocation = labelLattitude.Text + "," + labelLongitude.Text;

                    Thread networkThread = new Thread(new ThreadStart(getMap));
                    networkThread.Start();
                }
            }
            catch (Exception ex)
            {
                //error handling
                //MessageBox.Show(ex.ToString());
            }
        }

        private void buttonStartRecord_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO db_sensor.tb_sensor(suhu_air,kekeruhan_air,ph_air,do_air)VALUES('" + labelValTemperature.Text + "','" + labelvalWaterTurbidity.Text + "'," + labelValPH.Text + "," + labelValDO.Text + ")";
            Connection.Open();
            MySqlCommand Command = new MySqlCommand(insertQuery,Connection);
            try
            {
                if (Command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data not inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();
        }

        private void getMap()
        {
            try
            {
                WebRequest request = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?" +
                                                        "center=" + currentLocation +
                                                        "&zoom=15" +
                                                        "&size=700x225" +
                                                        "&maptype=roadmap" +
                                                        "&markers=color:blue|label:R|" + currentLocation);

                WebResponse response = request.GetResponse();
                Stream resultStream = response.GetResponseStream();
                Image mapImage = Bitmap.FromStream(resultStream);
                pictureBoxMap.Image = mapImage;
            }
            catch (Exception ex)
            {
                //error handling
            }
           
        }
    }
}
