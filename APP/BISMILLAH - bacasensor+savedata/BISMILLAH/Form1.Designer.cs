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
            this.labelJudul = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.radioButtonStatus = new System.Windows.Forms.RadioButton();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonStartRecord = new System.Windows.Forms.Button();
            this.buttonTestLedOff = new System.Windows.Forms.Button();
            this.labelValTemperature = new System.Windows.Forms.Label();
            this.groupBoxTemperature = new System.Windows.Forms.GroupBox();
            this.groupBoxTBS = new System.Windows.Forms.GroupBox();
            this.labelvalWaterTurbidity = new System.Windows.Forms.Label();
            this.groupBoxPH = new System.Windows.Forms.GroupBox();
            this.labelValPH = new System.Windows.Forms.Label();
            this.groupBoxDOS = new System.Windows.Forms.GroupBox();
            this.labelValDO = new System.Windows.Forms.Label();
            this.groupBoxGPS = new System.Windows.Forms.GroupBox();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxLattitude = new System.Windows.Forms.GroupBox();
            this.groupBoxLongitude = new System.Windows.Forms.GroupBox();
            this.groupBoxdatetime = new System.Windows.Forms.GroupBox();
            this.groupBoxTemperature.SuspendLayout();
            this.groupBoxTBS.SuspendLayout();
            this.groupBoxPH.SuspendLayout();
            this.groupBoxDOS.SuspendLayout();
            this.groupBoxGPS.SuspendLayout();
            this.groupBoxConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(315, 9);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(437, 40);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "ASV MONITORING SYSTEM";
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
            // buttonTestLedOff
            // 
            this.buttonTestLedOff.Location = new System.Drawing.Point(6, 191);
            this.buttonTestLedOff.Name = "buttonTestLedOff";
            this.buttonTestLedOff.Size = new System.Drawing.Size(201, 23);
            this.buttonTestLedOff.TabIndex = 8;
            this.buttonTestLedOff.Text = "Test Off";
            this.buttonTestLedOff.UseVisualStyleBackColor = true;
            this.buttonTestLedOff.Click += new System.EventHandler(this.buttonTestLedOff_Click);
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
            this.labelValDO.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValDO.Location = new System.Drawing.Point(6, 33);
            this.labelValDO.Name = "labelValDO";
            this.labelValDO.Size = new System.Drawing.Size(222, 90);
            this.labelValDO.TabIndex = 0;
            this.labelValDO.Text = "00.00";
            // 
            // groupBoxGPS
            // 
            this.groupBoxGPS.Controls.Add(this.groupBoxdatetime);
            this.groupBoxGPS.Controls.Add(this.groupBoxLongitude);
            this.groupBoxGPS.Controls.Add(this.groupBoxLattitude);
            this.groupBoxGPS.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGPS.Location = new System.Drawing.Point(15, 309);
            this.groupBoxGPS.Name = "groupBoxGPS";
            this.groupBoxGPS.Size = new System.Drawing.Size(249, 339);
            this.groupBoxGPS.TabIndex = 15;
            this.groupBoxGPS.TabStop = false;
            this.groupBoxGPS.Text = "GPS Module";
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMap.Location = new System.Drawing.Point(281, 456);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(715, 192);
            this.groupBoxMap.TabIndex = 15;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Mapping";
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.label1);
            this.groupBoxConfig.Controls.Add(this.comboBoxPort);
            this.groupBoxConfig.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxConfig.Controls.Add(this.radioButtonStatus);
            this.groupBoxConfig.Controls.Add(this.buttonConnect);
            this.groupBoxConfig.Controls.Add(this.buttonDisconnect);
            this.groupBoxConfig.Controls.Add(this.buttonStartRecord);
            this.groupBoxConfig.Controls.Add(this.buttonTestLedOff);
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
            // groupBoxLattitude
            // 
            this.groupBoxLattitude.Location = new System.Drawing.Point(9, 29);
            this.groupBoxLattitude.Name = "groupBoxLattitude";
            this.groupBoxLattitude.Size = new System.Drawing.Size(200, 84);
            this.groupBoxLattitude.TabIndex = 0;
            this.groupBoxLattitude.TabStop = false;
            this.groupBoxLattitude.Text = "Lattitude";
            // 
            // groupBoxLongitude
            // 
            this.groupBoxLongitude.Location = new System.Drawing.Point(9, 119);
            this.groupBoxLongitude.Name = "groupBoxLongitude";
            this.groupBoxLongitude.Size = new System.Drawing.Size(200, 84);
            this.groupBoxLongitude.TabIndex = 1;
            this.groupBoxLongitude.TabStop = false;
            this.groupBoxLongitude.Text = "Longitude";
            // 
            // groupBoxdatetime
            // 
            this.groupBoxdatetime.Location = new System.Drawing.Point(9, 209);
            this.groupBoxdatetime.Name = "groupBoxdatetime";
            this.groupBoxdatetime.Size = new System.Drawing.Size(200, 84);
            this.groupBoxdatetime.TabIndex = 1;
            this.groupBoxdatetime.TabStop = false;
            this.groupBoxdatetime.Text = "DateTime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 663);
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
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
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
        private System.Windows.Forms.Button buttonTestLedOff;
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

    }
}

