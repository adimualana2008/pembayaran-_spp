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
    public partial class ctkkelas : Form
    {
        string k_cari;
        public ctkkelas(string cari)
        {
            InitializeComponent();
            k_cari = cari;
            
        }

        private void ctkkelas_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kelas WHERE id_kelas LIKE '%" + k_cari + "%' OR nama_kelas LIKE '%" + k_cari + "%' OR jurusan LIKE '%" + k_cari + "%'", koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                koneksi.con.Close();
                LPkelas1.SetDataSource(dt);
                crystalReportViewer1.ReportSource = LPkelas1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal cetak kelas" + ex.Message);
            }
        }
    }
}
