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
    public partial class petugas : UserControl
    {
        string id_P, id_pengguna;
        public MySqlCommand cmd;
        Random rondom = new Random();
        public petugas(string d_id)
        {
            InitializeComponent();
            id_pengguna = d_id;
            koneksi.con.Close();
        }
        private void baru()
        {
            btnnew.Text = "New";
            txtnama.Enabled = false;
            txtalamat.Enabled = false;
            txtnotelp.Enabled = false;
            txtpassword.Enabled = false;
            txtusername.Enabled = false;
            rdlaki.Enabled = false;
            rdperempuan.Enabled = false;
            txtjabatan.Enabled = false;
            btnnew.Enabled = true;
            btnsimpan.Enabled = false;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btnbersih.Enabled = false;
        }
       
        private void bersih()
        {
            txtid.Text = string.Empty;
            txtnama.Text = string.Empty;
            txtalamat.Text = string.Empty;
            txtnotelp.Text = string.Empty;
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtjabatan.Text = string.Empty;
            rdlaki.Checked = false;
            rdperempuan.Checked = false;
        }
        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_petugas,nama_petugas,alamat,username,jabatan FROM petugas", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgpetugas.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal tampil");
            }
        }
        private void jumlah()
        {
            try
            {
                koneksi.con.Open();
                string query = "SELECT COUNT(*) FROM petugas";
                cmd = new MySqlCommand(query, koneksi.con);
                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                lbljumlah.Text = "jumlah " + jumlah.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal jumlah");
            }
            finally
            {
                koneksi.con.Close();
            }
            
        }
        
        private void petugas_Load(object sender, EventArgs e)
        {
            tampil();
            jumlah();
            baru();
            bersih();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if(btnnew.Text == "cencel")
            {
                baru();
                bersih();
            }
            else if(btnnew.Text == "New")
            {
                txtid.Text = "P" + rondom.Next(0, 999999).ToString("D7");
                txtnama.Enabled = true;
                txtalamat.Enabled = true;
                txtnotelp.Enabled = true;
                txtpassword.Enabled = true;
                txtusername.Enabled = true;
                rdlaki.Enabled = true;
                rdperempuan.Enabled = true;
                txtjabatan.Enabled = true;
                btnnew.Enabled = true;
                btnsimpan.Enabled = true;
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                btnbersih.Enabled = true;
                btnnew.Text = "cencel";
            }
            
        }
        
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            string jk = rdlaki.Checked ? "laki-laki" : rdperempuan.Checked ? "perempuan" : "";
            if (txtid.Text == "" || txtnama.Text == "" || txtalamat.Text == "" || jk == "" || txtusername.Text == "" || txtpassword.Text == "" || txtnotelp.Text == "" || txtjabatan.Text == "")
            {
                MessageBox.Show("Silahkan di isi terlebih dahulu");
                return;
            }
            
            try
            {
                koneksi.con.Open();
                string query = "";
                if (btndelete.Enabled == false)
                {
                    query = "INSERT INTO petugas VALUES ('" + txtid.Text + "', '" + txtnotelp.Text + "', '" + txtnama.Text + "', '" + txtalamat.Text + "', '" + txtusername.Text + "', '" + txtpassword.Text + "', '" + txtjabatan.Text + "', '" + jk + "')";
                }
                else if (btndelete.Enabled == true)
                {
                    query = "UPDATE `petugas` SET `no_telp`='" + txtnotelp.Text + "',`nama_petugas`='" + txtnama.Text + "',`alamat`='" + txtalamat.Text + "',`username`='" + txtusername.Text + "',`password`='" + txtpassword.Text + "',`jabatan`='" + txtjabatan.Text + "',`jenis_kelamin`='" + jk + "' WHERE id_petugas='" + txtid.Text + "'";
                }
                cmd = new MySqlCommand(query, koneksi.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil di simpan");
                koneksi.con.Close();
                bersih();
                baru();
                tampil();
                jumlah();

                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Username Sudah ada !");
            }
            finally
            {
                koneksi.con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtnama.Enabled = true;
            txtalamat.Enabled = true;
            txtnotelp.Enabled = true;
            txtpassword.Enabled = true;
            txtusername.Enabled = true;
            rdlaki.Enabled = true;
            rdperempuan.Enabled = true;
            txtjabatan.Enabled = true;
            btnnew.Enabled = true;
            btnsimpan.Enabled = true;
            btnupdate.Enabled = false;
            btndelete.Enabled = true;
            btnbersih.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(txtid.Text == id_pengguna)
            {
                MessageBox.Show("Anda tidak bisa menghapus akun anda sendiri ", "Peringatan");
                return;
            }
            try
            {
                if(MessageBox.Show("Yakin akan di hapus","Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    koneksi.con.Open();
                    string query = "DELETE FROM `petugas` WHERE `id_petugas`='" + txtid.Text + "'";
                    cmd = new MySqlCommand(query, koneksi.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("berhasil di hapus");
                    koneksi.con.Close();
                    tampil();
                    bersih();
                    baru();
                    jumlah();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("gagl di hapus lee");
            }
        }

        private void btnbersih_Click(object sender, EventArgs e)
        {
            txtnama.Text = string.Empty;
            txtalamat.Text = string.Empty;
            txtnotelp.Text = string.Empty;
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtjabatan.Text = string.Empty;
            rdlaki.Checked = false;
            rdperempuan.Checked = false;
        }
        private void caridata()
        {
            try
            {
                koneksi.con.Open();
                string query = "SELECT no_telp,password,jenis_kelamin FROM petugas WHERE id_petugas='" + id_P + "'";
                cmd = new MySqlCommand(query, koneksi.con);
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txtnotelp.Text = rd["no_telp"].ToString();
                    txtpassword.Text = rd["password"].ToString();
                    string jk = rd["jenis_kelamin"].ToString();
                    if (jk == "laki-laki")
                    {
                        rdlaki.Checked = true;
                    }
                    else if (jk == "perempuan")
                    {
                        rdperempuan.Checked = true;
                    }
                }koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal cekdata");
            }
        }
        private void dgpetugas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnama.Enabled = false;
            txtalamat.Enabled = false;
            txtnotelp.Enabled = false;
            txtpassword.Enabled = false;
            txtusername.Enabled = false;
            rdlaki.Enabled = false;
            rdperempuan.Enabled = false;
            txtjabatan.Enabled = false;
            btnnew.Enabled = true;
            btnsimpan.Enabled = false;
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btnbersih.Enabled = false;
            btnnew.Text = "cencel";

            int baris = dgpetugas.CurrentCell.RowIndex;
            id_P = dgpetugas.Rows[baris].Cells[0].Value.ToString();
            txtnama.Text = dgpetugas.Rows[baris].Cells[1].Value.ToString();
            txtalamat.Text = dgpetugas.Rows[baris].Cells[2].Value.ToString();
            txtusername.Text = dgpetugas.Rows[baris].Cells[3].Value.ToString();
            txtjabatan.Text = dgpetugas.Rows[baris].Cells[4].Value.ToString();
            txtid.Text = id_P;
            caridata();
        }

        private void txtcari_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_petugas,nama_petugas,alamat,username,jabatan FROM petugas WHERE id_petugas LIKE '%" + txtcari.Text + "%' OR  nama_petugas LIKE '%" + txtcari.Text + "%' OR alamat LIKE '%" + txtcari.Text + "%' OR username LIKE '%" + txtcari.Text + "%' OR  jabatan LIKE '%" + txtcari.Text + "%' ", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgpetugas.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal cari");
            }
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            string nama = txtcari.Text;
            new ctkpetugas(nama).Show();
        }

        private void txtnama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
