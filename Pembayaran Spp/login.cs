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
    public partial class login : Form
    {
      
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void chektampil_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !txtpassword.UseSystemPasswordChar;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            koneksi.con.Open();
            string query = "SELECT * FROM petugas WHERE username='" + txtusername.Text + "' AND password='" + txtpassword.Text + "'";
            var cmd = new MySqlCommand(query, koneksi.con);
            var rd = cmd.ExecuteReader();
            try
            {
                if (rd.Read())
                {
                    string jabatan = rd["jabatan"].ToString();
                    string id = rd["id_petugas"].ToString();
                    string nama = rd["nama_petugas"].ToString();
                    dashboard frmdashboard = new dashboard(jabatan, id, nama);
                    frmdashboard.Show();
                    this.Hide();
                }
                else if (txtusername.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("silahkan isi terlebih dahulu");
                }
                else
                {
                    MessageBox.Show("akun tidak ditemukan");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("gagal login");
            }
            koneksi.con.Close();
        }
    }
}
