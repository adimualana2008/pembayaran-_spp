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
    public partial class biaya : UserControl
    {
        public MySqlCommand cmd;
        Random rundom = new Random();
        public biaya()
        {
            InitializeComponent();
        }
        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM biaya", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgspp.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal  tampil");
            }
        }
        private void jumlah()
        {
            try
            {
                koneksi.con.Open();
                string query = "SELECT COUNT(*) FROM biaya";
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
        private void acak()
        {
            int min = 100000;
            int max = 999999;
            int id = rundom.Next(min, max);
            txtid_spp.Text = "B" + id.ToString();
        }
        private void baru()
        {
            btnnew.Text = "New";
            btnnew.Enabled = true;
            btnsimpan.Enabled = false;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btnbersih.Enabled = false;
            txtnominal.Enabled = false;
            txttahun.Enabled = false;
            txttingkat.Enabled = false;
            btncetak.Enabled = true;
        }
        private void bersih()
        {
            txttahun.Text = string.Empty;
            txtid_spp.Text = string.Empty;
            txtnominal.Text = string.Empty;
            txttingkat.Text = string.Empty;
        }
        private void biaya_Load(object sender, EventArgs e)
        {
            tampil();
            jumlah();
            baru();
            bersih();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if(btnnew.Text == "Cencel")
            {
                baru();
                bersih();
            }
            else if(btnnew.Text == "New")
            {
                acak();
                btncetak.Enabled = false;
                btnnew.Enabled = true;
                btnnew.Text = "Cencel";
                btnsimpan.Enabled = true;
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                btnbersih.Enabled = true;
                txtnominal.Enabled = true;
                txttahun.Enabled = true;
                txttingkat.Enabled = true;
            }
        }

       
       
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if(txttahun.Text == "" || txtnominal.Text == "" || txttingkat.Text == "")
            {
                MessageBox.Show("silahkan isi terlebih dahulu");
                return;
            }
            try
            {
                koneksi.con.Open();
                string query = "";
                if(btndelete.Enabled == false)
                {
                    query = "INSERT INTO biaya  VALUES ('" + txtid_spp.Text + "','" + txttingkat.Text + "', '" + txttahun.Text + "','" + txtnominal.Text + "')";
                }
                else if(btndelete.Enabled == true)
                {
                    query = "UPDATE `biaya` SET `tahun`='" + txttahun.Text + "',`nominal`='" + txtnominal.Text + "', tingkat='" + txttingkat.Text + "' WHERE `id_spp`='" + txtid_spp.Text + "'";
                }
                cmd = new MySqlCommand(query, koneksi.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil di simpan");
                koneksi.con.Close();
                tampil();
                bersih();
                jumlah();
                baru();
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
            btnnew.Enabled = true;
            btnsimpan.Enabled = true;
            btnupdate.Enabled = false;
            btndelete.Enabled = true;
            btnbersih.Enabled = false;
            txtnominal.Enabled = true;
            txttahun.Enabled = true;
            txttingkat.Enabled = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Yakin Akan di Hapus","Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    koneksi.con.Open();
                    string query = "DELETE FROM biaya WHERE id_spp='" + txtid_spp.Text + "'";
                    cmd = new MySqlCommand(query, koneksi.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("berhasil di hapus");
                    koneksi.con.Close();
                    tampil();
                    bersih();
                    jumlah();
                    baru();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal hapus" + ex.Message);
            }
        }

        private void btnbersih_Click(object sender, EventArgs e)
        {
            txttahun.Text = string.Empty;
            txtnominal.Text = string.Empty;
            txttingkat.Text = string.Empty;
        }

        private void dgspp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnnew.Text = "Cencel";
            btnnew.Enabled = true;
            btnsimpan.Enabled = false;
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btnbersih.Enabled = false;
            txtid_spp.Enabled = false;
            txtnominal.Enabled = false;
            txttahun.Enabled = false;
            txttingkat.Enabled = false;

            int baris = dgspp.CurrentCell.RowIndex;
            txtid_spp.Text = dgspp.Rows[baris].Cells[0].Value.ToString();
            txttingkat.Text = dgspp.Rows[baris].Cells[1].Value.ToString();
            txttahun.Text = dgspp.Rows[baris].Cells[2].Value.ToString();
            txtnominal.Text = dgspp.Rows[baris].Cells[3].Value.ToString();
        }

        private void txtcari_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM biaya WHERE id_spp LIKE '%" + txtcari.Text + "%'  OR tahun LIKE '%" + txtcari.Text + "%' OR nominal LIKE '%" + txtcari.Text + "%' OR tingkat LIKE '%" + txtcari + "%'", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgspp.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal cari");
            }
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            string cari = txtcari.Text;
            new ctkbiaya(cari).Show();
        }

        
    }
}
