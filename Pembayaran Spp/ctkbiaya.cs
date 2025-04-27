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
    public partial class ctkbiaya : Form
    {
        string b_cari;
        public ctkbiaya(string cari)
        {
            InitializeComponent();
            b_cari = cari;
        }

        private void ctkbiaya_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM biaya WHERE id_spp LIKE '%" + b_cari + "%'  OR tahun LIKE '%" + b_cari + "%' OR nominal LIKE '%" + b_cari + "%' OR tingkat LIKE '%" + b_cari + "%'", koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                koneksi.con.Close();
                LPbiaya1.SetDataSource(dt);
                crystalReportViewer1.ReportSource = LPbiaya1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal cetak biaya" + ex.Message);
            }
        }
    }
}
