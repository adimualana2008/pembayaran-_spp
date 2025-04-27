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
    public partial class pnldashboard : UserControl
    {
        MySqlCommand cmd;
        public pnldashboard()
        {
            InitializeComponent();
        }

        private void jmlkelas()
        {
            try
            {
                koneksi.con.Open();
                string query = "SELECT COUNT(*) FROM kelas";
                cmd = new MySqlCommand(query, koneksi.con);
                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                lblkelas.Text = jumlah.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal jumlah kelas");
            }
            finally
            {
                koneksi.con.Close();
            }
        }
        private void jmlsiswa()
        {
            try
            {
                koneksi.con.Open();
                string query = "SELECT COUNT(*) FROM siswa";
                cmd = new MySqlCommand(query, koneksi.con);
                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                lblsiswa.Text = jumlah.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal  siswa");
            }
            finally
            {
                koneksi.con.Close();
            }
        }
        private void jmlbiaya()
        {
            try
            {
                koneksi.con.Open();
                string query = "SELECT SUM(jumlah_bayar) FROM vpembayaran";
                cmd = new MySqlCommand(query, koneksi.con);
                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                lblbiaya.Text = "Rp " + jumlah.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal jumlah siswa" + ex.Message);
            }
            finally
            {
                koneksi.con.Close();
            }
        }
        private void jumlah()
        {
            try
            {
                koneksi.con.Open();
                string query = "SELECT COUNT(*) FROM pembayaran";
                cmd = new MySqlCommand(query, koneksi.con);
                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                lbljumlah.Text = "Jumlah " + jumlah.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal jumlah pembayaran");
            }
            finally
            {
                koneksi.con.Close();
            }
        }
        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM pembayaran", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgriwayat.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("gagal tampil");
            }
            finally
            {
                koneksi.con.Close();
            }
        }
        private void pnldashboard_Load(object sender, EventArgs e)
        {
            jmlsiswa();
            jmlkelas();
            jmlbiaya();
            tampil();
            jumlah();
        }

       
    }
}
