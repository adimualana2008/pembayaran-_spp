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
    public partial class ctkpetugas : Form
    {
        string cari;
        public ctkpetugas(string nama)
        {
            InitializeComponent();
            cari = nama;
            koneksi.con.Close();
        }

        private void ctkpetugas_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Close();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_petugas,nama_petugas,alamat,username,jabatan FROM petugas WHERE id_petugas LIKE '%" + cari + "%' OR  nama_petugas LIKE '%" + cari + "%' OR alamat LIKE '%" + cari + "%' OR username LIKE '%" + cari + "%' OR  jabatan LIKE '%" + cari + "%'", koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                koneksi.con.Close();
                LPpetugas1.SetDataSource(dt);
                crystalReportViewer1.ReportSource = LPpetugas1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal tampil lppetugas");
            }
        }
    }
}
