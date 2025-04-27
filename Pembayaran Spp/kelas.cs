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
    public partial class kelas : UserControl
    {
        public MySqlCommand cmd;
        Random rundom = new Random();
        public kelas()
        {
            InitializeComponent();
        }
        private void tampil()
        {
            try{
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kelas", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgkelas.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal tampil ");
            }
        }
        private void acak()
        {
            int min = 10000;
            int max = 99999;
            int acak = rundom.Next(min, max);
            txtid_kelas.Text = "K" + acak.ToString();
        }
        private void baru()
        {
            txtkelas.Enabled = false;
            txtjurusan.Enabled = false;
            btnnew.Text = "New";
            btnnew.Enabled = true;
            btnsimpan.Enabled = false;
            btndelete.Enabled = false;
            btnbersih.Enabled = false;
            btnupdate.Enabled = false;
            btncetak.Enabled = true;
        }
        private void bersih()
        {
            txtid_kelas.Text = string.Empty;
            txtkelas.Text = string.Empty;
            txtjurusan.Text = string.Empty;
        }
        private void jumlah()
        {
            try
            {
                koneksi.con.Open();
                string query = "SELECT COUNT(*) FROM kelas";
                cmd = new MySqlCommand(query, koneksi.con);
                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                lbljumlah.Text = "jumlah " + jumlah.ToString();
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal jumlah");
            }
        }


        private void btnnew_Click(object sender, EventArgs e)
        {
            if(btnnew.Text == "cencel")
            {
                baru();
                bersih();
                
            }else if(btnnew.Text == "New"){
                acak();
                txtkelas.Enabled = true;
                txtjurusan.Enabled = true;
                btnnew.Enabled = true;
                btnnew.Text = "cencel";
                btnsimpan.Enabled = true;
                btndelete.Enabled = false;
                btnbersih.Enabled = true;
                btnupdate.Enabled = false;
                btncetak.Enabled = false;
            }
            
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (txtid_kelas.Text == "" || txtkelas.Text == "" || txtjurusan.Text == "")
            {
                MessageBox.Show("silahkan isi terlebih dahulu");
                return;
            }
            try
            {
                koneksi.con.Open();
                string query = "";
                if (btndelete.Enabled == false)
                {
                    query = "INSERT INTO `kelas` VALUES ('" + txtid_kelas.Text + "','" + txtkelas.Text + "', '" + txtjurusan.Text + "')";
                }
                else
                {
                    query = "UPDATE `kelas` SET nama_kelas='" + txtkelas.Text + "', jurusan='" + txtjurusan.Text + "' WHERE `id_kelas`='" + txtid_kelas.Text + "'";
                }
                cmd = new MySqlCommand(query, koneksi.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil di simpan");
                koneksi.con.Close();
                tampil();
                bersih();
                baru();
                jumlah();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtid_kelas.Enabled = false;
            txtkelas.Enabled = true;
            txtjurusan.Enabled = true;
            btnnew.Enabled = true;
            btnsimpan.Enabled = true;
            btndelete.Enabled = true;
            btncetak.Enabled = false;
            btnbersih.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Yakin Ingin di hapus ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    koneksi.con.Open();
                    string query = "DELETE FROM kelas WHERE id_kelas='" + txtid_kelas.Text + "'";
                    cmd = new MySqlCommand(query, koneksi.con);
                    cmd.ExecuteNonQuery();
                    koneksi.con.Close();
                    tampil();
                    bersih();
                    baru();
                    jumlah();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal hapus datta" + ex.Message);
            }
        }

        private void btnbersih_Click(object sender, EventArgs e)
        {
            txtkelas.Text = string.Empty;
            txtjurusan.Text = string.Empty;
        }

        private void dgkelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_kelas.Enabled = false;
            txtkelas.Enabled = false;
            txtjurusan.Enabled = false;
            btnnew.Text = "cencel";
            btnnew.Enabled = true;
            btnsimpan.Enabled = false;
            btndelete.Enabled = true;
            btnbersih.Enabled = false;
            btnupdate.Enabled = true;
            btncetak.Enabled = false;

            int baris = dgkelas.CurrentCell.RowIndex;
            txtid_kelas.Text = dgkelas.Rows[baris].Cells[0].Value.ToString();
            txtkelas.Text = dgkelas.Rows[baris].Cells[1].Value.ToString();
            txtjurusan.Text = dgkelas.Rows[baris].Cells[2].Value.ToString();
        }

        private void txtcari_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kelas WHERE id_kelas LIKE '%" + txtcari.Text + "%' OR nama_kelas LIKE '%" + txtcari.Text + "%' OR jurusan LIKE '%" + txtcari.Text + "%'", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgkelas.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal cari");
            }
        }

        private void kelas_Load(object sender, EventArgs e)
        {
            tampil();
            bersih();
            baru();
            jumlah();
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            string cari = txtcari.Text;
            new ctkkelas(cari).Show();
        }
    }
}
