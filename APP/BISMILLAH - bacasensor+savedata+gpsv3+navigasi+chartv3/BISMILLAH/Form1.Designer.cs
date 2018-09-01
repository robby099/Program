namespace BISMILLAH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelJudul = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.radioButtonStatus = new System.Windows.Forms.RadioButton();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonStartRecord = new System.Windows.Forms.Button();
            this.buttonTestLoadMap = new System.Windows.Forms.Button();
            this.labelValTemperature = new System.Windows.Forms.Label();
            this.groupBoxTemperature = new System.Windows.Forms.GroupBox();
            this.groupBoxTBS = new System.Windows.Forms.GroupBox();
            this.labelvalWaterTurbidity = new System.Windows.Forms.Label();
            this.groupBoxPH = new System.Windows.Forms.GroupBox();
            this.labelValPH = new System.Windows.Forms.Label();
            this.groupBoxDOS = new System.Windows.Forms.GroupBox();
            this.labelValDO = new System.Windows.Forms.Label();
            this.groupBoxGPS = new System.Windows.Forms.GroupBox();
            this.buttonClib = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxdatetime = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBoxLongitude = new System.Windows.Forms.GroupBox();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.groupBoxLattitude = new System.Windows.Forms.GroupBox();
            this.labelLattitude = new System.Windows.Forms.Label();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerNavigasi = new System.Windows.Forms.Timer(this.components);
            this.groupBoxChart = new System.Windows.Forms.GroupBox();
            this.chartDO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTemperature.SuspendLayout();
            this.groupBoxTBS.SuspendLayout();
            this.groupBoxPH.SuspendLayout();
            this.groupBoxDOS.SuspendLayout();
            this.groupBoxGPS.SuspendLayout();
            this.groupBoxdatetime.SuspendLayout();
            this.groupBoxLongitude.SuspendLayout();
            this.groupBoxLattitude.SuspendLayout();
            this.groupBoxMap.SuspendLayout();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.Transparent;
            this.labelJudul.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(222, 9);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(907, 40);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "AUTONOMOUS SURFACE VECHILES MONITORING SYSTEM";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelJudul.Click += new System.EventHandler(this.Form1_Load);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(201, 24);
            this.comboBoxPort.TabIndex = 2;
            this.comboBoxPort.Text = "COMPORT";
            this.comboBoxPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxPort_MouseClick);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(6, 46);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(201, 24);
            this.comboBoxBaudRate.TabIndex = 3;
            this.comboBoxBaudRate.Text = "BAUD RATE";
            // 
            // radioButtonStatus
            // 
            this.radioButtonStatus.AutoSize = true;
            this.radioButtonStatus.Location = new System.Drawing.Point(6, 76);
            this.radioButtonStatus.Name = "radioButtonStatus";
            this.radioButtonStatus.Size = new System.Drawing.Size(14, 13);
            this.radioButtonStatus.TabIndex = 4;
            this.radioButtonStatus.TabStop = true;
            this.radioButtonStatus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonStatus.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(6, 104);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(201, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(6, 133);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(201, 23);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "DISCONNECT";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonStartRecord
            // 
            this.buttonStartRecord.Location = new System.Drawing.Point(6, 162);
            this.buttonStartRecord.Name = "buttonStartRecord";
            this.buttonStartRecord.Size = new System.Drawing.Size(201, 23);
            this.buttonStartRecord.TabIndex = 7;
            this.buttonStartRecord.Text = "START RECORDS";
            this.buttonStartRecord.UseVisualStyleBackColor = true;
            this.buttonStartRecord.Click += new System.EventHandler(this.buttonStartRecord_Click);
            // 
            // buttonTestLoadMap
            // 
            this.buttonTestLoadMap.Location = new System.Drawing.Point(6, 191);
            this.buttonTestLoadMap.Name = "buttonTestLoadMap";
            this.buttonTestLoadMap.Size = new System.Drawing.Size(201, 23);
            this.buttonTestLoadMap.TabIndex = 8;
            this.buttonTestLoadMap.Text = "LOAD MAP";
            this.buttonTestLoadMap.UseVisualStyleBackColor = true;
            this.buttonTestLoadMap.Click += new System.EventHandler(this.buttonTestLoadMap_Click);
            // 
            // labelValTemperature
            // 
            this.labelValTemperature.AutoSize = true;
            this.labelValTemperature.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValTemperature.Location = new System.Drawing.Point(18, 27);
            this.labelValTemperature.Name = "labelValTemperature";
            this.labelValTemperature.Size = new System.Drawing.Size(222, 90);
            this.labelValTemperature.TabIndex = 10;
            this.labelValTemperature.Text = "00.00";
            // 
            // groupBoxTemperature
            // 
            this.groupBoxTemperature.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTemperature.Controls.Add(this.labelValTemperature);
            this.groupBoxTemperature.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTemperature.Location = new System.Drawing.Point(281, 66);
            this.groupBoxTemperature.Name = "groupBoxTemperature";
            this.groupBoxTemperature.Size = new System.Drawing.Size(348, 183);
            this.groupBoxTemperature.TabIndex = 11;
            this.groupBoxTemperature.TabStop = false;
            this.groupBoxTemperature.Text = "Temperature Sensor";
            // 
            // groupBoxTBS
            // 
            this.groupBoxTBS.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTBS.Controls.Add(this.labelvalWaterTurbidity);
            this.groupBoxTBS.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTBS.Location = new System.Drawing.Point(646, 66);
            this.groupBoxTBS.Name = "groupBoxTBS";
            this.groupBoxTBS.Size = new System.Drawing.Size(350, 183);
            this.groupBoxTBS.TabIndex = 12;
            this.groupBoxTBS.TabStop = false;
            this.groupBoxTBS.Text = "Water Turbidity Sensor";
            // 
            // labelvalWaterTurbidity
            // 
            this.labelvalWaterTurbidity.AutoSize = true;
            this.labelvalWaterTurbidity.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalWaterTurbidity.Location = new System.Drawing.Point(8, 27);
            this.labelvalWaterTurbidity.Name = "labelvalWaterTurbidity";
            this.labelvalWaterTurbidity.Size = new System.Drawing.Size(222, 90);
            this.labelvalWaterTurbidity.TabIndex = 0;
            this.labelvalWaterTurbidity.Text = "00.00";
            // 
            // groupBoxPH
            // 
            this.groupBoxPH.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPH.Controls.Add(this.labelValPH);
            this.groupBoxPH.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPH.Location = new System.Drawing.Point(281, 257);
            this.groupBoxPH.Name = "groupBoxPH";
            this.groupBoxPH.Size = new System.Drawing.Size(348, 181);
            this.groupBoxPH.TabIndex = 13;
            this.groupBoxPH.TabStop = false;
            this.groupBoxPH.Text = "PH Water Sensor";
            // 
            // labelValPH
            // 
            this.labelValPH.AutoSize = true;
            this.labelValPH.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValPH.Location = new System.Drawing.Point(18, 33);
            this.labelValPH.Name = "labelValPH";
            this.labelValPH.Size = new System.Drawing.Size(222, 90);
            this.labelValPH.TabIndex = 14;
            this.labelValPH.Text = "00.00";
            // 
            // groupBoxDOS
            // 
            this.groupBoxDOS.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDOS.Controls.Add(this.labelValDO);
            this.groupBoxDOS.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDOS.Location = new System.Drawing.Point(648, 257);
            this.groupBoxDOS.Name = "groupBoxDOS";
            this.groupBoxDOS.Size = new System.Drawing.Size(348, 181);
            this.groupBoxDOS.TabIndex = 14;
            this.groupBoxDOS.TabStop = false;
            this.groupBoxDOS.Text = "Dissolved Oxygen Sensor";
            // 
            // labelValDO
            // 
            this.labelValDO.AutoSize = true;
            this.labelValDO.BackColor = System.Drawing.Color.Transparent;
            this.labelValDO.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValDO.Location = new System.Drawing.Point(6, 33);
            this.labelValDO.Name = "labelValDO";
            this.labelValDO.Size = new System.Drawing.Size(222, 90);
            this.labelValDO.TabIndex = 0;
            this.labelValDO.Text = "00.00";
            // 
            // groupBoxGPS
            // 
            this.groupBoxGPS.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGPS.Controls.Add(this.buttonClib);
            this.groupBoxGPS.Controls.Add(this.buttonOff);
            this.groupBoxGPS.Controls.Add(this.button3);
            this.groupBoxGPS.Controls.Add(this.buttonOn);
            this.groupBoxGPS.Controls.Add(this.button2);
            this.groupBoxGPS.Controls.Add(this.button1);
            this.groupBoxGPS.Controls.Add(this.groupBoxdatetime);
            this.groupBoxGPS.Controls.Add(this.groupBoxLongitude);
            this.groupBoxGPS.Controls.Add(this.groupBoxLattitude);
            this.groupBoxGPS.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGPS.Location = new System.Drawing.Point(15, 309);
            this.groupBoxGPS.Name = "groupBoxGPS";
            this.groupBoxGPS.Size = new System.Drawing.Size(249, 394);
            this.groupBoxGPS.TabIndex = 15;
            this.groupBoxGPS.TabStop = false;
            this.groupBoxGPS.Text = "GPS Module";
            // 
            // buttonClib
            // 
            this.buttonClib.Location = new System.Drawing.Point(121, 357);
            this.buttonClib.Name = "buttonClib";
            this.buttonClib.Size = new System.Drawing.Size(86, 23);
            this.buttonClib.TabIndex = 5;
            this.buttonClib.Text = "Calibration";
            this.buttonClib.UseVisualStyleBackColor = true;
            this.buttonClib.Click += new System.EventHandler(this.buttonClib_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(121, 328);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(88, 23);
            this.buttonOff.TabIndex = 1;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "ZoomOut";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(121, 299);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(88, 23);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Position";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ZoomIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxdatetime
            // 
            this.groupBoxdatetime.Controls.Add(this.labelTime);
            this.groupBoxdatetime.Controls.Add(this.labelDate);
            this.groupBoxdatetime.Location = new System.Drawing.Point(9, 209);
            this.groupBoxdatetime.Name = "groupBoxdatetime";
            this.groupBoxdatetime.Size = new System.Drawing.Size(200, 84);
            this.groupBoxdatetime.TabIndex = 1;
            this.groupBoxdatetime.TabStop = false;
            this.groupBoxdatetime.Text = "DateTime";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(6, 47);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 27);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "00:00:00";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(6, 20);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(128, 27);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "00/00/0000";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // groupBoxLongitude
            // 
            this.groupBoxLongitude.Controls.Add(this.labelLongitude);
            this.groupBoxLongitude.Location = new System.Drawing.Point(9, 119);
            this.groupBoxLongitude.Name = "groupBoxLongitude";
            this.groupBoxLongitude.Size = new System.Drawing.Size(200, 84);
            this.groupBoxLongitude.TabIndex = 1;
            this.groupBoxLongitude.TabStop = false;
            this.groupBoxLongitude.Text = "Longitude";
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLongitude.Location = new System.Drawing.Point(6, 28);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(61, 27);
            this.labelLongitude.TabIndex = 1;
            this.labelLongitude.Text = "NULL";
            // 
            // groupBoxLattitude
            // 
            this.groupBoxLattitude.Controls.Add(this.labelLattitude);
            this.groupBoxLattitude.Location = new System.Drawing.Point(9, 29);
            this.groupBoxLattitude.Name = "groupBoxLattitude";
            this.groupBoxLattitude.Size = new System.Drawing.Size(200, 84);
            this.groupBoxLattitude.TabIndex = 0;
            this.groupBoxLattitude.TabStop = false;
            this.groupBoxLattitude.Text = "Lattitude";
            // 
            // labelLattitude
            // 
            this.labelLattitude.AutoSize = true;
            this.labelLattitude.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLattitude.Location = new System.Drawing.Point(6, 23);
            this.labelLattitude.Name = "labelLattitude";
            this.labelLattitude.Size = new System.Drawing.Size(61, 27);
            this.labelLattitude.TabIndex = 0;
            this.labelLattitude.Text = "NULL";
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMap.Controls.Add(this.map);
            this.groupBoxMap.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMap.Location = new System.Drawing.Point(281, 444);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(715, 259);
            this.groupBoxMap.TabIndex = 15;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Mapping";
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(6, 23);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(703, 230);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxConfig.Controls.Add(this.label1);
            this.groupBoxConfig.Controls.Add(this.comboBoxPort);
            this.groupBoxConfig.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxConfig.Controls.Add(this.radioButtonStatus);
            this.groupBoxConfig.Controls.Add(this.buttonConnect);
            this.groupBoxConfig.Controls.Add(this.buttonDisconnect);
            this.groupBoxConfig.Controls.Add(this.buttonStartRecord);
            this.groupBoxConfig.Controls.Add(this.buttonTestLoadMap);
            this.groupBoxConfig.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConfig.Location = new System.Drawing.Point(15, 66);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(249, 231);
            this.groupBoxConfig.TabIndex = 11;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 15;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBoxChart
            // 
            this.groupBoxChart.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxChart.Controls.Add(this.chartDO);
            this.groupBoxChart.Controls.Add(this.chartPH);
            this.groupBoxChart.Controls.Add(this.chartWTS);
            this.groupBoxChart.Controls.Add(this.chartTemp);
            this.groupBoxChart.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChart.Location = new System.Drawing.Point(1002, 66);
            this.groupBoxChart.Name = "groupBoxChart";
            this.groupBoxChart.Size = new System.Drawing.Size(336, 637);
            this.groupBoxChart.TabIndex = 16;
            this.groupBoxChart.TabStop = false;
            this.groupBoxChart.Text = "Chart";
            // 
            // chartDO
            // 
            chartArea13.Name = "ChartArea1";
            this.chartDO.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chartDO.Legends.Add(legend13);
            this.chartDO.Location = new System.Drawing.Point(6, 494);
            this.chartDO.Name = "chartDO";
            this.chartDO.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series13.Legend = "Legend1";
            series13.Name = "Data DO";
            this.chartDO.Series.Add(series13);
            this.chartDO.Size = new System.Drawing.Size(324, 137);
            this.chartDO.TabIndex = 3;
            this.chartDO.Text = "chart4";
            // 
            // chartPH
            // 
            chartArea14.Name = "ChartArea1";
            this.chartPH.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartPH.Legends.Add(legend14);
            this.chartPH.Location = new System.Drawing.Point(6, 334);
            this.chartPH.Name = "chartPH";
            this.chartPH.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series14.Legend = "Legend1";
            series14.Name = "Data PH";
            this.chartPH.Series.Add(series14);
            this.chartPH.Size = new System.Drawing.Size(324, 137);
            this.chartPH.TabIndex = 2;
            this.chartPH.Text = "chart3";
            // 
            // chartWTS
            // 
            chartArea15.Name = "ChartArea1";
            this.chartWTS.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chartWTS.Legends.Add(legend15);
            this.chartWTS.Location = new System.Drawing.Point(6, 177);
            this.chartWTS.Name = "chartWTS";
            this.chartWTS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series15.Legend = "Legend1";
            series15.Name = "Data WTS";
            this.chartWTS.Series.Add(series15);
            this.chartWTS.Size = new System.Drawing.Size(324, 137);
            this.chartWTS.TabIndex = 1;
            this.chartWTS.Text = "chart2";
            // 
            // chartTemp
            // 
            chartArea16.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chartTemp.Legends.Add(legend16);
            this.chartTemp.Location = new System.Drawing.Point(6, 19);
            this.chartTemp.Name = "chartTemp";
            this.chartTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series16.Legend = "Legend1";
            series16.Name = "Data Suhu";
            this.chartTemp.Series.Add(series16);
            this.chartTemp.Size = new System.Drawing.Size(324, 137);
            this.chartTemp.TabIndex = 0;
            this.chartTemp.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.groupBoxChart);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.groupBoxMap);
            this.Controls.Add(this.groupBoxGPS);
            this.Controls.Add(this.groupBoxDOS);
            this.Controls.Add(this.groupBoxPH);
            this.Controls.Add(this.groupBoxTBS);
            this.Controls.Add(this.groupBoxTemperature);
            this.Controls.Add(this.labelJudul);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTemperature.ResumeLayout(false);
            this.groupBoxTemperature.PerformLayout();
            this.groupBoxTBS.ResumeLayout(false);
            this.groupBoxTBS.PerformLayout();
            this.groupBoxPH.ResumeLayout(false);
            this.groupBoxPH.PerformLayout();
            this.groupBoxDOS.ResumeLayout(false);
            this.groupBoxDOS.PerformLayout();
            this.groupBoxGPS.ResumeLayout(false);
            this.groupBoxdatetime.ResumeLayout(false);
            this.groupBoxdatetime.PerformLayout();
            this.groupBoxLongitude.ResumeLayout(false);
            this.groupBoxLongitude.PerformLayout();
            this.groupBoxLattitude.ResumeLayout(false);
            this.groupBoxLattitude.PerformLayout();
            this.groupBoxMap.ResumeLayout(false);
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.RadioButton radioButtonStatus;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonStartRecord;
        private System.Windows.Forms.Button buttonTestLoadMap;
        private System.Windows.Forms.Label labelValTemperature;
        private System.Windows.Forms.GroupBox groupBoxTemperature;
        private System.Windows.Forms.GroupBox groupBoxTBS;
        private System.Windows.Forms.Label labelvalWaterTurbidity;
        private System.Windows.Forms.GroupBox groupBoxPH;
        private System.Windows.Forms.Label labelValPH;
        private System.Windows.Forms.GroupBox groupBoxDOS;
        private System.Windows.Forms.Label labelValDO;
        private System.Windows.Forms.GroupBox groupBoxGPS;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxdatetime;
        private System.Windows.Forms.GroupBox groupBoxLongitude;
        private System.Windows.Forms.GroupBox groupBoxLattitude;
        private System.Windows.Forms.Label labelLattitude;
        private System.Windows.Forms.Label labelLongitude;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerNavigasi;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonClib;
        private System.Windows.Forms.GroupBox groupBoxChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWTS;

    }
}

