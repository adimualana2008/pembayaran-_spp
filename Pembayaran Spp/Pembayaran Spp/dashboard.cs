using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pembayaran_Spp.use_control;
using MySql.Data.MySqlClient;

namespace Pembayaran_Spp
{
    public partial class dashboard : Form
    {
        /*string djabatan;
        string did;
        string dnama;*/
        public dashboard(/*string jabatan, string id, string nam*/)
        {
            InitializeComponent();
            pnldashboard fdashboard = new pnldashboard();
            addUserControl(fdashboard);
            /*djabatan = jabatan;
            did = id;
            dnama = nama;*/
        }

        /*private void user()
        {
            if(djabatan == "admin")
            {
                lbljabatan.Text = "Admin Dashboard";
            }
            else if (djabatan == "petugas")
            {
                lbljabatan.Text = "Petugas Dashboard";
            }
            lblnama.Text = dnama;
            lblid.Text = "id : " + did;
        }*/

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Clear();
            panelcontainer.Controls.Add(userControl);
        }
        private void btndashboard_Click(object sender, EventArgs e)
        {
            pnldashboard fdashboard = new pnldashboard();
            addUserControl(fdashboard);
        }

        private void btntransaksi_Click(object sender, EventArgs e)
        {
            pnltransaksi frmtransaksi = new pnltransaksi();
            addUserControl(frmtransaksi);
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //user();
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            pnlsiswa frmsiswa = new pnlsiswa();
            addUserControl(frmsiswa);
        }
    }
}
