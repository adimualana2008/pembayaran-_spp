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
    public partial class ctksiswa : Form
    {
        string s_kelas, s_tahun;
        public ctksiswa(string kelas, string tahun)
        {
            InitializeComponent();
            s_kelas = kelas;
            s_tahun = tahun;
            koneksi.con.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ctksiswa_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT nis, nama, status, nama_kelas, tahun, jenis_kelamin FROM vsiswaaktif WHERE nama_kelas='" + s_kelas + "' AND tahun='" + s_tahun + "'", koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                koneksi.con.Close();
                LPsiswa1.SetDataSource(dt);
                crystalReportViewer1.ReportSource = LPsiswa1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tampil siswa laporan " + ex.Message);
            }
        }
    }
}
