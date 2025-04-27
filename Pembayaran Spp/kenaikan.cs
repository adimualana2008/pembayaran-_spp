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
    public partial class kenaikan : UserControl
    {
        string id_k, id_spp;
        MySqlCommand cmd;
        public kenaikan()
        {
            InitializeComponent();
        }
        private void tampil()
        {
            string q = "SELECT * FROM vsiswaaktif WHERE nama_kelas LIKE '%" + txtpilihkelas.Text + "%' AND tahun LIKE '%" + txtpilihtahun.Text + "%'";
            if (txtfitur.Text == "kenaikan")
            {
                panel2.Visible = true;
                q = "SELECT * FROM vsiswaaktif WHERE nama_kelas LIKE '%" + txtpilihkelas.Text + "%' AND tahun LIKE '%" + txtpilihtahun.Text + "%'";
            }
            else if (txtfitur.Text == "periode")
            {
                panel2.Visible = false;
                q = "SELECT * FROM siswa WHERE status LIKE 'tidak aktif'";
            }

            try
            {
                koneksi.con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(q, koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtdata.Columns.Clear();
                if (dtdata.Columns["ceksiswa"] == null)
                {
                    DataGridViewCheckBoxColumn cek = new DataGridViewCheckBoxColumn()
                    {
                        Name = "ceksiswa",
                        Width = 50
                    };
                    dtdata.Columns.Add(cek);
                }
                dtdata.DataSource = dt;
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal cek data" + ex.Message);
            }
        }
        

        private void kenaikan_Load(object sender, EventArgs e)
        {
            txtfitur.Text = "kenaikan";
            tampil();

            MySqlDataAdapter dai = new MySqlDataAdapter("SELECT * FROM kelas", koneksi.con);
            DataTable dti = new DataTable();
            dai.Fill(dti);
            txtnaikkelas.DataSource = dti;
            txtnaikkelas.ValueMember = "nama_kelas";

            MySqlDataAdapter daa = new MySqlDataAdapter("SELECT * FROM kelas", koneksi.con);
            DataTable dta = new DataTable();
            daa.Fill(dta);
            txtpilihkelas.DataSource = dta;
            txtpilihkelas.ValueMember = "nama_kelas";

            MySqlDataAdapter dati = new MySqlDataAdapter("SELECT DISTINCT tahun FROM biaya", koneksi.con);
            DataTable ditt = new DataTable();
            dati.Fill(ditt);
            txtpilihtahun.DataSource = ditt;
            txtpilihtahun.ValueMember = "tahun";

            MySqlDataAdapter datia = new MySqlDataAdapter("SELECT * FROM biaya", koneksi.con);
            DataTable ditti = new DataTable();
            datia.Fill(ditti);
            txtnaiktahun.DataSource = ditti;
            txtnaiktahun.ValueMember = "tahun";
            txtnaiktingkat.DataSource = ditti;
            txtnaiktingkat.ValueMember = "tingkat";
            txtnaiknominal.DataSource = ditti;
            txtnaiknominal.ValueMember = "nominal";
        }
        
       

        

        private void carikelas_tahun()
        {
            try
            {
                koneksi.con.Open();
                cmd = new MySqlCommand("SELECT * FROM kelas WHERE nama_kelas='" + txtnaikkelas.Text + "'", koneksi.con);
                var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    id_k = rd["id_kelas"].ToString();
                }
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal cet kelas dll " + ex.Message);
            }

            try
            {
                
                koneksi.con.Open();
                cmd = new MySqlCommand("SELECT * FROM biaya WHERE tahun='" + txtnaiktahun.Text + "' AND tingkat='" + txtnaiktingkat.Text + "'", koneksi.con);
                var rdi = cmd.ExecuteReader();
                if (rdi.Read())
                {
                    id_spp = rdi["id_spp"].ToString();
                }
                koneksi.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal cet kelas dll " + ex.Message);
            }
        }

        

        private void txtfitur_TextChanged(object sender, EventArgs e)
        {
            tampil();
        }

        private void btncek_Click(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            carikelas_tahun();
            try
            {
                List<string> listsiswa = new List<string>();
                foreach (DataGridViewRow row in dtdata.Rows)
                {
                    if (row.Cells["ceksiswa"].Value != null && (bool)row.Cells["ceksiswa"].Value)
                    {
                        if (row.Cells["nis"].Value != null)
                        {
                            listsiswa.Add(row.Cells["nis"].Value.ToString());
                        }
                    }
                }
                MessageBox.Show("berhasil di simpan");
                foreach (string nis in listsiswa)
                {
                    koneksi.con.Open();
                    cmd = new MySqlCommand("INSERT INTO `data_siswa`(`id_siswa`, `nis`, `id_kelas`, `id_spp`, `status`) VALUES ('','" + nis + "','" + id_k + "','" + id_spp + "','belum lunas')", koneksi.con);
                    cmd.ExecuteNonQuery();

                    if(txtfitur.Text == "periode")
                    {
                        cmd = new MySqlCommand("UPDATE `siswa` SET `status`='aktif' WHERE nis='" + nis + "'", koneksi.con);
                        cmd.ExecuteNonQuery();
                    }

                    koneksi.con.Close();
                    tampil();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal simpan" + id_spp + " |" + ex.Message);
            }
        }
    }
}
