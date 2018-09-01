/*
 * Created by SharpDevelop.
 * User: Abdurrahman
 * Date: 01/08/2017
 * Time: 10.51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace IRSKY_NEW
{
	partial class Config
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnByGPS;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAppl;
		public System.Windows.Forms.TextBox tbLNG;
		public System.Windows.Forms.TextBox tbLAT;
		public System.Windows.Forms.RadioButton rbPyramid;
		public System.Windows.Forms.RadioButton rbRocket;
		public System.Windows.Forms.RadioButton rbSparkfun;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.RadioButton rbMap;
		public System.Windows.Forms.RadioButton rbRea;
		public System.Windows.Forms.RadioButton rbSat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		public System.Windows.Forms.CheckBox cbAltvDist;
		public System.Windows.Forms.CheckBox cbCMPS;
		public System.Windows.Forms.CheckBox cb3DM;
		public System.Windows.Forms.CheckBox cbOdo;
		public System.Windows.Forms.CheckBox cbMap;
		public System.Windows.Forms.CheckBox cbAccChart;
		public System.Windows.Forms.CheckBox cbSaveRC;
		public System.Windows.Forms.CheckBox cbUTD;
		
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
			this.btnByGPS = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAppl = new System.Windows.Forms.Button();
			this.tbLNG = new System.Windows.Forms.TextBox();
			this.tbLAT = new System.Windows.Forms.TextBox();
			this.rbPyramid = new System.Windows.Forms.RadioButton();
			this.rbRocket = new System.Windows.Forms.RadioButton();
			this.rbSparkfun = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbMap = new System.Windows.Forms.RadioButton();
			this.rbRea = new System.Windows.Forms.RadioButton();
			this.rbSat = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbSaveRC = new System.Windows.Forms.CheckBox();
			this.cbOdo = new System.Windows.Forms.CheckBox();
			this.cbMap = new System.Windows.Forms.CheckBox();
			this.cbAccChart = new System.Windows.Forms.CheckBox();
			this.cbAltvDist = new System.Windows.Forms.CheckBox();
			this.cbCMPS = new System.Windows.Forms.CheckBox();
			this.cb3DM = new System.Windows.Forms.CheckBox();
			this.cbUTD = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnByGPS
			// 
			this.btnByGPS.Location = new System.Drawing.Point(169, 12);
			this.btnByGPS.Name = "btnByGPS";
			this.btnByGPS.Size = new System.Drawing.Size(70, 48);
			this.btnByGPS.TabIndex = 0;
			this.btnByGPS.Text = "By GPS";
			this.btnByGPS.UseVisualStyleBackColor = true;
			this.btnByGPS.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(226, 221);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(61, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(293, 221);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(61, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnAppl
			// 
			this.btnAppl.Location = new System.Drawing.Point(360, 221);
			this.btnAppl.Name = "btnAppl";
			this.btnAppl.Size = new System.Drawing.Size(61, 23);
			this.btnAppl.TabIndex = 3;
			this.btnAppl.Text = "Apply";
			this.btnAppl.UseVisualStyleBackColor = true;
			this.btnAppl.Click += new System.EventHandler(this.BtnApplClick);
			// 
			// tbLNG
			// 
			this.tbLNG.Location = new System.Drawing.Point(70, 14);
			this.tbLNG.Name = "tbLNG";
			this.tbLNG.Size = new System.Drawing.Size(93, 20);
			this.tbLNG.TabIndex = 4;
			this.tbLNG.Text = "113.233444";
			// 
			// tbLAT
			// 
			this.tbLAT.Location = new System.Drawing.Point(70, 40);
			this.tbLAT.Name = "tbLAT";
			this.tbLAT.Size = new System.Drawing.Size(93, 20);
			this.tbLAT.TabIndex = 5;
			// 
			// rbPyramid
			// 
			this.rbPyramid.Location = new System.Drawing.Point(20, 14);
			this.rbPyramid.Name = "rbPyramid";
			this.rbPyramid.Size = new System.Drawing.Size(76, 24);
			this.rbPyramid.TabIndex = 7;
			this.rbPyramid.TabStop = true;
			this.rbPyramid.Text = "Pyramid";
			this.rbPyramid.UseVisualStyleBackColor = true;
			this.rbPyramid.CheckedChanged += new System.EventHandler(this.RbPyramidCheckedChanged);
			// 
			// rbRocket
			// 
			this.rbRocket.Location = new System.Drawing.Point(20, 44);
			this.rbRocket.Name = "rbRocket";
			this.rbRocket.Size = new System.Drawing.Size(76, 24);
			this.rbRocket.TabIndex = 8;
			this.rbRocket.TabStop = true;
			this.rbRocket.Text = "Tri Cahyo";
			this.rbRocket.UseVisualStyleBackColor = true;
			this.rbRocket.CheckedChanged += new System.EventHandler(this.RbRocketCheckedChanged);
			// 
			// rbSparkfun
			// 
			this.rbSparkfun.Location = new System.Drawing.Point(20, 74);
			this.rbSparkfun.Name = "rbSparkfun";
			this.rbSparkfun.Size = new System.Drawing.Size(76, 24);
			this.rbSparkfun.TabIndex = 9;
			this.rbSparkfun.TabStop = true;
			this.rbSparkfun.Text = "Sparkfun";
			this.rbSparkfun.UseVisualStyleBackColor = true;
			this.rbSparkfun.CheckedChanged += new System.EventHandler(this.RbSparkfunCheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbRocket);
			this.groupBox1.Controls.Add(this.rbSparkfun);
			this.groupBox1.Controls.Add(this.rbPyramid);
			this.groupBox1.Location = new System.Drawing.Point(204, 75);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(102, 100);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "3D Model";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbMap);
			this.groupBox2.Controls.Add(this.rbRea);
			this.groupBox2.Controls.Add(this.rbSat);
			this.groupBox2.Location = new System.Drawing.Point(312, 75);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(94, 100);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Map Mode";
			// 
			// rbMap
			// 
			this.rbMap.Location = new System.Drawing.Point(13, 44);
			this.rbMap.Name = "rbMap";
			this.rbMap.Size = new System.Drawing.Size(75, 24);
			this.rbMap.TabIndex = 8;
			this.rbMap.TabStop = true;
			this.rbMap.Text = "Map";
			this.rbMap.UseVisualStyleBackColor = true;
			this.rbMap.CheckedChanged += new System.EventHandler(this.RbMapCheckedChanged);
			// 
			// rbRea
			// 
			this.rbRea.Location = new System.Drawing.Point(13, 74);
			this.rbRea.Name = "rbRea";
			this.rbRea.Size = new System.Drawing.Size(75, 24);
			this.rbRea.TabIndex = 9;
			this.rbRea.TabStop = true;
			this.rbRea.Text = "Reserved";
			this.rbRea.UseVisualStyleBackColor = true;
			// 
			// rbSat
			// 
			this.rbSat.Location = new System.Drawing.Point(13, 14);
			this.rbSat.Name = "rbSat";
			this.rbSat.Size = new System.Drawing.Size(75, 24);
			this.rbSat.TabIndex = 7;
			this.rbSat.TabStop = true;
			this.rbSat.Text = "Satellite";
			this.rbSat.UseVisualStyleBackColor = true;
			this.rbSat.CheckedChanged += new System.EventHandler(this.RbSatCheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "Longitude:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Latitude:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbSaveRC);
			this.groupBox3.Controls.Add(this.cbOdo);
			this.groupBox3.Controls.Add(this.cbMap);
			this.groupBox3.Controls.Add(this.cbAccChart);
			this.groupBox3.Controls.Add(this.cbAltvDist);
			this.groupBox3.Controls.Add(this.cbCMPS);
			this.groupBox3.Controls.Add(this.cb3DM);
			this.groupBox3.Location = new System.Drawing.Point(7, 75);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(191, 131);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Features";
			// 
			// cbSaveRC
			// 
			this.cbSaveRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSaveRC.ForeColor = System.Drawing.Color.Red;
			this.cbSaveRC.Location = new System.Drawing.Point(40, 93);
			this.cbSaveRC.Name = "cbSaveRC";
			this.cbSaveRC.Size = new System.Drawing.Size(130, 32);
			this.cbSaveRC.TabIndex = 16;
			this.cbSaveRC.Text = "Save Record";
			this.cbSaveRC.UseVisualStyleBackColor = true;
			this.cbSaveRC.CheckedChanged += new System.EventHandler(this.CbSaveRCCheckedChanged);
			// 
			// cbOdo
			// 
			this.cbOdo.Location = new System.Drawing.Point(106, 67);
			this.cbOdo.Name = "cbOdo";
			this.cbOdo.Size = new System.Drawing.Size(79, 24);
			this.cbOdo.TabIndex = 15;
			this.cbOdo.Text = "Odometri";
			this.cbOdo.UseVisualStyleBackColor = true;
			// 
			// cbMap
			// 
			this.cbMap.Location = new System.Drawing.Point(106, 44);
			this.cbMap.Name = "cbMap";
			this.cbMap.Size = new System.Drawing.Size(79, 24);
			this.cbMap.TabIndex = 15;
			this.cbMap.Text = "Map";
			this.cbMap.UseVisualStyleBackColor = true;
			// 
			// cbAccChart
			// 
			this.cbAccChart.Location = new System.Drawing.Point(106, 19);
			this.cbAccChart.Name = "cbAccChart";
			this.cbAccChart.Size = new System.Drawing.Size(79, 24);
			this.cbAccChart.TabIndex = 16;
			this.cbAccChart.Text = "Acc Chart";
			this.cbAccChart.UseVisualStyleBackColor = true;
			// 
			// cbAltvDist
			// 
			this.cbAltvDist.Location = new System.Drawing.Point(6, 67);
			this.cbAltvDist.Name = "cbAltvDist";
			this.cbAltvDist.Size = new System.Drawing.Size(73, 24);
			this.cbAltvDist.TabIndex = 15;
			this.cbAltvDist.Text = "Alt vs Dist";
			this.cbAltvDist.UseVisualStyleBackColor = true;
			// 
			// cbCMPS
			// 
			this.cbCMPS.Location = new System.Drawing.Point(6, 44);
			this.cbCMPS.Name = "cbCMPS";
			this.cbCMPS.Size = new System.Drawing.Size(73, 24);
			this.cbCMPS.TabIndex = 1;
			this.cbCMPS.Text = "Compass";
			this.cbCMPS.UseVisualStyleBackColor = true;
			// 
			// cb3DM
			// 
			this.cb3DM.Location = new System.Drawing.Point(6, 19);
			this.cb3DM.Name = "cb3DM";
			this.cb3DM.Size = new System.Drawing.Size(73, 24);
			this.cb3DM.TabIndex = 0;
			this.cb3DM.Text = "3D Model";
			this.cb3DM.UseVisualStyleBackColor = true;
			// 
			// cbUTD
			// 
			this.cbUTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUTD.ForeColor = System.Drawing.Color.Blue;
			this.cbUTD.Location = new System.Drawing.Point(302, 25);
			this.cbUTD.Name = "cbUTD";
			this.cbUTD.Size = new System.Drawing.Size(104, 24);
			this.cbUTD.TabIndex = 15;
			this.cbUTD.Text = "UTD";
			this.cbUTD.UseVisualStyleBackColor = true;
			// 
			// Config
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 256);
			this.ControlBox = false;
			this.Controls.Add(this.cbUTD);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbLAT);
			this.Controls.Add(this.tbLNG);
			this.Controls.Add(this.btnAppl);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnByGPS);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Config";
			this.Text = "GCS Configuration";
			this.Load += new System.EventHandler(this.ConfigLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
