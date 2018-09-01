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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMap.NET.CacheProviders;
using GMap.NET.ObjectModel;
using GMap.NET.Projections;
using GMap.NET.Properties;

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
        string dataTerima;
        string dataKirim;
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
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                //error handling
            }
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
            try
            {
                string insertQuery = "INSERT INTO db_sensor.tb_sensor(suhu_air,kekeruhan_air,ph_air,do_air)VALUES('" + labelValTemperature.Text + "','" + labelvalWaterTurbidity.Text + "'," + labelValPH.Text + "," + labelValDO.Text + ")";
                Connection.Open();
                MySqlCommand Command = new MySqlCommand(insertQuery, Connection);
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
            catch (Exception ex)
            {
                //error handling
            }
        }

        private void buttonTestLoadMap_Click(object sender, EventArgs e)
        {
            try
            {
                map.DragButton = MouseButtons.Left;
                map.MapProvider = GMapProviders.GoogleMap;
                double lat = Convert.ToDouble(lattitude);
                double lon = Convert.ToDouble(longitude);
                map.Position = new GMap.NET.PointLatLng(lat, lon);
                map.MinZoom = 5;
                map.MaxZoom = 100;
                map.Zoom = 10;

                GMap.NET.PointLatLng point = new GMap.NET.PointLatLng(lat, lon);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);

                List<GMap.NET.PointLatLng> list = new List<GMap.NET.PointLatLng>();
                list.Add(new GMap.NET.PointLatLng(lattitude,longitude));
                GMapRoute r = new GMapRoute(list, "my route");
                r.Stroke.Width = 8;
                r.Stroke.Color = Color.Red;
                map.ZoomAndCenterRoute(r);
                map.Zoom = 15;


            }
            catch (Exception ex)
            {
                //error handling
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            map.Zoom += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double lat = Convert.ToDouble(labelLattitude.Text);
            double lon = Convert.ToDouble(labelLongitude.Text);
            map.Position = new GMap.NET.PointLatLng(lat, lon);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            map.Zoom -= 1;
        }

        private void labelDate_Click(object sender, EventArgs e)
        {
            //labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            //labelTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("A");
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("B");
        }

        private void buttonClib_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("C");
        }


    }
}
