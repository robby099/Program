using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//namespace untuk zedGrpah
using ZedGraph;
//namespace untuk class serial
using System.IO.Ports;
//namespace untuk melihat setting global komputer
using System.Globalization;
//Namespace untuk databse MSSQL
using System.Data.SqlClient;

namespace Monitor_Suhu
{
    public partial class Form_utama : Form
    {
        /**Inisialisaisi arduino
         * Setup port serial dengan nama port COM65,
         * dan baud rate sebesar 9600.
         * Baud rate disini dengan di arduino harus sama
         * **/
        SerialPort arduino = new SerialPort("COM65",9600);


        /**Inisialisasi databse
         * setup string koneksi 
         * **/
        SqlConnection cs = new SqlConnection("Data Source=localhost;Initial Catalog=DB_SUHU;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();


        //Array list untuk menyimpan data suhu dan waktu
        double[] bufferSuhu = new double[10];
        double[] bufferWaktu = new double[10];

        List<double> listSuhu = new List<double>();
        List<double> listWaktu = new List<double>(); 
        
        //waktu mulai dalam milidetik
        double waktuStart = 100;
        //interval simpan ke database (menit)
        int intervalSimpan = 1;
        //pencacah interval
        int counter = 0;


        //konstruktor
        public Form_utama()
        {
            InitializeComponent();
        }

        //event ketuka tombol start diklik
        private void btn_kontrol_start_Click(object sender, EventArgs e)
        {
            //start detak untuk mulai mengaktifkan grapher
            try
            {
                //matikan tombol start
                btn_kontrol_start.Enabled = false;
                //nyalakan tombol stop
                btn_kontrol_stop.Enabled = true;
                //set batas waktu pembacaan serial sebelum dinyatakan gagal
                arduino.ReadTimeout = 1000;
                //set batas waktu penulisan serial
                arduino.WriteTimeout = 1000;

                //nyalakan detak
                Detak.Enabled = true;
                //mulai detak
                Detak.Start();                      
            }
            catch (Exception gagal)
            {
                //Error handling
                //MessageBox.Show(gagal.ToString());
            }
        }

        
        //event ketika detak dimulai
        private void Detak_Tick(object sender, EventArgs e)
        {
            try
            {
                //increment-kan pencacah
                counter++;

                //Mulai komunikasi dengan arduino
                arduino.Open();

                //get item kurva pertama pada grafik
                LineItem kurvaSuhu = zedGraphSuhu.GraphPane.CurveList[0] as LineItem;

                //get PointPairList
                IPointListEdit listSuhu = kurvaSuhu.Points as IPointListEdit;

                //waktu yang terlewati
                double waktu = (Environment.TickCount - waktuStart) / 1000.0;

                //baca data suhu yang dikirim arduino,
                //konversi data tersebut (string) ke double,
                //dan tambahkan ke listSuhu
                float dataSuhu = float.Parse(arduino.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                listSuhu.Add(waktu, Convert.ToDouble(dataSuhu));

                //Tutup komunikasi dengan arduino
                arduino.Close();

                //Buat scale X tetap rolling dalam interval 30 detik, dengan satu
                //langkah besar antara nilai X maksimal dan akhir dari axis
                Scale xScale = zedGraphSuhu.GraphPane.XAxis.Scale;
                if (waktu > xScale.Max - xScale.MajorStep)
                {
                    xScale.Max = waktu + xScale.MajorStep;
                    xScale.Min = xScale.Max - 30.0;
                }

                // Pastikan Y axis di scale ulang untuk mengakomodir data aktual
                zedGraphSuhu.AxisChange();

                // Redraw paksa
                zedGraphSuhu.Invalidate();

                /** 
                 * Mencatat suhu ke database
                 * **/

                //lakukan hanya pada interval yang telah ditentukan
                //intervalSimpan (menit) x 60 x 2, karena 1 detak = 500 milidetik / 1/2 detik
                if(counter == (intervalSimpan*60*2))
                {
                    //Buat query untuk insert catatan
                    da.InsertCommand = new SqlCommand("INSERT INTO tbl_suhu (suhu, waktu) VALUES(@SUHU, @WAKTU)",cs);
                    da.InsertCommand.Parameters.AddWithValue("@SUHU", SqlDbType.Float).Value = dataSuhu;
                    da.InsertCommand.Parameters.AddWithValue("@WAKTU", SqlDbType.DateTime).Value = DateTime.Now;

                    //buka koneksi ke database
                    cs.Open();
                    //eksekusi query insert
                    da.InsertCommand.ExecuteNonQuery();
                    //tutup koneksi ke database
                    cs.Close();

                    //reset pencacah
                    counter = 0;
                }
            }
            catch (Exception gagal)
            {
                //error handling
                //tutup komunikasi dengan arduino jika masih terhubung
                if (arduino.IsOpen)
                {
                    arduino.Close();
                }
                //MessageBox.Show(gagal.ToString());
            }

        }


        //event ketika tombol stop diklik
        private void btn_kontrol_stop_Click(object sender, EventArgs e)
        {
            try
            {
                //nyalakan kembali tombol start
                btn_kontrol_start.Enabled = true;
                //matikan tombol stop
                btn_kontrol_stop.Enabled = false;
                //stop detak
                Detak.Stop();
                //matikan detak
                Detak.Enabled = false;
                //jika komunikasi masih terbuka, tutup komunikasi
                if (arduino.IsOpen)
                {
                    arduino.Close();
                }
            }
            catch (Exception gagal)
            {
                //error handling
                //MessageBox.Show(gagal.ToString());
            }
        }
        
        //event ketika form utama dibuka
        private void Form_utama_Load(object sender, EventArgs e)
        {
            try
            {
                //catat waktu pertama sebagai referensi
                waktuStart = Environment.TickCount;

                //Inisialisasi ZedGraph
                GraphPane grafikSuhu = zedGraphSuhu.GraphPane;
                grafikSuhu.Title.Text = "Grafik Suhu";
                grafikSuhu.XAxis.Title.Text = "Waktu (Detik)";
                grafikSuhu.YAxis.Title.Text = "Suhu (Celcius)";

                //Simpan 120 point. Pada 500 ms sampel rate.
                //RollingPointPairList adalah class penyimpanan yang efisien 
                //dengan tetap merolling kumpulan point data tanpa perlu
                //men-shift nilai data apapun
                RollingPointPairList listSuhu = new RollingPointPairList(120);

                //Inisialisasi kurva
                LineItem kurvaSuhu = grafikSuhu.AddCurve("Suhu", listSuhu, Color.Red, SymbolType.None);
            }
            catch (Exception gagal)
            {
                //error handling
                //MessageBox.Show(gagal.ToString());
            }
        }


        //event ketika tombol lihat diklik
        private void btn_lihat_Click(object sender, EventArgs e)
        {
            try
            {
                //dari tanggal
                DateTime dari = Convert.ToDateTime(dtPicker_dari.Text);
                //hingga tanggal
                DateTime hingga = Convert.ToDateTime(dtPicker_hingga.Text);

                //string koneksi untuk mengambil data dari database
                da.SelectCommand = new SqlCommand("SELECT * FROM tbl_suhu WHERE waktu >= @DARI AND waktu <= @HINGGA ORDER BY id ASC", cs);
                da.SelectCommand.Parameters.AddWithValue("@DARI", SqlDbType.DateTime).Value = dari;
                da.SelectCommand.Parameters.AddWithValue("@HINGGA", SqlDbType.DateTime).Value = hingga;

                //buka koneksi ke database
                cs.Open();
                //eksekusi query select
                da.SelectCommand.ExecuteNonQuery();
                //tutup koneksi ke database
                cs.Close();

                //buat datatable untuk menampung catatan suhu
                DataTable dt_suhu = new DataTable();
                //kosongkan dt_suhu
                dt_suhu.Clear();
                //isi dt_suhu dengan catatan dari database
                da.Fill(dt_suhu);
                //tampilkan pada datagrid
                dataGrid_suhu.DataSource = dt_suhu;
            }
            catch (Exception gagal)
            { 
                //error handling
                //MessageBox.Show(gagal.ToString());
            }
        }

    }
}
