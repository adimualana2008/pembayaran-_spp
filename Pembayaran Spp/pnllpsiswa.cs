using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pembayaran_Spp
{
    public partial class pnllpsiswa : UserControl
    {
        public pnllpsiswa()
        {
            InitializeComponent();
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            string kelas = cmbkelas.Text;
            string tahun = cmbtahun.Text;
            new ctksiswa(kelas, tahun).Show();
        }
        private void kelas()
        {
            koneksi.con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kelas", koneksi.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkelas.DataSource = dt;
            cmbkelas.ValueMember = "nama_kelas";
            koneksi.con.Close();
        }
        private void biaya()
        {
            koneksi.con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT tahun FROM biaya", koneksi.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbtahun.DataSource = dt;
            cmbtahun.ValueMember = "tahun";
            koneksi.con.Close();
        }
        private void pnllpsiswa_Load(object sender, EventArgs e)
        {
            kelas();
            biaya();
        }
    }
}
