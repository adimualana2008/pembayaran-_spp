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
    public partial class siswa : UserControl
    {
        int jmlsiswa;
        public MySqlCommand cmd;
        public MySqlDataReader dr;

        public siswa()
        {
            InitializeComponent();
        }
        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM siswa", koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                dgsiswa.DataSource = dt;
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal tampil");
            }
        }
        private void bersih()
        {
            txtnis.Text = string.Empty;
            txtnama.Text = string.Empty;
            txtalamat.Text = string.Empty;
            txtstatus.Text = string.Empty;
            if (txtlaki.Checked == true)
            {
                txtlaki.Checked = false;
            }
            else if (txtperempuan.Checked == true)
            {
                txtperempuan.Checked = false;
            }
        }
        private void baru()
        {
            btnnew.Text = "New";
            txtnis.Enabled = false;
            txtnama.Enabled = false;
            txtalamat.Enabled = false;
            btnnew.Enabled = true;
            btntambah.Enabled = false;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btnbersih.Enabled = false;
            txtlaki.Enabled = false;
            txtperempuan.Enabled = false;
            txtlaki.Checked = false;
            txtperempuan.Checked = false;
        }
        private void jumlah()
        {
            try
            {
                koneksi.con.Open();
                string query = "SELECT COUNT(*) FROM siswa";
                cmd = new MySqlCommand(query, koneksi.con);
                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                lbljumlah.Text = "Jumlah " + jumlah.ToString();
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagall jumalah");
            }
        }
        
        
        private void siswa_Load(object sender, EventArgs e)
        {
            tampil();
            baru();
            bersih();
            jumlah();
        }
       
        private void btnnew_Click(object sender, EventArgs e)
        {
            if(btnnew.Text == "Cencel")
            {
                baru();
                bersih();
            }else if (btnnew.Text == "New")
            {
                txtnis.Enabled = true;
                txtnama.Enabled = true;
                txtalamat.Enabled = true;
                txtlaki.Enabled = true;
                txtperempuan.Enabled = true;
                txtstatus.Text = "tidak aktif";
                
                btntambah.Enabled = true;
                btnbersih.Enabled = true;
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                btnnew.Enabled = true;
                btnnew.Text = "Cencel";
            }
        }

        private void btnbersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Yakin ingin di hapus", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    koneksi.con.Open();
                    string query = "DELETE FROM siswa WHERE nis='" + txtnis.Text + "'";
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
                MessageBox.Show("gagal delete" + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtnama.Enabled = true;
            txtalamat.Enabled = true;
            txtlaki.Enabled = true;
            txtperempuan.Enabled = true;
            btntambah.Enabled = true;
            btnupdate.Enabled = false;
            btnbersih.Enabled = false;
        }
        
        private void btntambah_Click(object sender, EventArgs e)
        {
            string jk = txtlaki.Checked ? "laki-laki" : txtperempuan.Checked ? "perempuan" : "";
            if (txtnis.Text == "" || txtnama.Text == "" || txtalamat.Text == "" || jk == "" )
            {
                MessageBox.Show("Silahkan isi terlebih dahulu");
                return;
            }
            try
            {
                koneksi.con.Open();
                string query = "";
                if (txtnis.Enabled == true)
                {
                    query = "INSERT INTO siswa VALUES('" + txtnis.Text + "', '" + txtnama.Text + "', '" + txtalamat.Text + "', '" + jk + "', 'tidak aktif')";

                }
                else if (txtnis.Enabled == false)
                {
                    query = "UPDATE `siswa` SET `nama`='" + txtnama.Text + "',`alamat`='" + txtalamat.Text + "',`jenis_kelamin`='" + jk + "' WHERE `nis`='" + txtnis.Text + "'";
                }

                cmd = new MySqlCommand(query, koneksi.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil di simpan :) ");
                koneksi.con.Close();
                tampil();
                baru();
                bersih();
                jumlah();

                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tambah" + ex.Message);
            }
            finally
            {
                koneksi.con.Close();
            }
        }

        private void dgsiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnama.Enabled = false;
            txtalamat.Enabled = false;
            txtlaki.Enabled = false;
            txtperempuan.Enabled = false;
            btnnew.Enabled = true;
            txtnis.Enabled = false;
            

            btntambah.Enabled = false;
            btnbersih.Enabled = false;
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btnnew.Text = "Cencel";


            int baris = dgsiswa.CurrentCell.RowIndex;
            txtnis.Text = dgsiswa.Rows[baris].Cells[0].Value.ToString();
            txtnama.Text = dgsiswa.Rows[baris].Cells[1].Value.ToString();
            txtalamat.Text = dgsiswa.Rows[baris].Cells[2].Value.ToString();
            string jk = dgsiswa.Rows[baris].Cells[3].Value.ToString();
            txtperempuan.Checked = jk == "perempuan";
            txtlaki.Checked = jk == "laki-laki";
            txtstatus.Text = dgsiswa.Rows[baris].Cells[4].Value.ToString();
        }

        private void txtcari_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM siswa WHERE nis LIKE '%" + txtcari.Text + "%' OR nama LIKE '%" + txtcari.Text + "%' OR alamat LIKE '%" + txtcari.Text + "%' OR jenis_kelamin LIKE '%"+ txtcari +"%'", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgsiswa.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal cari" + ex.Message);
            }
        }

        private void txtnama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
