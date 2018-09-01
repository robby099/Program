namespace Monitor_Suhu
{
    partial class Form_utama
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
            this.grpBox_kontrol_monitor = new System.Windows.Forms.GroupBox();
            this.zedGraphSuhu = new ZedGraph.ZedGraphControl();
            this.grpBox_kontrol = new System.Windows.Forms.GroupBox();
            this.btn_kontrol_stop = new System.Windows.Forms.Button();
            this.btn_kontrol_start = new System.Windows.Forms.Button();
            this.Detak = new System.Windows.Forms.Timer(this.components);
            this.grpBox_kontrol_monitor.SuspendLayout();
            this.grpBox_kontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_kontrol_monitor
            // 
            this.grpBox_kontrol_monitor.AutoSize = true;
            this.grpBox_kontrol_monitor.Controls.Add(this.zedGraphSuhu);
            this.grpBox_kontrol_monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox_kontrol_monitor.Location = new System.Drawing.Point(0, 0);
            this.grpBox_kontrol_monitor.Name = "grpBox_kontrol_monitor";
            this.grpBox_kontrol_monitor.Size = new System.Drawing.Size(614, 378);
            this.grpBox_kontrol_monitor.TabIndex = 0;
            this.grpBox_kontrol_monitor.TabStop = false;
            this.grpBox_kontrol_monitor.Text = "Monitor";
            // 
            // zedGraphSuhu
            // 
            this.zedGraphSuhu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphSuhu.Location = new System.Drawing.Point(3, 16);
            this.zedGraphSuhu.Name = "zedGraphSuhu";
            this.zedGraphSuhu.ScrollGrace = 0;
            this.zedGraphSuhu.ScrollMaxX = 0;
            this.zedGraphSuhu.ScrollMaxY = 0;
            this.zedGraphSuhu.ScrollMaxY2 = 0;
            this.zedGraphSuhu.ScrollMinX = 0;
            this.zedGraphSuhu.ScrollMinY = 0;
            this.zedGraphSuhu.ScrollMinY2 = 0;
            this.zedGraphSuhu.Size = new System.Drawing.Size(608, 359);
            this.zedGraphSuhu.TabIndex = 0;
            // 
            // grpBox_kontrol
            // 
            this.grpBox_kontrol.AutoSize = true;
            this.grpBox_kontrol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBox_kontrol.Controls.Add(this.btn_kontrol_stop);
            this.grpBox_kontrol.Controls.Add(this.btn_kontrol_start);
            this.grpBox_kontrol.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpBox_kontrol.Location = new System.Drawing.Point(614, 0);
            this.grpBox_kontrol.Name = "grpBox_kontrol";
            this.grpBox_kontrol.Size = new System.Drawing.Size(88, 378);
            this.grpBox_kontrol.TabIndex = 1;
            this.grpBox_kontrol.TabStop = false;
            this.grpBox_kontrol.Text = "Kontrol";
            // 
            // btn_kontrol_stop
            // 
            this.btn_kontrol_stop.Location = new System.Drawing.Point(6, 69);
            this.btn_kontrol_stop.Name = "btn_kontrol_stop";
            this.btn_kontrol_stop.Size = new System.Drawing.Size(76, 44);
            this.btn_kontrol_stop.TabIndex = 2;
            this.btn_kontrol_stop.Text = "Stop";
            this.btn_kontrol_stop.UseVisualStyleBackColor = true;
            this.btn_kontrol_stop.Click += new System.EventHandler(this.btn_kontrol_stop_Click);
            // 
            // btn_kontrol_start
            // 
            this.btn_kontrol_start.Location = new System.Drawing.Point(6, 19);
            this.btn_kontrol_start.Name = "btn_kontrol_start";
            this.btn_kontrol_start.Size = new System.Drawing.Size(76, 44);
            this.btn_kontrol_start.TabIndex = 1;
            this.btn_kontrol_start.Text = "Start";
            this.btn_kontrol_start.UseVisualStyleBackColor = true;
            this.btn_kontrol_start.Click += new System.EventHandler(this.btn_kontrol_start_Click);
            // 
            // Detak
            // 
            this.Detak.Interval = 500;
            this.Detak.Tick += new System.EventHandler(this.Detak_Tick);
            // 
            // Form_utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 378);
            this.Controls.Add(this.grpBox_kontrol_monitor);
            this.Controls.Add(this.grpBox_kontrol);
            this.Name = "Form_utama";
            this.Text = "Monitor Suhu";
            this.Load += new System.EventHandler(this.Form_utama_Load);
            this.grpBox_kontrol_monitor.ResumeLayout(false);
            this.grpBox_kontrol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_kontrol_monitor;
        private System.Windows.Forms.GroupBox grpBox_kontrol;
        private System.Windows.Forms.Button btn_kontrol_start;
        private System.Windows.Forms.Timer Detak;
        private System.Windows.Forms.Button btn_kontrol_stop;
        private ZedGraph.ZedGraphControl zedGraphSuhu;
    }
}

