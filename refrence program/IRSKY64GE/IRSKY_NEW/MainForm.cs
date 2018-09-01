/*
 * Created by SharpDevelop.
 * User: G2TC
 * Date: 7/16/2017
 * Time: 7:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
OPENTK 
 // new OpenTK.GLControl(new OpenTK.Graphics.GraphicsMode(new OpenTK.Graphics.ColorFormat(32), 24, 0, 8));
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;

using System.Globalization;
using System.IO.Ports;
using System.IO;
using System.Drawing.Imaging;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace IRSKY_NEW
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	
		public enum cMap{
				MAP, SATELLIT
		};
		
		public enum cAttitude{
			PYRAMID, ROCKET, BOX_ARROW
		}
		
		public struct featuresConf{
			public bool 
				_3dModel,
				_compass,
				_altVdist,
				_accChart,
				_map,
				_odometri,
				_saveRC,
				_UTD;
		};
		
		//Define Constanta HERE
		const string 
			gpsHeader = "$G",
			sensorHeader = "$R",
			dataEOF = "\r\n";
		
		const string
			
			
			TAKE_PICTURE 	= "C",
			FIRST_START		= "A",
			SECOND_START 	= "C",
			STOP			= "B",
			TEST_DATA		= "X";
		
		const int
			PIXEL_FRAME = 100,
			MAX_IMG = 60000;
			
		const double intDTime = 0.03;
		
		//Define Variables HERE
		public cMap optMap;
		public cAttitude optAttitude;
		
		String
			dataRecPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Data",
            resPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources",
            buffer,
			mode;

        bool
            parasutMode = false,
            dataON = true,
            modelON = false,
            odoON = false,
            chartON = false,

            threadCTRL = true,
			pictMode,
			stableGrav = false;
		
		byte
			[] img = new byte[MAX_IMG];
		
		int
			maxDist = 0,
			sensCounter = 0,
			gpsCounter = 0,
		
			indexAltDist = 0,
			pixelPointer,
			pixelLength,
			pixelLeft;
		
		double	[] logAX = new double[100];
		double	[] logAY = new double[100];
		double	[] logAZ = new double[100];
		int [] logAlt = new int[600];
		int [] logDist = new int[600];
		
		double
			roll,
			pitch,
			yaw,
			
			ax, ay, az,
			
			apooge = 0;
		
		uint
			indexIMG = 0,
			pktSpeed = 0,
			pktErr = 0;

		UInt64 
			pktRecv = 0,
			pktLRecv = 0,
			pktTra = 0,
            pictTK = 0,
            pictErr = 0;

        public featuresConf ftConf;
		
		Thread telcomThread;
        Thread odoThread;
        Thread modelThread;

		StreamWriter dataRecFS;
		BinaryWriter dataIMGFS;
		
		Stopwatch pictTimeout = new Stopwatch();
		Stopwatch stopRate = new Stopwatch();
		Stopwatch flightTime = new Stopwatch();
		
		fIntegral AXi = new fIntegral(intDTime);
		fIntegral AYi = new fIntegral(intDTime);
		fIntegral AZi = new fIntegral(intDTime);
		
		PointLatLng plMPos = new PointLatLng(-8.160423, 110.723777);	// POLIJE
		PointLatLng gcsMPos = new PointLatLng(-8.160423, 110.723777);	// POLIJE
		PointLatLng P1, P2;
		
		GMapOverlay markers = new GMapOverlay();
        GMapRoute fPath = new GMapRoute("Route");
        GMapMarker PLloc;
		GMapMarker GCSloc;

       

        private void updateagSpeed(int val)
        {
            agSpeed.GaugeLabels[0].Text = val.ToString();
            agSpeed.Value = val;
        }

		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            PLloc = new GMarkerGoogle(plMPos, (Bitmap)Image.FromFile(resPath + "\\pl.png"));
            GCSloc = new GMarkerGoogle(gcsMPos, GMarkerGoogleType.green_pushpin); GCSloc = new GMarkerGoogle(gcsMPos, (Bitmap)Image.FromFile(resPath + "\\gcs.png"));


            optAttitude = cAttitude.PYRAMID;
			optMap = cMap.MAP;
			dataRecFS =  new StreamWriter(dataRecPath + "\\Data_Sensor" + postFix("txt"));
			ftConf._saveRC = true;
			//GCSloc = new GMarkerGoogle(markerPos, picGCS);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public string gcsLAT{
			get {
				return lblGlat.Text;
			}
			set{
				lblgcsLati.Text = value;
			}
		}
		
		public string gcsLNG{
			get {
				return lblGlong.Text;
			}
			set{
				lblgcsLong.Text = value;
			}
		}
		
		public PointLatLng updateGCSloc{
			set{
				GCSloc.Position = gcsMPos =  value;
				fPath.Points.Clear();
				lblgcsLati.Text = value.Lat.ToString();
				lblgcsLong.Text = value.Lng.ToString();
				
				for(int i = 0; i < (indexAltDist + 1); i++){
					logAlt[i] = 0;
					logDist[i] = 0;
				}
				gMapCtrl.Position = plMPos;
				indexAltDist = 0;
				maxDist = 0;
				sensCounter = 0;
				gpsCounter = 0;
				pktLRecv = 0;
				pktRecv = 0;
				pktSpeed = 0;
				pktErr = 0;
				pktTra = 0;
				
				lblPerr.Text = pktErr.ToString();
				
			}
		}
		
		public GMapProvider updateView{
			set{
				gMapCtrl.MapProvider = value;
			}
		}
		void telcom(string msg){
			//MessageBox.Show(msg);
			try{
				spTRX.Write(msg);

                pktTra++;
                if (lblPTrans.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblPTrans.Text = pktTra.ToString();
                    });
                }else
                    lblPTrans.Text = pktTra.ToString();
            }
			catch(System.InvalidOperationException){
				MessageBox.Show("Port is closed\nPlease connect first");
			}
		}
		
		public static Image RotateImage(Image img, float rotationAngle)
		{
		    //create an empty Bitmap image
		    Bitmap bmp = new Bitmap(img.Width, img.Height);
		
		    //turn the Bitmap into a Graphics object
		    Graphics gfx = Graphics.FromImage(bmp);
		
		    //now we set the rotation point to the center of our image
		    gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
		
		    //now rotate the image
		    gfx.RotateTransform(rotationAngle);
		
		    gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
		
		    //set the InterpolationMode to HighQualityBicubic so to ensure a high
		    //quality image once it is transformed to the specified size
		    gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
		
		    //now draw our new image onto the graphics object
		    gfx.DrawImage(img, new Point(0, 0));
		
		    //dispose of our Graphics object
		    gfx.Dispose();
		
		    //return the image
		    return bmp;
		}
		
		string postFix(string ext){
			string res;
			
			res = "_" +
				DateTime.Now.Year.ToString("D2") + DateTime.Now.Month.ToString("D2") + DateTime.Now.Day.ToString("D2") + "_" +
				DateTime.Now.Hour.ToString("D2") + DateTime.Now.Minute.ToString("D2") + DateTime.Now.Second.ToString("D2") + "." + ext;
			
			return res;
		}
		
		void showIMG(string msg){
			MemoryStream pict = new MemoryStream(img);

            if (img[0] != 0xFF) {
                lblIMGPros.Text = msg + "\nHeader Herror";
                pictErr++;
                if (lblpictErr.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblpictErr.Text = pictErr.ToString();
                    });
                }
                else
                    lblpictErr.Text = pictErr.ToString();

                return;
            }
            else
                lblIMGPros.Text = msg;

            try
            {
                pbPicture.Image = Image.FromStream(pict);
                pbPicture.Invalidate();
            }catch(SystemException e)
            {
                lblIMGPros.Text = "Image ERROR";
                pictErr++;
                if (lblpictErr.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblpictErr.Text = pictErr.ToString();
                    });
                }
                else
                    lblpictErr.Text = pictErr.ToString();
                return;

            }
            pictTK++;
            pictErr++;
            if (lbltakePict.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lbltakePict.Text = pictTK.ToString();
                });
            }
            else
                lbltakePict.Text = pictTK.ToString();

            dataIMGFS = new BinaryWriter(File.Open(dataRecPath + "\\IMG" + postFix("JPG"), FileMode.Create));
			dataIMGFS.Write(img, 0, pixelLength);
			dataIMGFS.Close();
			indexIMG++;
			
			//telcom(FIRST_START);
			mode = FIRST_START;
		}

        void updateOdoThread()
        {
            while (threadCTRL)
            {
                if (this.InvokeRequired && odoON)
                {
                    odoON = false;
                    this.Invoke((MethodInvoker)delegate
                    {
                        updateOdometri();
                    });
                }

                

                Thread.Sleep(100);
            }
        }



        void updateModelThread()
        {
            while (threadCTRL)
            {
                if (this.InvokeRequired && modelON)
                {
                    modelON = false;
                    this.Invoke((MethodInvoker)delegate
                    {
                        updateglAtt();
                    });
                }

                if (this.InvokeRequired && chartON && ftConf._accChart)
                {
                    chartON = false;
                    this.Invoke((MethodInvoker)delegate
                   {
                       updateChartAccel();
                   });
                }

                Thread.Sleep(50);
            }
        }

		void startCOM(){

			while(threadCTRL){
                if (!dataON)
                    this.Invoke((MethodInvoker)delegate
                    {
                        telcom(FIRST_START);
                    });
                
                Thread.Sleep(500);	            	
			}
                // this.Text = ((pos / 1000).ToString() + "KB");			
		}
		
		void updateOdometri(){
			if(ftConf._UTD){
				double latDist, lngDist;				
				// Latitude distance
				P1.Lat = gcsMPos.Lat;
				P2.Lat = plMPos.Lat;
				// Ignore longitude
				P1.Lng = gcsMPos.Lng;
				P2.Lng = gcsMPos.Lng;
				
				latDist = Functions.DistanceBetweenPlaces(P1, P2);
				
				//Longitude distance
				P1.Lng = gcsMPos.Lng;
				P2.Lng = plMPos.Lng;
				// ignore latitude
				P1.Lat = gcsMPos.Lat;
				P2.Lat = gcsMPos.Lat;
				
				lngDist = Functions.DistanceBetweenPlaces(P1, P2);
				odoPoint.Add(lngDist, 0, latDist);
			}
			else{
					odoPoint.Add(AXi.getDist(), AZi.getDist(), AYi.getDist());
			}
		}
		
		private void procData(object sender, string data){
			/*
			 * FORMAT DATA
			 * 
			 * I,209.63,-4.79,115.06,68.05,-34.20,9.36,119.49,-56.46,-5.94
			 * G,0.00,0.00,0.00,0.00,0.00,0,0,0,0,0
			 * 
			 * 
			*/
			//MessageBox.Show("OK");
			int imgPros;
            
			byte chksum = 0;
			double gx, gy, gz, dftime;
			double ax1, ay1, az1;

			string dataREC;
			
			string [] packet = data.Split(',');

            dataON = true;

			if (stopRate.ElapsedMilliseconds > 1000){
						pktSpeed = ((uint)(pktRecv - pktLRecv));
						pktLRecv = pktRecv;
				
						lblPSpeed.Text = pktSpeed.ToString() + " Hz";
						stopRate.Restart();
			}
			
			if (mode == TAKE_PICTURE){
				if(pictMode){
					imgPros = (int.Parse(data) * 100) / pixelLength;
					lblIMGPros.Text = "Downloading...\n" + imgPros.ToString() + "%" + " (" + data + "/" + pixelLength.ToString() + ")";

                    chartON = true;

					if(imgPros >= 99)
						showIMG("Complete");
						
				}
			}else{
				lblRAW.Text = data;
				if(data[0] == 'I' && packet.Length == 13){
						
					ax = (double.Parse(packet[1]) * 0.016 * 9.807);
					ay = (double.Parse(packet[2]) * 0.016 * 9.807);
					az = (double.Parse(packet[3]) * 0.016 * 9.807);
					
					ax1 = (double.Parse(packet[4]) * 0.0039 * 9.807);
					ay1 = (double.Parse(packet[5]) * 0.0039 * 9.807);
					az1 = (double.Parse(packet[6]) * 0.0039 * 9.807);
					
					gx = (double.Parse(packet[7]) / 14.375);
					gy = (double.Parse(packet[8]) / 14.375);
					gz = (double.Parse(packet[9]) / 14.375);
					
					roll = double.Parse(packet[12]);
					pitch = Convert.ToDouble(packet[11]);
					yaw = double.Parse(packet[10]);

                    //MOVE TO GPS parasutMode = packet[13][0];
                    
                    
					pktRecv++;	
					
					if(((az - AZi.zeroGravity) > 5) && stableGrav == true && flightTime.IsRunning == false){
						flightTime.Start();
					}
					
					dftime = flightTime.ElapsedMilliseconds / 1000.0;
			
					sensCounter++;
					lblPrec.Text = pktRecv.ToString();
					lblFtime.Text = dftime.ToString("F2");

                    if (ftConf._odometri)
                    {
                        if (!parasutMode)
                        {
                            AXi.intACC(ax * (-1), false);
                            AYi.intACC(ay, false);
                            AZi.intACC(az, false);
                        }
                        else
                        {
                            // Ganti akselero utama ke accelero IMU
                            ax = ax1;
                            ay = ay1;
                            az = az1;

                            AXi.intACC(ax, true);
                            AYi.intACC(ay, true);
                            AZi.intACC(az, true);
                        }
                        odoON = true;
                    }

                    if (!ftConf._saveRC){						

						dataREC =
							String.Format("{0:0.00}\t{1:0.00}\t{2:0.00}\t\t{3:0.00}\t{4:0.00}\t{5:0.00}\r\n",
							              ax, ay, az, ax1, ay1, az1);
							
						// UPDATE GRAPH and MODELS and RECORD
						dataRecFS.Write(dataREC);
					}else{
						dataREC = 
							String.Format("{0},{1},{2},{3:0.00},{4:0.00},{5:0.00},{6:0.00},{7:0.00}," +
							              "{8:0.00},{9:0.00},{10:0.00},{11:0.00},{12:0.00}",
							              sensorHeader, sensCounter, lblgpsTime.Text, lblFtime.Text, roll, pitch, yaw,
							              ax / 9.087, ay / 9.087, az / 9.087, gx, gy, gz);
						
						chksum = Functions.sumCal(dataREC);
						
						dataREC += '*' + chksum.ToString("X2") + '\r' + '\n';
							
						// UPDATE GRAPH and MODELS and RECORD
						dataRecFS.Write(dataREC);
					}

					
					

                    if (ftConf._accChart)
                        chartON = true;
                    if (ftConf._3dModel)
                        modelON = true;
					
	
				}else if(data[0] == 'G' && packet.Length == 12){
					int gHour, gMinute, gSecond;
					double lati = 0, longi = 0, gAlt, gDist, gSpeed;
					
					lblGlong.Text = packet[1];
					lblGlat.Text = packet[2];
					gAlt = double.Parse(packet[3]);
					gSpeed = Functions.toKMPH(double.Parse(packet[4]));

                    lblGhead.Text = packet[5];
					lblGsat.Text = packet[6];
                    lblGspeed.Text = gSpeed.ToString("F2") + " kmph";
                    
                    if (packet[7] == "0")
						lblFixQ.Text = packet[7] + " (Invalid)";
					else
						lblFixQ.Text = packet[7] + " (GPS FIX)";

					gHour = int.Parse(packet[8]);
					gMinute = int.Parse(packet[9]);
					gSecond = int.Parse(packet[10]);

                    if (packet[11][0] == '0')
                        parasutMode = true;

                    if (parasutMode)
                    {
                        lblBatt.Text = "ON";
                        lblBatt.ForeColor = Color.Green;
                    }

                    lati = double.Parse(lblGlat.Text);
					longi = double.Parse(lblGlong.Text);
					
					sensCounter = 0;						
					apooge = (gAlt > apooge) ? gAlt : apooge;					
					lblApoge.Text = apooge.ToString();					
					lblGalt.Text = gAlt.ToString() + " M";

                    updateagSpeed((int)apooge);


                    if (lati != 0){						
						plMPos.Lat = lati;
						plMPos.Lng = longi;
						gDist = Functions.DistanceBetweenPlaces(gcsMPos, plMPos);
						gpsCounter++;
						
						lblHead.Text = Math.Atan2(gAlt, gDist).ToString("F2");
						lblgpsCounter.Text = gpsCounter.ToString();
						
						if(ftConf._map){
							fPath.Points.Add(plMPos);
							PLloc.Position = plMPos;
							gMapCtrl.UpdateRouteLocalPosition(fPath);
						}
						
						lblDist.Text = String.Format("{0:0.00} M", gDist);
						
						lblLocStat.Visible = false;
	
						if(ftConf._altVdist)
							updateAltDistChart((int)gAlt, (int)gDist);
					}else{
						lblLocStat.Visible = true;
					}
						
					if(gHour < 10)
						lblgpsTime.Text = "0" + gHour.ToString();
					else
						lblgpsTime.Text = gHour.ToString();
					
					if(gMinute < 10)
						lblgpsTime.Text += "0" + gMinute.ToString();
					else
						lblgpsTime.Text += gMinute.ToString();
					
					if(gSecond < 10)
						lblgpsTime.Text += "0" + gSecond.ToString();
					else
						lblgpsTime.Text += gSecond.ToString();

					if(ftConf._saveRC){
						dataREC =
							String.Format("{0},{1},{2:0.000000},{3:0.000000},{4:0.00},{5},{6},{7:0.00},{8}",
							              gpsHeader, lblgpsTime.Text, lblGlong.Text, lblGlat.Text, gAlt,
							              packet[7], lblGsat.Text, gSpeed, lblHead.Text);
						
						chksum = Functions.sumCal(dataREC);
						dataREC += '*' + chksum.ToString("X2") + '\r' + '\n';
						
						dataRecFS.Write(dataREC);
					}
						              
				}else{
					pktErr++;
					lblPerr.Text = pktErr.ToString();
				}
			}

		}
		
		private void Read_TRX(object sender1, System.IO.Ports.SerialDataReceivedEventArgs e1){
			try{
				if (mode == TAKE_PICTURE){
					if(pictTimeout.ElapsedMilliseconds > 10000)
                    {
                        mode = FIRST_START;
                        showIMG("Success");
                    }
						
					if (pictMode == false){
						buffer =  spTRX.ReadLine();

                        if ((buffer[0] == 'I' || buffer[0] == 'G'))
                        {
                            telcom(TAKE_PICTURE);
                            

                        }
                        else
                        {
                            pixelLeft = int.Parse(buffer);
                            pixelLength = int.Parse(buffer);
                            pictMode = true;
                        }
						this.Invoke(new EventHandler((sender, data) => procData(sender1, buffer)));
					}
					else{					
						if (spTRX.BytesToRead >= PIXEL_FRAME){															
							spTRX.Read(img, pixelPointer, PIXEL_FRAME);
							if (pixelLeft >= PIXEL_FRAME)
								pixelLeft -= PIXEL_FRAME;
							
							//procData(byte_offset.ToString());
							this.Invoke(new EventHandler((sender, data) => procData(sender1, pixelPointer.ToString())));
							pixelPointer += PIXEL_FRAME;
						}
											
						if (pixelLeft < PIXEL_FRAME){
							if(spTRX.BytesToRead >= pixelLeft){
								spTRX.Read(img, pixelPointer, pixelLeft);
								//MessageBox.Show(res.ToString());
								pixelPointer += PIXEL_FRAME;
								//procData(byte_offset.ToString());
								this.Invoke(new EventHandler((sender, data) => procData(sender1, buffer)));
							}
						}
					}
				}else if(mode == STOP){
					telcom(STOP);
                   
                    buffer =  spTRX.ReadLine();
					this.Invoke(new EventHandler((sender, data) => procData(sender1, buffer)));
				}
				else{
					//MessageBox.Show("OK");
					buffer =  spTRX.ReadLine();
					this.Invoke(new EventHandler((sender, data) => procData(sender1, buffer)));
				}
			}
			catch (System.IO.IOException)
			{
    			return;
			}
			catch (System.InvalidOperationException)
			{
   			 	return;
			}
			catch(System.Exception){
				return;
			}
			//this.Invoke(new EventHandler((sender, data) => procdata1(sender1, buffer)));
		}
		
		void updateAltDistChart(int alt, int dist){
			logAlt[indexAltDist] = alt;
			maxDist = (dist > maxDist) ? dist : maxDist;
			
			logDist[indexAltDist] = maxDist;
			
			chAltvsDist.Series["AltDist"].Points.Clear();
			for (int i = 0; i < indexAltDist; i++){
				chAltvsDist.Series["AltDist"].Points.AddXY(logDist[i], logAlt[i]);
			}
			indexAltDist++;
		}

		void updateChartAccel(){
            double
                pAX = ax,
                pAY = ay,
                pAZ = az;

            chAccelero.Series["X"].Points.Clear();
			chAccelero.Series["Y"].Points.Clear();
			chAccelero.Series["Z"].Points.Clear();
			
			for (int i = 0; i < 50; i++){
				logAX[i] = logAX[i + 1];
				logAY[i] = logAY[i + 1];
				logAZ[i] = logAZ[i + 1];
								
			}
			logAX[50] = pAX;
			logAY[50] = pAY;
			logAZ[50] = pAZ;
			
			for(int i = 0; i < 50; i++){
				chAccelero.Series["X"].Points.AddXY(50 - i, logAX[50 - i]);
				chAccelero.Series["Y"].Points.AddXY(50 - i, logAY[50 - i]);
				chAccelero.Series["Z"].Points.AddXY(50 - i, logAZ[50 - i]);                                      
				
			}
		}
		
		void CbPortClick(object sender, EventArgs e)
		{
			string [] cname = SerialPort.GetPortNames();
			cbPort.Items.Clear();
			foreach(string port in cname){
				cbPort.Items.Add(port);
			}
			try{
				cbPort.Text = cname[0];
				cbBaud.Text = "57600";
			}
			catch(System.IndexOutOfRangeException){
				MessageBox.Show("No COM Port Found");
			}
	
		}
		
		
		void BtntrxConClick(object sender, EventArgs e)
		{
			if (btntrxCon.Text == "Connect"){
				spTRX.PortName = cbPort.Text;
				spTRX.BaudRate = int.Parse(cbBaud.Text);
				spTRX.Open();
				spTRX.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Read_TRX);
				//MessageBox.Show("OK");
				btntrxCon.Text = "Disconnect";
				cbBaud.Enabled = false;
				cbPort.Enabled = false;
			}
			else{
				spTRX.Close();
				btntrxCon.Text = "Connect";
				cbBaud.Enabled = true;
				cbPort.Enabled = true;
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
            MessageBox.Show("Bismillahirrohmanirrohim", "Semoga Sukses");

            Color4 glColor = Color4.SlateGray;
            pictMode = false;
			mode = STOP;
			pixelPointer = 0;

            glAtti.MakeCurrent();

            GL.ClearColor(glColor);
            updateglAtt();
			glAtti.Invalidate();
			
			gMapCtrl.DragButton = MouseButtons.Left;
			gMapCtrl.CanDragMap = true;
			gMapCtrl.MapProvider = GMapProviders.GoogleMap;
			gMapCtrl.Position = plMPos;
			gMapCtrl.AutoScroll = true;
			gMapCtrl.MinZoom = 0;
			gMapCtrl.MaxZoom = 20;
			gMapCtrl.Zoom = 19.5;

            fPath.Stroke = new Pen(Color.DarkOrange, 10.0f);

            markers.Routes.Add(fPath);
			markers.Markers.Add(PLloc);
			markers.Markers.Add(GCSloc);
			
			gMapCtrl.Overlays.Add(markers);
			this.tcOdo.Aspect.View3D = true;
			lblPerr.Text = pktErr.ToString();

            telcomThread = new Thread(startCOM);
            telcomThread.Start();

            odoThread = new Thread(updateOdoThread);
			odoThread.Start();

            modelThread = new Thread(updateModelThread);
            modelThread.Start();
		}
		
		
		void updateglAtt()
		{
			//'First Clear Buffers
			GL.Clear(ClearBufferMask.ColorBufferBit);
			GL.Clear(ClearBufferMask.DepthBufferBit);

        	//'Basic Setup for viewing
	        Matrix4 perspective, lookat;
        	perspective = Matrix4.CreatePerspectiveFieldOfView(1.04f, 4 / 3, 1f, 10000f);// 'Setup Perspective
        	
 			//Matrix4.CreatePerspectiveFieldOfView(0.45f, (float)width / height, 0.1f, 1000f));
        	
        	 lookat = Matrix4.LookAt(100, 20, 0, 0, 0, 0, 0, 1, 0); // 'Setup camera
        	GL.MatrixMode(MatrixMode.Projection);// 'Load Perspective
        	GL.LoadIdentity();
        	GL.LoadMatrix(ref perspective);
        	GL.MatrixMode(MatrixMode.Modelview);// 'Load Camera
        	GL.LoadIdentity();
        	GL.LoadMatrix(ref lookat);
        	GL.Viewport(0, 0, glAtti.Width, glAtti.Height);// 'Size of window
        	GL.Enable(EnableCap.DepthTest);// 'Enable correct Z Drawings
        	GL.DepthFunc(DepthFunction.Less);// 'Enable correct Z Drawings
	
        	//'Rotating
        	GL.Rotate(roll, 0, 0, 1);
        	GL.Rotate(-pitch, 1, 0, 0);
        	GL.Rotate(-yaw, 0, 1, 0);

            if (optAttitude == cAttitude.PYRAMID)
            {

                //'Draw pyramid, Y is up, Z is twards you, X is left and right
                //'Vertex goes (X,Y,Z)

                GL.Begin(BeginMode.Triangles);
                //'Face 1
                GL.Color3(Color.Red);
                GL.Vertex3(50, 0, 0);
                GL.Color3(Color.White);
                GL.Vertex3(0, 25, 0);
                GL.Color3(Color.Blue);
                GL.Vertex3(0, 0, 50);
                // 'Face 2
                GL.Color3(Color.Green);
                GL.Vertex3(-50, 0, 0);
                GL.Color3(Color.White);
                GL.Vertex3(0, 25, 0);
                GL.Color3(Color.Blue);
                GL.Vertex3(0, 0, 50);
                //'Face 3
                GL.Color3(Color.Red);
                GL.Vertex3(50, 0, 0);
                GL.Color3(Color.White);
                GL.Vertex3(0, 25, 0);
                GL.Color3(Color.Blue);
                GL.Vertex3(0, 0, -50);
                //'Face 4
                GL.Color3(Color.Green);
                GL.Vertex3(-50, 0, 0);
                GL.Color3(Color.White);
                GL.Vertex3(0, 25, 0);
                GL.Color3(Color.Blue);
                GL.Vertex3(0, 0, -50);
            }else if(optAttitude == cAttitude.ROCKET)
            {
                //        'Draw pyramid, Y is up, Z is twards you, X is left and right
                //'Vertex goes (X,Y,Z)
                //bentuk badan
                GL.Begin(BeginMode.Quads);

                GL.Color3(Color.Yellow);    //kiri
                GL.Vertex3(-6, 30, 6);
                GL.Color3(Color.Yellow);
                GL.Vertex3(-8, -30, 8);
                GL.Color3(Color.Red);
                GL.Vertex3(8, -30, 8);
                GL.Color3(Color.Red);
                GL.Vertex3(6, 30, 6);

                GL.Color3(Color.GreenYellow); //kanan
                GL.Vertex3(-6, 30, -6);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(-8, -30, -8);
                GL.Color3(Color.Green);
                GL.Vertex3(8, -30, -8);
                GL.Color3(Color.Green);
                GL.Vertex3(6, 30, -6);

                GL.Color3(Color.Yellow); //belakang
                GL.Vertex3(-6, 30, 6);
                GL.Color3(Color.Yellow);
                GL.Vertex3(-8, -30, 8);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(-8, -30, -8);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(-6, 30, -6);

                GL.Color3(Color.Red);  //depan
                GL.Vertex3(6, 30, 6);
                GL.Color3(Color.Red);
                GL.Vertex3(6, -30, 8);
                GL.Color3(Color.Green);
                GL.Vertex3(8, -30, -8);
                GL.Color3(Color.Green);
                GL.Vertex3(6, 30, -6);

                GL.Color3(Color.Red);  //bawah
                GL.Vertex3(8, -30, 8);
                GL.Color3(Color.Yellow);
                GL.Vertex3(-8, -30, 8);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(-8, -30, -8);
                GL.Color3(Color.Green);
                GL.Vertex3(8, -30, -8);

                GL.Color3(Color.Red);  //atas
                GL.Vertex3(6, 30, 6);
                GL.Color3(Color.Yellow);
                GL.Vertex3(-6, 30, 6);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(-6, 30, -6);
                GL.Color3(Color.Green);
                GL.Vertex3(6, 30, -6);

                //pucuk atas
                GL.Color3(Color.White); //kiri2
                GL.Vertex3(0, 45, 0);
                GL.Color3(Color.Yellow);
                GL.Vertex3(-13, 25, 10);
                GL.Color3(Color.Red);
                GL.Vertex3(13, 25, 10);
                GL.Color3(Color.White);
                GL.Vertex3(0, 45, 0);

                GL.Color3(Color.White); //kanan2
                GL.Vertex3(0, 45, 0);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(-13, 25, -10);
                GL.Color3(Color.Green);
                GL.Vertex3(13, 25, -10);
                GL.Color3(Color.White);
                GL.Vertex3(0, 45, 0);

                GL.Color3(Color.White); //belakang2
                GL.Vertex3(0, 45, 0);
                GL.Color3(Color.Yellow);
                GL.Vertex3(-13, 25, 10);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(-13, 25, -10);
                GL.Color3(Color.White);
                GL.Vertex3(0, 45, 0);

                GL.Color3(Color.White); //depan2
                GL.Vertex3(0, 45, 0);
                GL.Color3(Color.Red);
                GL.Vertex3(13, 25, 10);
                GL.Color3(Color.Green);
                GL.Vertex3(13, 25, -10);
                GL.Color3(Color.White);
                GL.Vertex3(0, 45, 0);

                //sirip bawah
                GL.Color3(Color.White); //kanan
                GL.Vertex3(0, -22, -8.1);
                GL.Color3(Color.Red);
                GL.Vertex3(0, -45, -20);
                GL.Color3(Color.Green);
                GL.Vertex3(0, -45, -8.1);
                GL.Color3(Color.White);
                GL.Vertex3(0, -22, -8.1);

                GL.Color3(Color.White); //kiri
                GL.Vertex3(0, -22, 8.1);
                GL.Color3(Color.Red);
                GL.Vertex3(0, -45, 20);
                GL.Color3(Color.Green);
                GL.Vertex3(0, -45, 8.1);
                GL.Color3(Color.White);
                GL.Vertex3(0, -22, 8.1);

                GL.Color3(Color.GreenYellow); //belakang
                GL.Vertex3(-20, -45, 0);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(-8.1, -22, 0);
                GL.Color3(Color.Green);
                GL.Vertex3(-8.1, -22, 0);
                GL.Color3(Color.Green);
                GL.Vertex3(-8.1, -45, 0);

                GL.Color3(Color.Green); //depan
                GL.Vertex3(8.1, -45, 0);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(8.1, -22, 0);
                GL.Color3(Color.Green);
                GL.Vertex3(8.1, -22, 0);
                GL.Color3(Color.GreenYellow);
                GL.Vertex3(20, -45, 0);
            }
	        //'Finish the begin mode with "end"
	        GL.End();
	        
	
	        //'Finally...
	        	GraphicsContext.CurrentContext.VSync = true;// 'Caps frame rate as to not over run GPU
	        glAtti.SwapBuffers();// 'Takes from the 'GL' and puts into control
		}
				
		void BtnFstartClick(object sender, EventArgs e)
		{
			if(dataRecFS.BaseStream == null){	
				dataRecFS =  new StreamWriter(dataRecPath + "\\Data_Sensor" + postFix("txt"));
			}
                       

            mode = FIRST_START;
            dataON = false;

            //telcomThread.Abort();
            
			stopRate.Start();
			
			//synTime.Enabled = true;
		}
		
		void BtnStopTRXClick(object sender, EventArgs e)
		{
            

			telcom(STOP);
			mode = STOP;
            dataON = true;
            synTime.Enabled = false;
			stopRate.Stop();
	
			if(dataRecFS.BaseStream != null)
				dataRecFS.Close();
	
			flightTime.Reset();
            parasutMode = false;
            lblBatt.Text = "OFF";
            lblBatt.ForeColor = Color.Black;
		}
		
		void BtnSstartClick(object sender, EventArgs e)
		{
				AXi.zeroGravity = ax * (-1);
				AYi.zeroGravity = ay;
				AZi.zeroGravity = az;
				
				stableGrav = true;
				odoPoint.Clear();
		}
		
		void BtnReserved1Click(object sender, EventArgs e)
		{
			Config cForm = new Config(this);
			
			cForm.tbLNG.Text = lblgcsLong.Text;
			cForm.tbLAT.Text = lblgcsLati.Text;
			
			cForm.cb3DM.Checked = ftConf._3dModel;
			cForm.cbAccChart.Checked = ftConf._accChart;
			cForm.cbAltvDist.Checked = ftConf._altVdist;
			cForm.cbCMPS.Checked = ftConf._compass;
			cForm.cbMap.Checked = ftConf._map;
			cForm.cbOdo.Checked = ftConf._odometri;
			cForm.cbSaveRC.Checked = ftConf._saveRC;
            cForm.cbUTD.Checked = ftConf._UTD;

			switch(optMap){
				case cMap.MAP:
					cForm.rbMap.Checked = true;
					cForm.rbSat.Checked = false;
					break;
				case cMap.SATELLIT:
					cForm.rbMap.Checked = false;
					cForm.rbSat.Checked = true;
					break;
			}
			
			switch(optAttitude){
				case cAttitude.PYRAMID:
					cForm.rbPyramid.Checked = true;
					cForm.rbRocket.Checked = false;
					cForm.rbSparkfun.Checked = false;
					break;
				case cAttitude.BOX_ARROW:
					cForm.rbPyramid.Checked = false;
					cForm.rbRocket.Checked = false;
					cForm.rbSparkfun.Checked = true;
					break;
				case cAttitude.ROCKET:
					cForm.rbPyramid.Checked = false;
					cForm.rbRocket.Checked = true;
					cForm.rbSparkfun.Checked = false;
					break;
			}
			
			cForm.TopMost = true;
			cForm.ShowDialog(this);
		}
		
		void BtntakePictClick(object sender, EventArgs e)
		{
            pktTra++;
            lblPTrans.Text = pktTra.ToString();

			telcom(TAKE_PICTURE);
			mode = TAKE_PICTURE;
			pixelPointer = 0;
			pictMode = false;
			pbPicture.Image = null;
			pbPicture.Invalidate();
			pictTimeout.Restart();
			for(int i = 0; i < MAX_IMG; i++)
				img[i] = 0;
			

		}

		void SynTimeTick(object sender, EventArgs e)
		{
		
		}
		void TCtimeTick(object sender, EventArgs e)
		{
			lblDatetime.Text = DateTime.Now.ToString("F");
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
            threadCTRL = false;
            
			
		}
		
		void CbPortSelectedIndexChanged(object sender, EventArgs e)
		{
		}
		void LblDatetimeClick(object sender, EventArgs e)
		{
	
		}
	}
}
