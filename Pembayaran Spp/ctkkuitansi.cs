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
    public partial class ctkkuitansi : Form
    {
        string c_id;
        public ctkkuitansi(string id)
        {
            InitializeComponent();
            c_id = id;
            koneksi.con.Close();
        }

        private void ctkkuitansi_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_pembayaran,nis,nama,nama_kelas,tgl_bayar,jurusan,tahun,bulan_bayar,jumlah_bayar,nama_petugas,id_petugas FROM vpembayaran WHERE id_pembayaran='" + c_id + "'", koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                koneksi.con.Close();
                kwitansi1.SetDataSource(dt);
                crvkuitansi.ReportSource = kwitansi1;
                crvkuitansi.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal lapor kwitansi" + ex.Message);
                koneksi.con.Close();
            }
        }

        private void crvkuitansi_Load(object sender, EventArgs e)
        {

        }
    }
}
