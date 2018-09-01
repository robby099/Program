/*
 * Created by SharpDevelop.
 * User: G2TC
 * Date: 7/16/2017
 * Time: 7:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace IRSKY_NEW
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnFstart;
		private System.Windows.Forms.Label lblDatetime;
		private System.Windows.Forms.Button btnSstart;
		private System.Windows.Forms.Button btntakePict;
		private System.Windows.Forms.Button btnReserved1;
		private System.Windows.Forms.Button btnStopTRX;
		private System.Windows.Forms.DataVisualization.Charting.Chart chAccelero;
		private System.Windows.Forms.DataVisualization.Charting.Chart chAltvsDist;
		private System.Windows.Forms.PictureBox pbPicture;
		private GMap.NET.WindowsForms.GMapControl gMapCtrl;
		private OpenTK.GLControl glAtti;
		private System.IO.Ports.SerialPort spTRX;
		private System.Windows.Forms.ComboBox cbBaud;
		private System.Windows.Forms.ComboBox cbPort;
		private System.Windows.Forms.Button btntrxCon;
		private System.Windows.Forms.Label lblgpsTime;
		private System.Windows.Forms.Label lblFixQ;
		private System.Windows.Forms.Label lblGsat;
		private System.Windows.Forms.Label lblGlong;
		private System.Windows.Forms.Label lblGlat;
		private System.Windows.Forms.Label lblGalt;
		private System.Windows.Forms.Label lblGhead;
		private System.Windows.Forms.Label lblGspeed;
		private System.Windows.Forms.Label lblFtime;
		private System.Windows.Forms.Label lblApoge;
		private System.Windows.Forms.Label lblHead;
		private System.Windows.Forms.Label lblPrec;
		private System.Windows.Forms.Label lblPTrans;
		private System.Windows.Forms.Label lblPSpeed;
		private System.Windows.Forms.Label lblPerr;
		private System.Windows.Forms.Label lblDist;
		private System.Windows.Forms.Label lblIMGPros;
		private System.Windows.Forms.Label lblLocStat;
		private System.Windows.Forms.Label lblgcsLong;
		private System.Windows.Forms.Label lblgcsLati;
		private System.Windows.Forms.Label lblBatt;
		private System.Windows.Forms.Label lblRAW;
		private System.Windows.Forms.Label lblgpsCounter;
		private Steema.TeeChart.TChart tcOdo;
		private Steema.TeeChart.Styles.Points3D odoPoint;
		private Steema.TeeChart.Tools.Rotate rotate1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.Windows.Forms.Timer synTime;
		private System.Windows.Forms.Timer tCtime;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            this.btnFstart = new System.Windows.Forms.Button();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.btnSstart = new System.Windows.Forms.Button();
            this.btntakePict = new System.Windows.Forms.Button();
            this.btnReserved1 = new System.Windows.Forms.Button();
            this.btnStopTRX = new System.Windows.Forms.Button();
            this.chAccelero = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chAltvsDist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.gMapCtrl = new GMap.NET.WindowsForms.GMapControl();
            this.glAtti = new OpenTK.GLControl();
            this.spTRX = new System.IO.Ports.SerialPort(this.components);
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.btntrxCon = new System.Windows.Forms.Button();
            this.lblgpsTime = new System.Windows.Forms.Label();
            this.lblFixQ = new System.Windows.Forms.Label();
            this.lblGsat = new System.Windows.Forms.Label();
            this.lblGlong = new System.Windows.Forms.Label();
            this.lblGlat = new System.Windows.Forms.Label();
            this.lblGalt = new System.Windows.Forms.Label();
            this.lblGhead = new System.Windows.Forms.Label();
            this.lblGspeed = new System.Windows.Forms.Label();
            this.lblFtime = new System.Windows.Forms.Label();
            this.lblApoge = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.lblPTrans = new System.Windows.Forms.Label();
            this.lblPSpeed = new System.Windows.Forms.Label();
            this.lblPerr = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.lblIMGPros = new System.Windows.Forms.Label();
            this.lblLocStat = new System.Windows.Forms.Label();
            this.lblgcsLong = new System.Windows.Forms.Label();
            this.lblgcsLati = new System.Windows.Forms.Label();
            this.lblBatt = new System.Windows.Forms.Label();
            this.lblRAW = new System.Windows.Forms.Label();
            this.lblgpsCounter = new System.Windows.Forms.Label();
            this.tcOdo = new Steema.TeeChart.TChart();
            this.odoPoint = new Steema.TeeChart.Styles.Points3D();
            this.rotate1 = new Steema.TeeChart.Tools.Rotate();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.synTime = new System.Windows.Forms.Timer(this.components);
            this.tCtime = new System.Windows.Forms.Timer(this.components);
            this.agSpeed = new System.Windows.Forms.AGauge();
            this.lbltakePict = new System.Windows.Forms.Label();
            this.lblpictErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chAccelero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAltvsDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFstart
            // 
            this.btnFstart.Location = new System.Drawing.Point(173, 37);
            this.btnFstart.Name = "btnFstart";
            this.btnFstart.Size = new System.Drawing.Size(62, 35);
            this.btnFstart.TabIndex = 0;
            this.btnFstart.Text = "First START";
            this.btnFstart.UseVisualStyleBackColor = true;
            this.btnFstart.Click += new System.EventHandler(this.BtnFstartClick);
            // 
            // lblDatetime
            // 
            this.lblDatetime.Location = new System.Drawing.Point(188, 13);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(245, 23);
            this.lblDatetime.TabIndex = 1;
            this.lblDatetime.Text = "12/12/2017 12:12:12 PM";
            this.lblDatetime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDatetime.Click += new System.EventHandler(this.LblDatetimeClick);
            // 
            // btnSstart
            // 
            this.btnSstart.Location = new System.Drawing.Point(173, 78);
            this.btnSstart.Name = "btnSstart";
            this.btnSstart.Size = new System.Drawing.Size(62, 35);
            this.btnSstart.TabIndex = 2;
            this.btnSstart.Text = "Zero Gravity";
            this.btnSstart.UseVisualStyleBackColor = true;
            this.btnSstart.Click += new System.EventHandler(this.BtnSstartClick);
            // 
            // btntakePict
            // 
            this.btntakePict.Location = new System.Drawing.Point(241, 37);
            this.btntakePict.Name = "btntakePict";
            this.btntakePict.Size = new System.Drawing.Size(80, 35);
            this.btntakePict.TabIndex = 3;
            this.btntakePict.Text = "Take Picture";
            this.btntakePict.UseVisualStyleBackColor = true;
            this.btntakePict.Click += new System.EventHandler(this.BtntakePictClick);
            // 
            // btnReserved1
            // 
            this.btnReserved1.Location = new System.Drawing.Point(327, 37);
            this.btnReserved1.Name = "btnReserved1";
            this.btnReserved1.Size = new System.Drawing.Size(92, 74);
            this.btnReserved1.TabIndex = 4;
            this.btnReserved1.Text = "Configure";
            this.btnReserved1.UseVisualStyleBackColor = true;
            this.btnReserved1.Click += new System.EventHandler(this.BtnReserved1Click);
            // 
            // btnStopTRX
            // 
            this.btnStopTRX.Location = new System.Drawing.Point(241, 78);
            this.btnStopTRX.Name = "btnStopTRX";
            this.btnStopTRX.Size = new System.Drawing.Size(80, 35);
            this.btnStopTRX.TabIndex = 5;
            this.btnStopTRX.Text = "STOP";
            this.btnStopTRX.UseVisualStyleBackColor = true;
            this.btnStopTRX.Click += new System.EventHandler(this.BtnStopTRXClick);
            // 
            // chAccelero
            // 
            chartArea1.Name = "ChartArea1";
            this.chAccelero.ChartAreas.Add(chartArea1);
            this.chAccelero.Location = new System.Drawing.Point(16, 337);
            this.chAccelero.Name = "chAccelero";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "X";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Y";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Z";
            this.chAccelero.Series.Add(series1);
            this.chAccelero.Series.Add(series2);
            this.chAccelero.Series.Add(series3);
            this.chAccelero.Size = new System.Drawing.Size(419, 174);
            this.chAccelero.TabIndex = 6;
            this.chAccelero.Text = "chart1";
            // 
            // chAltvsDist
            // 
            chartArea2.Name = "ChartArea1";
            this.chAltvsDist.ChartAreas.Add(chartArea2);
            this.chAltvsDist.Location = new System.Drawing.Point(14, 139);
            this.chAltvsDist.Name = "chAltvsDist";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "AltDist";
            this.chAltvsDist.Series.Add(series4);
            this.chAltvsDist.Size = new System.Drawing.Size(419, 179);
            this.chAltvsDist.TabIndex = 7;
            this.chAltvsDist.Text = "chart1";
            // 
            // pbPicture
            // 
            this.pbPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbPicture.Image")));
            this.pbPicture.Location = new System.Drawing.Point(677, 90);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(292, 279);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 8;
            this.pbPicture.TabStop = false;
            // 
            // gMapCtrl
            // 
            this.gMapCtrl.Bearing = 0F;
            this.gMapCtrl.CanDragMap = true;
            this.gMapCtrl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapCtrl.GrayScaleMode = false;
            this.gMapCtrl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapCtrl.LevelsKeepInMemmory = 5;
            this.gMapCtrl.Location = new System.Drawing.Point(677, 380);
            this.gMapCtrl.MarkersEnabled = true;
            this.gMapCtrl.MaxZoom = 2;
            this.gMapCtrl.MinZoom = 2;
            this.gMapCtrl.MouseWheelZoomEnabled = true;
            this.gMapCtrl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapCtrl.Name = "gMapCtrl";
            this.gMapCtrl.NegativeMode = false;
            this.gMapCtrl.PolygonsEnabled = true;
            this.gMapCtrl.RetryLoadTile = 0;
            this.gMapCtrl.RoutesEnabled = true;
            this.gMapCtrl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapCtrl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapCtrl.ShowTileGridLines = false;
            this.gMapCtrl.Size = new System.Drawing.Size(668, 323);
            this.gMapCtrl.TabIndex = 10;
            this.gMapCtrl.Zoom = 0D;
            // 
            // glAtti
            // 
            this.glAtti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.glAtti.Location = new System.Drawing.Point(445, 86);
            this.glAtti.Name = "glAtti";
            this.glAtti.Size = new System.Drawing.Size(223, 207);
            this.glAtti.TabIndex = 13;
            this.glAtti.VSync = false;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.cbBaud.Location = new System.Drawing.Point(544, 22);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 21);
            this.cbBaud.TabIndex = 14;
            this.cbBaud.Text = "Baudrate";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(452, 22);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(86, 21);
            this.cbPort.TabIndex = 15;
            this.cbPort.Text = "Port";
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.CbPortSelectedIndexChanged);
            this.cbPort.Click += new System.EventHandler(this.CbPortClick);
            // 
            // btntrxCon
            // 
            this.btntrxCon.Location = new System.Drawing.Point(514, 45);
            this.btntrxCon.Name = "btntrxCon";
            this.btntrxCon.Size = new System.Drawing.Size(88, 27);
            this.btntrxCon.TabIndex = 16;
            this.btntrxCon.Text = "Connect";
            this.btntrxCon.UseVisualStyleBackColor = true;
            this.btntrxCon.Click += new System.EventHandler(this.BtntrxConClick);
            // 
            // lblgpsTime
            // 
            this.lblgpsTime.BackColor = System.Drawing.Color.Transparent;
            this.lblgpsTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgpsTime.Location = new System.Drawing.Point(122, 532);
            this.lblgpsTime.Name = "lblgpsTime";
            this.lblgpsTime.Size = new System.Drawing.Size(104, 22);
            this.lblgpsTime.TabIndex = 18;
            this.lblgpsTime.Text = "000000";
            this.lblgpsTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFixQ
            // 
            this.lblFixQ.BackColor = System.Drawing.Color.Transparent;
            this.lblFixQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixQ.Location = new System.Drawing.Point(122, 553);
            this.lblFixQ.Name = "lblFixQ";
            this.lblFixQ.Size = new System.Drawing.Size(104, 22);
            this.lblFixQ.TabIndex = 19;
            this.lblFixQ.Text = "0 (Invalid)";
            this.lblFixQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGsat
            // 
            this.lblGsat.BackColor = System.Drawing.Color.Transparent;
            this.lblGsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGsat.Location = new System.Drawing.Point(121, 578);
            this.lblGsat.Name = "lblGsat";
            this.lblGsat.Size = new System.Drawing.Size(104, 22);
            this.lblGsat.TabIndex = 20;
            this.lblGsat.Text = "0";
            this.lblGsat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGlong
            // 
            this.lblGlong.BackColor = System.Drawing.Color.Transparent;
            this.lblGlong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlong.Location = new System.Drawing.Point(122, 603);
            this.lblGlong.Name = "lblGlong";
            this.lblGlong.Size = new System.Drawing.Size(104, 22);
            this.lblGlong.TabIndex = 21;
            this.lblGlong.Text = "0.00";
            this.lblGlong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGlat
            // 
            this.lblGlat.BackColor = System.Drawing.Color.Transparent;
            this.lblGlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlat.Location = new System.Drawing.Point(121, 627);
            this.lblGlat.Name = "lblGlat";
            this.lblGlat.Size = new System.Drawing.Size(104, 22);
            this.lblGlat.TabIndex = 22;
            this.lblGlat.Text = "0.00";
            this.lblGlat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGalt
            // 
            this.lblGalt.BackColor = System.Drawing.Color.Transparent;
            this.lblGalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalt.Location = new System.Drawing.Point(121, 652);
            this.lblGalt.Name = "lblGalt";
            this.lblGalt.Size = new System.Drawing.Size(104, 22);
            this.lblGalt.TabIndex = 23;
            this.lblGalt.Text = "0.00 M";
            this.lblGalt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGhead
            // 
            this.lblGhead.BackColor = System.Drawing.Color.Transparent;
            this.lblGhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhead.Location = new System.Drawing.Point(121, 677);
            this.lblGhead.Name = "lblGhead";
            this.lblGhead.Size = new System.Drawing.Size(104, 22);
            this.lblGhead.TabIndex = 24;
            this.lblGhead.Text = "0.00";
            this.lblGhead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGspeed
            // 
            this.lblGspeed.BackColor = System.Drawing.Color.Transparent;
            this.lblGspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGspeed.Location = new System.Drawing.Point(121, 701);
            this.lblGspeed.Name = "lblGspeed";
            this.lblGspeed.Size = new System.Drawing.Size(104, 22);
            this.lblGspeed.TabIndex = 25;
            this.lblGspeed.Text = "0.00 kmph";
            this.lblGspeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFtime
            // 
            this.lblFtime.BackColor = System.Drawing.Color.Transparent;
            this.lblFtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFtime.Location = new System.Drawing.Point(339, 554);
            this.lblFtime.Name = "lblFtime";
            this.lblFtime.Size = new System.Drawing.Size(104, 22);
            this.lblFtime.TabIndex = 26;
            this.lblFtime.Text = "0.00";
            this.lblFtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApoge
            // 
            this.lblApoge.BackColor = System.Drawing.Color.Transparent;
            this.lblApoge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApoge.Location = new System.Drawing.Point(339, 579);
            this.lblApoge.Name = "lblApoge";
            this.lblApoge.Size = new System.Drawing.Size(104, 22);
            this.lblApoge.TabIndex = 27;
            this.lblApoge.Text = "0.00 M";
            this.lblApoge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.Transparent;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(339, 652);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(104, 22);
            this.lblHead.TabIndex = 28;
            this.lblHead.Text = "0.00";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrec
            // 
            this.lblPrec.BackColor = System.Drawing.Color.Transparent;
            this.lblPrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrec.Location = new System.Drawing.Point(556, 554);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(104, 22);
            this.lblPrec.TabIndex = 29;
            this.lblPrec.Text = "430";
            this.lblPrec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPTrans
            // 
            this.lblPTrans.BackColor = System.Drawing.Color.Transparent;
            this.lblPTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTrans.Location = new System.Drawing.Point(556, 579);
            this.lblPTrans.Name = "lblPTrans";
            this.lblPTrans.Size = new System.Drawing.Size(104, 22);
            this.lblPTrans.TabIndex = 30;
            this.lblPTrans.Text = "10";
            this.lblPTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPSpeed
            // 
            this.lblPSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblPSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSpeed.Location = new System.Drawing.Point(556, 603);
            this.lblPSpeed.Name = "lblPSpeed";
            this.lblPSpeed.Size = new System.Drawing.Size(104, 22);
            this.lblPSpeed.TabIndex = 31;
            this.lblPSpeed.Text = "26 Hz";
            this.lblPSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPerr
            // 
            this.lblPerr.BackColor = System.Drawing.Color.Transparent;
            this.lblPerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerr.Location = new System.Drawing.Point(556, 628);
            this.lblPerr.Name = "lblPerr";
            this.lblPerr.Size = new System.Drawing.Size(104, 22);
            this.lblPerr.TabIndex = 32;
            this.lblPerr.Text = "4";
            this.lblPerr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDist
            // 
            this.lblDist.BackColor = System.Drawing.Color.Transparent;
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDist.Location = new System.Drawing.Point(339, 676);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(104, 22);
            this.lblDist.TabIndex = 33;
            this.lblDist.Text = "0.00 M";
            this.lblDist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIMGPros
            // 
            this.lblIMGPros.Location = new System.Drawing.Point(680, 50);
            this.lblIMGPros.Name = "lblIMGPros";
            this.lblIMGPros.Size = new System.Drawing.Size(289, 39);
            this.lblIMGPros.TabIndex = 37;
            this.lblIMGPros.Text = "StandBy";
            this.lblIMGPros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocStat
            // 
            this.lblLocStat.BackColor = System.Drawing.Color.Red;
            this.lblLocStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocStat.Location = new System.Drawing.Point(678, 379);
            this.lblLocStat.Name = "lblLocStat";
            this.lblLocStat.Size = new System.Drawing.Size(158, 23);
            this.lblLocStat.TabIndex = 38;
            this.lblLocStat.Text = "Location Not Available!";
            this.lblLocStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblgcsLong
            // 
            this.lblgcsLong.BackColor = System.Drawing.Color.Transparent;
            this.lblgcsLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgcsLong.Location = new System.Drawing.Point(339, 605);
            this.lblgcsLong.Name = "lblgcsLong";
            this.lblgcsLong.Size = new System.Drawing.Size(104, 22);
            this.lblgcsLong.TabIndex = 39;
            this.lblgcsLong.Text = "0.00";
            this.lblgcsLong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblgcsLati
            // 
            this.lblgcsLati.BackColor = System.Drawing.Color.Transparent;
            this.lblgcsLati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgcsLati.Location = new System.Drawing.Point(339, 628);
            this.lblgcsLati.Name = "lblgcsLati";
            this.lblgcsLati.Size = new System.Drawing.Size(104, 22);
            this.lblgcsLati.TabIndex = 40;
            this.lblgcsLati.Text = "0.00";
            this.lblgcsLati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBatt
            // 
            this.lblBatt.BackColor = System.Drawing.Color.Transparent;
            this.lblBatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatt.Location = new System.Drawing.Point(339, 702);
            this.lblBatt.Name = "lblBatt";
            this.lblBatt.Size = new System.Drawing.Size(104, 22);
            this.lblBatt.TabIndex = 41;
            this.lblBatt.Text = "OFF";
            this.lblBatt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRAW
            // 
            this.lblRAW.BackColor = System.Drawing.Color.Transparent;
            this.lblRAW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAW.Location = new System.Drawing.Point(729, 17);
            this.lblRAW.Name = "lblRAW";
            this.lblRAW.Size = new System.Drawing.Size(501, 23);
            this.lblRAW.TabIndex = 42;
            this.lblRAW.Text = "RAW";
            // 
            // lblgpsCounter
            // 
            this.lblgpsCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblgpsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgpsCounter.Location = new System.Drawing.Point(556, 700);
            this.lblgpsCounter.Name = "lblgpsCounter";
            this.lblgpsCounter.Size = new System.Drawing.Size(104, 22);
            this.lblgpsCounter.TabIndex = 43;
            this.lblgpsCounter.Text = "4";
            this.lblgpsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tcOdo
            // 
            // 
            // 
            // 
            this.tcOdo.Aspect.Chart3DPercent = 100;
            this.tcOdo.Aspect.ColorPaletteIndex = 20;
            this.tcOdo.Aspect.Orthogonal = false;
            this.tcOdo.Aspect.Perspective = 41;
            this.tcOdo.Aspect.Rotation = 330;
            this.tcOdo.Aspect.RotationFloat = 330D;
            this.tcOdo.Aspect.Zoom = 72;
            this.tcOdo.Aspect.ZoomFloat = 72D;
            // 
            // 
            // 
            this.tcOdo.Axes.Automatic = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Axes.Bottom.Grid.DrawEvery = 2;
            this.tcOdo.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tcOdo.Axes.Bottom.Labels.Font.Size = 9;
            this.tcOdo.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tcOdo.Axes.Bottom.Title.Caption = "X (meter)";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcOdo.Axes.Bottom.Title.Font.Size = 11;
            this.tcOdo.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.tcOdo.Axes.Bottom.Title.Lines = new string[] {
        "X (meter)"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Axes.Depth.Title.Caption = "Y (meter)";
            this.tcOdo.Axes.Depth.Title.Lines = new string[] {
        "Y (meter)"};
            this.tcOdo.Axes.Depth.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Axes.Left.Grid.DrawEvery = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
            this.tcOdo.Axes.Left.Labels.Font.Size = 9;
            this.tcOdo.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tcOdo.Axes.Left.Title.Caption = "Z (meter)";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.tcOdo.Axes.Left.Title.Font.Shadow.Height = 0;
            this.tcOdo.Axes.Left.Title.Font.Shadow.Width = 0;
            this.tcOdo.Axes.Left.Title.Font.Size = 11;
            this.tcOdo.Axes.Left.Title.Font.SizeFloat = 11F;
            this.tcOdo.Axes.Left.Title.Lines = new string[] {
        "Z (meter)"};
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcOdo.Axes.Right.Labels.Font.Size = 9;
            this.tcOdo.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcOdo.Axes.Top.Labels.Font.Size = 9;
            this.tcOdo.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.tcOdo.CurrentTheme = Steema.TeeChart.ThemeType.Report;
            this.tcOdo.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Header.Font.Brush.Color = System.Drawing.Color.Gray;
            this.tcOdo.Header.Font.Size = 12;
            this.tcOdo.Header.Font.SizeFloat = 12F;
            this.tcOdo.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcOdo.Legend.Font.Size = 9;
            this.tcOdo.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tcOdo.Legend.Shadow.Visible = false;
            this.tcOdo.Legend.Transparent = true;
            this.tcOdo.Legend.Visible = false;
            this.tcOdo.Location = new System.Drawing.Point(979, 49);
            this.tcOdo.Name = "tcOdo";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tcOdo.Panel.Brush.Gradient.Visible = false;
            this.tcOdo.Series.Add(this.odoPoint);
            this.tcOdo.Size = new System.Drawing.Size(367, 320);
            this.tcOdo.TabIndex = 44;
            this.tcOdo.Tools.Add(this.rotate1);
            this.tcOdo.Tools.Add(this.gridBand1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.tcOdo.Walls.Back.Brush.Gradient.Visible = false;
            this.tcOdo.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            this.tcOdo.Walls.Back.Pen.Visible = false;
            this.tcOdo.Walls.Back.Transparent = true;
            this.tcOdo.Walls.Back.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.tcOdo.Walls.Bottom.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tcOdo.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tcOdo.Walls.Left.Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.tcOdo.Walls.Left.Pen.Visible = false;
            // 
            // odoPoint
            // 
            this.odoPoint.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.odoPoint.ColorEach = false;
            // 
            // 
            // 
            this.odoPoint.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.odoPoint.LinePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.odoPoint.LinePen.Width = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.odoPoint.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.odoPoint.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.odoPoint.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.odoPoint.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.odoPoint.Marks.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.odoPoint.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            // 
            // 
            // 
            this.odoPoint.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            // 
            // 
            // 
            this.odoPoint.Marks.Shadow.Visible = false;
            // 
            // 
            // 
            this.odoPoint.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.odoPoint.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.odoPoint.Marks.TailParams.Margin = 0F;
            this.odoPoint.Marks.TailParams.PointerHeight = 5D;
            this.odoPoint.Marks.TailParams.PointerWidth = 8D;
            this.odoPoint.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
            this.odoPoint.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            this.odoPoint.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            this.odoPoint.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            this.odoPoint.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            this.odoPoint.Pointer.SizeDouble = 0D;
            this.odoPoint.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.odoPoint.Pointer.Visible = false;
            this.odoPoint.SeriesData = "PFRlZURhdGFTZXQ+DQogIDxUZWVEYXRhVGFibGU+DQogICAgPFg+MDwvWD4NCiAgICA8WT4wPC9ZPg0KI" +
    "CAgIDxaPjA8L1o+DQogIDwvVGVlRGF0YVRhYmxlPg0KPC9UZWVEYXRhU2V0Pg==";
            this.odoPoint.Title = "odoPoint";
            this.odoPoint.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.odoPoint.XValues.DataMember = "X";
            // 
            // 
            // 
            this.odoPoint.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.odoPoint.ZValues.DataMember = "Z";
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tcOdo.Axes.Left;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // synTime
            // 
            this.synTime.Interval = 10;
            this.synTime.Tick += new System.EventHandler(this.SynTimeTick);
            // 
            // tCtime
            // 
            this.tCtime.Enabled = true;
            this.tCtime.Interval = 1000;
            this.tCtime.Tick += new System.EventHandler(this.TCtimeTick);
            // 
            // agSpeed
            // 
            this.agSpeed.BackColor = System.Drawing.Color.White;
            this.agSpeed.BaseArcColor = System.Drawing.Color.Gray;
            this.agSpeed.BaseArcRadius = 80;
            this.agSpeed.BaseArcStart = 165;
            this.agSpeed.BaseArcSweep = 240;
            this.agSpeed.BaseArcWidth = 2;
            this.agSpeed.Center = new System.Drawing.Point(110, 110);
            aGaugeLabel1.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel1.Name = "agVal";
            aGaugeLabel1.Position = new System.Drawing.Point(103, 130);
            aGaugeLabel1.Text = "99";
            aGaugeLabel2.Color = System.Drawing.Color.DimGray;
            aGaugeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel2.Name = "GaugeLabel2";
            aGaugeLabel2.Position = new System.Drawing.Point(98, 145);
            aGaugeLabel2.Text = "Meter";
            this.agSpeed.GaugeLabels.Add(aGaugeLabel1);
            this.agSpeed.GaugeLabels.Add(aGaugeLabel2);
            aGaugeRange1.Color = System.Drawing.Color.GreenYellow;
            aGaugeRange1.EndValue = 400F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "GaugeRange1";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 0F;
            aGaugeRange2.Color = System.Drawing.Color.Orange;
            aGaugeRange2.EndValue = 700F;
            aGaugeRange2.InnerRadius = 70;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "GaugeRange2";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 400F;
            aGaugeRange3.Color = System.Drawing.Color.Red;
            aGaugeRange3.EndValue = 900F;
            aGaugeRange3.InnerRadius = 70;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "GaugeRange3";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 700F;
            this.agSpeed.GaugeRanges.Add(aGaugeRange1);
            this.agSpeed.GaugeRanges.Add(aGaugeRange2);
            this.agSpeed.GaugeRanges.Add(aGaugeRange3);
            this.agSpeed.Location = new System.Drawing.Point(445, 310);
            this.agSpeed.MaxValue = 900F;
            this.agSpeed.MinValue = 0F;
            this.agSpeed.Name = "agSpeed";
            this.agSpeed.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.agSpeed.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.agSpeed.NeedleRadius = 80;
            this.agSpeed.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.agSpeed.NeedleWidth = 3;
            this.agSpeed.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.agSpeed.ScaleLinesInterInnerRadius = 67;
            this.agSpeed.ScaleLinesInterOuterRadius = 80;
            this.agSpeed.ScaleLinesInterWidth = 1;
            this.agSpeed.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.agSpeed.ScaleLinesMajorInnerRadius = 67;
            this.agSpeed.ScaleLinesMajorOuterRadius = 80;
            this.agSpeed.ScaleLinesMajorStepValue = 100F;
            this.agSpeed.ScaleLinesMajorWidth = 2;
            this.agSpeed.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.agSpeed.ScaleLinesMinorInnerRadius = 75;
            this.agSpeed.ScaleLinesMinorOuterRadius = 80;
            this.agSpeed.ScaleLinesMinorTicks = 9;
            this.agSpeed.ScaleLinesMinorWidth = 1;
            this.agSpeed.ScaleNumbersColor = System.Drawing.Color.Black;
            this.agSpeed.ScaleNumbersFormat = null;
            this.agSpeed.ScaleNumbersRadius = 95;
            this.agSpeed.ScaleNumbersRotation = 0;
            this.agSpeed.ScaleNumbersStartScaleLine = 0;
            this.agSpeed.ScaleNumbersStepScaleLines = 1;
            this.agSpeed.Size = new System.Drawing.Size(223, 201);
            this.agSpeed.TabIndex = 45;
            this.agSpeed.Text = "aGauge1";
            this.agSpeed.Value = 0F;
            // 
            // lbltakePict
            // 
            this.lbltakePict.BackColor = System.Drawing.Color.Transparent;
            this.lbltakePict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltakePict.Location = new System.Drawing.Point(556, 652);
            this.lbltakePict.Name = "lbltakePict";
            this.lbltakePict.Size = new System.Drawing.Size(104, 22);
            this.lbltakePict.TabIndex = 46;
            this.lbltakePict.Text = "4";
            this.lbltakePict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblpictErr
            // 
            this.lblpictErr.BackColor = System.Drawing.Color.Transparent;
            this.lblpictErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpictErr.Location = new System.Drawing.Point(556, 677);
            this.lblpictErr.Name = "lblpictErr";
            this.lblpictErr.Size = new System.Drawing.Size(104, 22);
            this.lblpictErr.TabIndex = 47;
            this.lblpictErr.Text = "4";
            this.lblpictErr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.lblpictErr);
            this.Controls.Add(this.lbltakePict);
            this.Controls.Add(this.agSpeed);
            this.Controls.Add(this.tcOdo);
            this.Controls.Add(this.lblgpsCounter);
            this.Controls.Add(this.lblRAW);
            this.Controls.Add(this.lblBatt);
            this.Controls.Add(this.lblgcsLati);
            this.Controls.Add(this.lblgcsLong);
            this.Controls.Add(this.lblLocStat);
            this.Controls.Add(this.lblIMGPros);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.lblPerr);
            this.Controls.Add(this.lblPSpeed);
            this.Controls.Add(this.lblPTrans);
            this.Controls.Add(this.lblPrec);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblApoge);
            this.Controls.Add(this.lblFtime);
            this.Controls.Add(this.lblGspeed);
            this.Controls.Add(this.lblGhead);
            this.Controls.Add(this.lblGalt);
            this.Controls.Add(this.lblGlat);
            this.Controls.Add(this.lblGlong);
            this.Controls.Add(this.lblGsat);
            this.Controls.Add(this.lblFixQ);
            this.Controls.Add(this.lblgpsTime);
            this.Controls.Add(this.btntrxCon);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.cbBaud);
            this.Controls.Add(this.glAtti);
            this.Controls.Add(this.gMapCtrl);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.chAltvsDist);
            this.Controls.Add(this.chAccelero);
            this.Controls.Add(this.btnStopTRX);
            this.Controls.Add(this.btnReserved1);
            this.Controls.Add(this.btntakePict);
            this.Controls.Add(this.btnSstart);
            this.Controls.Add(this.lblDatetime);
            this.Controls.Add(this.btnFstart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IRSKY64 v0.6.0 - POLITEKNIK NEGERI JEMBER";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.chAccelero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chAltvsDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.AGauge agSpeed;
        private System.Windows.Forms.Label lbltakePict;
        private System.Windows.Forms.Label lblpictErr;
    }
}
