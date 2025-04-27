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
    public partial class laporantanggungan : UserControl
    {
        public laporantanggungan()
        {
            InitializeComponent();
        }
        private void kelas_tahun()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kelas", koneksi.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkelas.DataSource = dt;
            cmbkelas.ValueMember = "nama_kelas";

            MySqlDataAdapter dai = new MySqlDataAdapter("SELECT * FROM biaya", koneksi.con);
            DataTable dti = new DataTable();
            dai.Fill(dti);
            cmbtahun.DataSource = dti;
            cmbtahun.ValueMember = "tahun";
        }
        private void laporantanggungan_Load(object sender, EventArgs e)
        {
            kelas_tahun();
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            string kelas = cmbkelas.Text;
            string tahun = cmbtahun.Text;
            new ctktanggungan(kelas, tahun).Show();
        }
    }
}
