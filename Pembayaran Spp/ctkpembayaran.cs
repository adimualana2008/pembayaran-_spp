using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pembayaran_Spp
{
    public partial class ctkpembayaran : Form
    {
        string t_kelas, t_tahun;
        DateTime t_mulai, t_sampai;

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        public ctkpembayaran(string kelas, string tahun, DateTime mulai, DateTime sampai)
        {
            InitializeComponent();
            t_kelas = kelas;
            t_tahun = tahun;
            t_mulai = mulai;
            t_sampai = sampai;
            koneksi.con.Close();
        }

        private void ctkpembayaran_Load(object sender, EventArgs e)
        {
            string Tanggal = t_mulai.ToString("yyyy-MM-dd") + " - " + t_sampai.ToString("yyyy-MM-dd");
            
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_pembayaran,id_petugas,nis,nama,nama_kelas,tahun,jumlah_bayar,bulan_bayar,tgl_bayar FROM vpembayaran WHERE kelas='" + t_kelas + "' AND tahun='" + t_tahun + "' AND tgl_bayar>='" + t_mulai.ToString("yyyy-MM-dd H-m-s") + "' AND tgl_bayar<='" + t_sampai.ToString("yyyy-MM-dd H-m-s") + "'", koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                koneksi.con.Close();
                pembayaran1.SetDataSource(dt);
                pembayaran1.SetParameterValue("mstanggal", Tanggal);
                crystalReportViewer1.ReportSource = pembayaran1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal lapor" + ex.Message);
                koneksi.con.Close();
            }
        }
    }
}
