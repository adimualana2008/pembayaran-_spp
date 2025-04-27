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

namespace Pembayaran_Spp.use_control
{
    public partial class pnlsiswa : UserControl
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public MySqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        public pnlsiswa()
        {
            InitializeComponent();
        }

        private void baru()
        {
            txtnis.Enabled = false;
            txtnama.Enabled = false;
            txtstatus.Enabled = false;
            txtthnajar.Enabled = false;
            txtalamat.Enabled = false;
            txtidspp.Enabled = false;
            btnsimpan.Enabled = false;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnbersih.Visible = false;
            btnnew.Visible = true;
            btnnew.Enabled = true;
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            txtnis.Enabled = true;
            txtnama.Enabled = true;
            txtalamat.Enabled = true;
            txtstatus.Enabled = true;
            txtthnajar.Enabled = true;
            txtidspp.Enabled = true;
            btnnew.Visible = false;
            btnbersih.Visible = true;
            btnedit.Enabled = true;
            btnsimpan.Enabled = true;
            btndelete.Enabled = true;
            da = new MySqlDataAdapter("SELECT * FROM biaya", koneksi.con);
            da.Fill(dt);
            txtidspp.DataSource = dt;
            txtidspp.DisplayMember = "biaya";
            txtidspp.ValueMember = "id_spp";
        }

        private void bersih()
        {
            txtnis.Text = string.Empty;
            txtnama.Text = string.Empty;
            txtstatus.Text = string.Empty;
            txtthnajar.Text = string.Empty;
            txtalamat.Text = string.Empty;
        }
        private void tampil()
        {
            try
            {
                koneksi.con.Open();
                da = new MySqlDataAdapter("SELECT * FROM siswa", koneksi.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgsiswa.DataSource = ds.Tables[0];
                koneksi.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal tampil");
            }
        }
        private void pnlsiswa_Load(object sender, EventArgs e)
        {
            baru();
            bersih();
            tampil();
        }

        private void btnbersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                string query = "INSERT INTO siswa VALUE ('" + txtnis.Text + "', '" + txtnama.Text + "', '" + txtalamat.Text + "', '" + txtthnajar.Text + "', '" + txtstatus.Text + "', '" + txtidspp.Text + "')";
                cmd = new MySqlCommand(query, koneksi.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil di tambahakan");
                koneksi.con.Close();
                tampil();
                bersih();
                baru();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal di tambahkan");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                string query = "DELETE FROM siswa WHERE nis='" + txtnis.Text + "'";
                cmd = new MySqlCommand(query, koneksi.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil di hapus");
                koneksi.con.Close();
                tampil();
                bersih();
                baru();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal di hapus");
            }
        }

        private void dgsiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnis.Enabled = false;
            txtnama.Enabled = true;
            txtalamat.Enabled = true;
            txtstatus.Enabled = true;
            txtthnajar.Enabled = true;
            txtidspp.Enabled = true;
            btnnew.Visible = false;
            btnbersih.Visible = true;
            btnedit.Enabled = true;
            btnsimpan.Enabled = true;
            btndelete.Enabled = true;

            int baris = dgsiswa.CurrentCell.RowIndex;
            txtnis.Text = dgsiswa.Rows[baris].Cells[0].Value.ToString();
            txtnama.Text = dgsiswa.Rows[baris].Cells[1].Value.ToString();
            txtalamat.Text = dgsiswa.Rows[baris].Cells[2].Value.ToString();
            txtthnajar.Text = dgsiswa.Rows[baris].Cells[3].Value.ToString();
            txtstatus.Text = dgsiswa.Rows[baris].Cells[4].Value.ToString();
            txtidspp.Text = dgsiswa.Rows[baris].Cells[5].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.con.Open();
                string query = "UPDATE siswa "
            }
        }
    }
}
