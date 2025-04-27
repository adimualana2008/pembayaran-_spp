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
    public partial class Transaksi_pembayaran : UserControl
    {
        string id_spp, id_petugas, id_pbyrn, id_siswa;
        int bulan, harga;
        Random rundom = new Random();
        public MySqlCommand cmd;
        public Transaksi_pembayaran(string d_id)
        {
            InitializeComponent();
            id_petugas = d_id;
            koneksi.con.Close();
        }
        private void baru()
        {
            btnnew.Text = "New";
            btnsimpan.Visible = false;
            btndelete.Visible = true;
            btncetak.Visible = true;
        }
        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT `id_pembayaran`,`id_petugas`,`nis`,`nama`,`tahun`,`nominal`,`nama_kelas`,`bulan_bayar`,`tgl_bayar` FROM vpembayaran WHERE id_petugas='" + id_petugas + "'", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgtransaksi.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tampil pembayaran | " + ex.Message);
            }
        }
        private void tampilsiswa()
        {
            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM vsiswaaktif WHERE status='belum lunas'", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgtransaksi.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tampil pembayaran | " + ex.Message);
            }
        }
        private void bersih()
        {
            txtcari.Text = string.Empty;
            txtnis.Text = string.Empty;
            txtnama.Text = string.Empty;
            txtkelas.Text = string.Empty;
            txtjumlahbayar.Text = string.Empty;
            txtbulan_bayar.Text = string.Empty;
            txtid.Text = string.Empty;
            txttahunbayar.Text = string.Empty;
            txtbulan_bayar.Text = string.Empty;
            txttglbayar.Text = string.Empty;
        }
        private void Transaksi_pembayaran_Load(object sender, EventArgs e)
        {
            tampil();
            bersih();
            baru();
        }
        
        
       
        

        
        //lanjutkan code di bawah ini adi [mencari bulan]
        private void cekbulan()
        {
            string[] daftarbulan =
            {
                "","januari","februari","maret","april","mei","juni","juli","agustus","september","oktober","november","desember"
            };

            try
            {
                koneksi.con.Open();
                string query = "SELECT * FROM pembayaran WHERE id_siswa='" + id_siswa + "' ORDER BY tgl_bayar DESC LIMIT 1";
                cmd = new MySqlCommand(query, koneksi.con);
                var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    bulan = Convert.ToInt32(rd["bulan_bayar"]);
                    id_siswa = rd["id_siswa"].ToString();
                    rd.Close();
                    koneksi.con.Close();
                    if (bulan == 12)
                    {
                        bulan = 1;
                    }
                    else
                    {
                        bulan++;
                    }
                    txtbulan_bayar.Text = daftarbulan[bulan];
                }
                else
                {
                    bulan = 7;
                    txtbulan_bayar.Text = daftarbulan[bulan];
                }
                koneksi.con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal bulan" + ex.Message);
            }
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if(txtnis.Text == "")
            {
                MessageBox.Show("silahkan pilih data siswa terlebih dahulu", "Warning");
                return;
            }
            try
            {
                koneksi.con.Open();
                string query = "INSERT INTO `pembayaran`(`id_pembayaran`, `id_petugas`, `id_siswa`, `jumlah_bayar`, `bulan_bayar`, `tahun_bayar`, `tgl_bayar`) VALUES ('" + txtid.Text + "', '" + id_petugas + "','" + id_siswa + "','" + harga.ToString() + "','" + bulan.ToString() + "','" + txttahunbayar.Text + "','" + txttglbayar.Text + "')";
                cmd = new MySqlCommand(query, koneksi.con);
                cmd.ExecuteNonQuery();
                koneksi.con.Close();
                if (bulan == 6)
                {
                    MessageBox.Show("peserta didik lunas");
                    koneksi.con.Open();
                    cmd = new MySqlCommand("UPDATE `data_siswa` SET `status`='lunas' WHERE `id_siswa`='" + id_siswa + "'", koneksi.con);
                    cmd.ExecuteNonQuery();
                    koneksi.con.Close();
                }
                else
                {
                    MessageBox.Show("berhasil di simpan");
                }

                //dua baris di bawah ini gausah di code karena untuk mencetak
                string id = txtid.Text;
                new ctkkuitansi(id).Show();
                tampil();
                bersih();
                baru();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal simpan"+ex.Message);
                koneksi.con.Close();
            }
        }


        //dibawah ini gausah d code karena untuk mencetak
        private void btncetak_Click(object sender, EventArgs e)
        {
            string id = id_pbyrn;
            if (id == "")
            {
                MessageBox.Show("Silahkan Pilih data yang akan di cetak");
                return;
            }
            new ctkkuitansi(id).Show();
            id_pbyrn = "";
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (btnnew.Text == "New")
            {
                btnnew.Text = "Cencel";
                txtid.Text = "T" + DateTime.Now.ToString("yyMMddhh") + rundom.Next(100, 999).ToString();
                txttglbayar.Text = DateTime.Now.ToString("yyyy-MM-dd H:m:s");
                tampilsiswa();

                btnsimpan.Visible = true;
                btndelete.Visible = false;
                btncetak.Visible = false;
            }
            else if (btnnew.Text == "Cencel")
            {
                baru();
                bersih();
                tampil();
            }
        }

        
        private void dgtransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgtransaksi.CurrentCell.RowIndex;
            if (btnnew.Text == "Cencel")
            {
                if(e.RowIndex >= 0)
                {
                    btnsimpan.Enabled = true;
                    id_siswa = dgtransaksi.Rows[baris].Cells[0].Value.ToString();
                    txtnis.Text = dgtransaksi.Rows[baris].Cells[1].Value.ToString();
                    txtnama.Text = dgtransaksi.Rows[baris].Cells[2].Value.ToString();
                    txtkelas.Text = dgtransaksi.Rows[baris].Cells[5].Value.ToString();
                    id_spp = dgtransaksi.Rows[baris].Cells[7].Value.ToString();
                    txttahunbayar.Text = dgtransaksi.Rows[baris].Cells[9].Value.ToString();
                    harga = int.Parse(dgtransaksi.Rows[baris].Cells[10].Value.ToString());
                    cekbulan();
                    txtjumlahbayar.Text = "Rp" + harga.ToString("N0");
                }
            }
            else
            {
                id_pbyrn = dgtransaksi.Rows[baris].Cells[0].Value.ToString();
            }
        }

        private void txtcari_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                koneksi.con.Open();
                string query = "";
                if(btnnew.Text == "New")
                {
                    query = "SELECT * FROM vpembayaran WHERE id_pembayaran LIKE '%" + txtcari.Text + "%' OR id_petugas LIKE '%" + txtcari.Text + "%' OR id_siswa LIKE '%" + txtcari.Text + "%' OR nama LIKE '%" + txtcari.Text + "%' OR jumlah_bayar LIKE '%" + txtcari.Text + "%' OR bulan_bayar LIKE '%" + txtcari.Text + "%' OR tahun_bayar LIKE '%" + txtcari.Text + "%' OR tgl_bayar LIKE '%" + txtcari.Text + "%' OR status LIKE '%" + txtcari.Text + "%'";
                }
                else if(btnnew.Text == "Cencel")
                {
                    query = "SELECT * FROM vsiswaaktif WHERE nis LIKE '%" + txtcari.Text + "%' OR nama LIKE '%" + txtcari.Text + "%' OR nama_kelas LIKE '%" + txtcari.Text + "%' OR tahun LIKE '%" + txtcari.Text + "%' OR nominal LIKE '%" + txtcari.Text + "%' OR tingkat LIKE '%" + txtcari.Text + "%'";
                }
                MySqlDataAdapter da = new MySqlDataAdapter(query, koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgtransaksi.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal cari");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(id_pbyrn == "")
            {
                MessageBox.Show("Silahkan Pilih data yang akan di hapus");
                return;
            }
            try
            {
                if(MessageBox.Show("Yakin di hapus " + id_pbyrn,"Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    koneksi.con.Open();
                    cmd = new MySqlCommand("DELETE FROM pembayaran WHERE id_pembayaran='" + id_pbyrn + "'", koneksi.con);
                    cmd.ExecuteNonQuery();
                    koneksi.con.Close();
                    tampil();
                    bersih();
                    baru();
                    id_pbyrn = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("gagal hapus transaksi");
            }
        }
    }
}