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
            this.grpBox_kontrol = new System.Windows.Forms.GroupBox();
            this.btn_kontrol_stop = new System.Windows.Forms.Button();
            this.btn_kontrol_start = new System.Windows.Forms.Button();
            this.Detak = new System.Windows.Forms.Timer(this.components);
            this.tab_menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpBox_pencatat = new System.Windows.Forms.GroupBox();
            this.grpBox_databaseView = new System.Windows.Forms.GroupBox();
            this.dataGrid_suhu = new System.Windows.Forms.DataGridView();
            this.grpBox_kontrolPencatat = new System.Windows.Forms.GroupBox();
            this.dtPicker_hingga = new System.Windows.Forms.DateTimePicker();
            this.lbl_stop = new System.Windows.Forms.Label();
            this.lbl_dari = new System.Windows.Forms.Label();
            this.dtPicker_dari = new System.Windows.Forms.DateTimePicker();
            this.btn_lihat = new System.Windows.Forms.Button();
            this.zedGraphSuhu = new ZedGraph.ZedGraphControl();
            this.grpBox_kontrol_monitor.SuspendLayout();
            this.grpBox_kontrol.SuspendLayout();
            this.tab_menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpBox_pencatat.SuspendLayout();
            this.grpBox_databaseView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_suhu)).BeginInit();
            this.grpBox_kontrolPencatat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_kontrol_monitor
            // 
            this.grpBox_kontrol_monitor.AutoSize = true;
            this.grpBox_kontrol_monitor.Controls.Add(this.zedGraphSuhu);
            this.grpBox_kontrol_monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox_kontrol_monitor.Location = new System.Drawing.Point(3, 3);
            this.grpBox_kontrol_monitor.Name = "grpBox_kontrol_monitor";
            this.grpBox_kontrol_monitor.Size = new System.Drawing.Size(600, 346);
            this.grpBox_kontrol_monitor.TabIndex = 0;
            this.grpBox_kontrol_monitor.TabStop = false;
            this.grpBox_kontrol_monitor.Text = "Monitor";
            // 
            // grpBox_kontrol
            // 
            this.grpBox_kontrol.AutoSize = true;
            this.grpBox_kontrol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBox_kontrol.Controls.Add(this.btn_kontrol_stop);
            this.grpBox_kontrol.Controls.Add(this.btn_kontrol_start);
            this.grpBox_kontrol.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpBox_kontrol.Location = new System.Drawing.Point(603, 3);
            this.grpBox_kontrol.Name = "grpBox_kontrol";
            this.grpBox_kontrol.Size = new System.Drawing.Size(88, 346);
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
            // tab_menu
            // 
            this.tab_menu.Controls.Add(this.tabPage1);
            this.tab_menu.Controls.Add(this.tabPage2);
            this.tab_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_menu.Location = new System.Drawing.Point(0, 0);
            this.tab_menu.Name = "tab_menu";
            this.tab_menu.SelectedIndex = 0;
            this.tab_menu.Size = new System.Drawing.Size(702, 378);
            this.tab_menu.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpBox_kontrol_monitor);
            this.tabPage1.Controls.Add(this.grpBox_kontrol);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpBox_pencatat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pencatat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpBox_pencatat
            // 
            this.grpBox_pencatat.Controls.Add(this.grpBox_databaseView);
            this.grpBox_pencatat.Controls.Add(this.grpBox_kontrolPencatat);
            this.grpBox_pencatat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox_pencatat.Location = new System.Drawing.Point(3, 3);
            this.grpBox_pencatat.Name = "grpBox_pencatat";
            this.grpBox_pencatat.Size = new System.Drawing.Size(688, 346);
            this.grpBox_pencatat.TabIndex = 0;
            this.grpBox_pencatat.TabStop = false;
            this.grpBox_pencatat.Text = "Pencatat";
            // 
            // grpBox_databaseView
            // 
            this.grpBox_databaseView.Controls.Add(this.dataGrid_suhu);
            this.grpBox_databaseView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox_databaseView.Location = new System.Drawing.Point(3, 65);
            this.grpBox_databaseView.Name = "grpBox_databaseView";
            this.grpBox_databaseView.Size = new System.Drawing.Size(682, 278);
            this.grpBox_databaseView.TabIndex = 0;
            this.grpBox_databaseView.TabStop = false;
            this.grpBox_databaseView.Text = "Tercatat";
            // 
            // dataGrid_suhu
            // 
            this.dataGrid_suhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_suhu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_suhu.Location = new System.Drawing.Point(3, 16);
            this.dataGrid_suhu.Name = "dataGrid_suhu";
            this.dataGrid_suhu.Size = new System.Drawing.Size(676, 259);
            this.dataGrid_suhu.TabIndex = 1;
            // 
            // grpBox_kontrolPencatat
            // 
            this.grpBox_kontrolPencatat.Controls.Add(this.dtPicker_hingga);
            this.grpBox_kontrolPencatat.Controls.Add(this.lbl_stop);
            this.grpBox_kontrolPencatat.Controls.Add(this.lbl_dari);
            this.grpBox_kontrolPencatat.Controls.Add(this.dtPicker_dari);
            this.grpBox_kontrolPencatat.Controls.Add(this.btn_lihat);
            this.grpBox_kontrolPencatat.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBox_kontrolPencatat.Location = new System.Drawing.Point(3, 16);
            this.grpBox_kontrolPencatat.Name = "grpBox_kontrolPencatat";
            this.grpBox_kontrolPencatat.Size = new System.Drawing.Size(682, 49);
            this.grpBox_kontrolPencatat.TabIndex = 1;
            this.grpBox_kontrolPencatat.TabStop = false;
            this.grpBox_kontrolPencatat.Text = "Kontrol";
            // 
            // dtPicker_hingga
            // 
            this.dtPicker_hingga.Location = new System.Drawing.Point(315, 17);
            this.dtPicker_hingga.Name = "dtPicker_hingga";
            this.dtPicker_hingga.Size = new System.Drawing.Size(200, 20);
            this.dtPicker_hingga.TabIndex = 4;
            // 
            // lbl_stop
            // 
            this.lbl_stop.AutoSize = true;
            this.lbl_stop.Location = new System.Drawing.Point(258, 20);
            this.lbl_stop.Name = "lbl_stop";
            this.lbl_stop.Size = new System.Drawing.Size(47, 13);
            this.lbl_stop.TabIndex = 3;
            this.lbl_stop.Text = "Hingga :";
            // 
            // lbl_dari
            // 
            this.lbl_dari.AutoSize = true;
            this.lbl_dari.Location = new System.Drawing.Point(6, 21);
            this.lbl_dari.Name = "lbl_dari";
            this.lbl_dari.Size = new System.Drawing.Size(32, 13);
            this.lbl_dari.TabIndex = 2;
            this.lbl_dari.Text = "Dari :";
            // 
            // dtPicker_dari
            // 
            this.dtPicker_dari.Location = new System.Drawing.Point(46, 17);
            this.dtPicker_dari.Name = "dtPicker_dari";
            this.dtPicker_dari.Size = new System.Drawing.Size(200, 20);
            this.dtPicker_dari.TabIndex = 1;
            // 
            // btn_lihat
            // 
            this.btn_lihat.Location = new System.Drawing.Point(590, 16);
            this.btn_lihat.Name = "btn_lihat";
            this.btn_lihat.Size = new System.Drawing.Size(75, 23);
            this.btn_lihat.TabIndex = 0;
            this.btn_lihat.Text = "Lihat";
            this.btn_lihat.UseVisualStyleBackColor = true;
            this.btn_lihat.Click += new System.EventHandler(this.btn_lihat_Click);
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
            this.zedGraphSuhu.Size = new System.Drawing.Size(594, 327);
            this.zedGraphSuhu.TabIndex = 0;
            // 
            // Form_utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 378);
            this.Controls.Add(this.tab_menu);
            this.Name = "Form_utama";
            this.Text = "Monitor dan Pencatat Suhu";
            this.Load += new System.EventHandler(this.Form_utama_Load);
            this.grpBox_kontrol_monitor.ResumeLayout(false);
            this.grpBox_kontrol.ResumeLayout(false);
            this.tab_menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpBox_pencatat.ResumeLayout(false);
            this.grpBox_databaseView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_suhu)).EndInit();
            this.grpBox_kontrolPencatat.ResumeLayout(false);
            this.grpBox_kontrolPencatat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_kontrol_monitor;
        private System.Windows.Forms.GroupBox grpBox_kontrol;
        private System.Windows.Forms.Button btn_kontrol_start;
        private System.Windows.Forms.Timer Detak;
        private System.Windows.Forms.Button btn_kontrol_stop;
        private System.Windows.Forms.TabControl tab_menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpBox_pencatat;
        private System.Windows.Forms.GroupBox grpBox_databaseView;
        private System.Windows.Forms.DataGridView dataGrid_suhu;
        private System.Windows.Forms.GroupBox grpBox_kontrolPencatat;
        private System.Windows.Forms.Button btn_lihat;
        private System.Windows.Forms.DateTimePicker dtPicker_hingga;
        private System.Windows.Forms.Label lbl_stop;
        private System.Windows.Forms.Label lbl_dari;
        private System.Windows.Forms.DateTimePicker dtPicker_dari;
        private ZedGraph.ZedGraphControl zedGraphSuhu;
    }
}

