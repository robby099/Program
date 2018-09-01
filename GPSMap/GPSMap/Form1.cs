using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSMap
{
    public partial class Form1 : Form
    {
        private string comport;
        private string[] locationarray;
        private string latitude;
        private string longitude;
        private string currentlocation;
        private string output;
        public Form1()
        {
            InitializeComponent();

            // List all communication ports available
            string[] allports = SerialPort.GetPortNames();

            foreach(string port in allports){
                // Add communication ports to combobox
                comboBox1.Items.Add(port);

            }

            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start reading values from gps device com port
            comport = comboBox1.SelectedItem.ToString();

            Thread comthread = new Thread(new ThreadStart(startReader));
            comthread.Start();          
        }

        private void startReader()
        {
            // Initialize serial communication 
            SerialPort sp = new SerialPort(comport, 9600, Parity.None, 8, StopBits.One);
            sp.Open();
            output = "";
            while((output = sp.ReadLine()) != null){
                Console.WriteLine(output);
                locationarray = output.Split(';');
                latitude = locationarray[0];
                longitude = locationarray[1];

                setTextLabel7(latitude);
                setTextLabel8(longitude);


                currentlocation = latitude + "," + longitude;

                Thread networkthread = new Thread(new ThreadStart(getmap));
                networkthread.Start();
            }
        }

        private void getmap()
        {
            // Connect to Google Maps static map api
            WebRequest request = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?" +
                                    "center=" + currentlocation +
                                    "&zoom=10" +
                                    "&size=276x210" +
                                    "&maptype=roadmap" +
                                    "&markers=color:blue|label:R|" + 
                                    currentlocation);
            
            // Start receiving response from static map api
            WebResponse response = request.GetResponse();

            // Read binary stream from received output
           Stream resultstream = response.GetResponseStream();

           Image mapimage = Bitmap.FromStream(resultstream);

           pictureBox2.Image = mapimage;
        }

        delegate void SetTextCallback(string text);

        private void setTextLabel7(string latitude)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label7.InvokeRequired && this.label8.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setTextLabel7);
                this.Invoke(d, new object[] { latitude });
            }
            else
            {
                this.label7.Text = latitude;
                
            }
        }

        private void setTextLabel8(string longitude)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label7.InvokeRequired && this.label8.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setTextLabel8);
                this.Invoke(d, new object[] { longitude });
            }
            else
            {
                this.label8.Text = longitude;

            }
        }


      }    
}
