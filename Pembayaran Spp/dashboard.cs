using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembayaran_Spp
{
    public partial class dashboard : Form
    {
        string d_jabatan, d_id, d_nama;
        public dashboard(string jabatan, string id, string nama)
        {
            InitializeComponent();
            pnldashboard dashboard = new pnldashboard();
            addUserControl(dashboard);
            d_jabatan = jabatan;
            d_id = id;
            d_nama = nama;
            koneksi.con.Close();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Clear();
            panelcontainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        

        private void btntransaksi_Click(object sender, EventArgs e)
        {
            Transaksi_pembayaran frmtransaksi = new Transaksi_pembayaran(d_id);
            addUserControl(frmtransaksi);
            laporanPanel.Visible = false;
            paneldatamaster.Visible = false;
            panelprofil.Visible = false;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            if(d_jabatan == "petugas")
            {
                dtmaster.Visible = false;
            }
            lbljabatan.Text = DateTime.Now.ToString("dddd-dd-MM-yyyy | ") + "Selamat Datang " + d_jabatan;
            btnprofil.Text ="id : " + d_id + "  < ";
            lblprofil.Text = "Nama     : " + d_nama + "\nJabatan  : " + d_jabatan;
        }

        private void btnsiswa_Click(object sender, EventArgs e)
        {
            siswa pnlsiswa = new siswa();
            addUserControl(pnlsiswa);
            paneldatamaster.Visible = false;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void btnpetugas_Click(object sender, EventArgs e)
        {
            petugas pnlpetugas = new petugas(d_id);
            addUserControl(pnlpetugas);
            paneldatamaster.Visible = false;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void btnkelas_Click(object sender, EventArgs e)
        {
            kelas pnlkelas = new kelas();
            addUserControl(pnlkelas);
            paneldatamaster.Visible = false;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void btnspp_Click(object sender, EventArgs e)
        {
            biaya pnlbiaya = new biaya();
            addUserControl(pnlbiaya);
            paneldatamaster.Visible = false;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void datamaster_Click(object sender, EventArgs e)
        {
            paneldatamaster.Visible = !paneldatamaster.Visible;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void btnlptransaksi_Click(object sender, EventArgs e)
        {
            laporan frmlaporan = new laporan();
            addUserControl(frmlaporan);
            paneldatamaster.Visible = false;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void btnlptanggungan_Click(object sender, EventArgs e)
        {
            laporantanggungan frmlaporan = new laporantanggungan();
            addUserControl(frmlaporan);
            paneldatamaster.Visible = false;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void btnprofil_Click(object sender, EventArgs e)
        {
            panelprofil.Visible = !panelprofil.Visible;
        }

        private void dashboard_MouseClick(object sender, MouseEventArgs e)
        {
            panelprofil.Visible = false;
        }

        private void panelcontainer_Click(object sender, EventArgs e)
        {
            panelprofil.Visible = false;
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            pnldashboard dashboard = new pnldashboard();
            addUserControl(dashboard);
            paneldatamaster.Visible = false;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void btnlpsiswa_Click(object sender, EventArgs e)
        {
            pnllpsiswa siswa = new pnllpsiswa();
            addUserControl(siswa);
            paneldatamaster.Visible = false;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void btnkenaikan_Click(object sender, EventArgs e)
        {
            kenaikan naik = new kenaikan();
            addUserControl(naik);
            paneldatamaster.Visible = false;
            laporanPanel.Visible = false;
            panelprofil.Visible = false;
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            paneldatamaster.Visible = false;
            panelprofil.Visible = false;
            laporanPanel.Visible = !laporanPanel.Visible;
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
            login frmlogin = new login();
            frmlogin.Show();
            this.Hide();
        }
    }
}
