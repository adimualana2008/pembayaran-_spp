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
    public partial class ctktanggungan : Form
    {
        string t_kelas, t_tahun, nis;
        //string b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12;
        int no;
        MySqlCommand cmd;
        public ctktanggungan(string kelas,string tahun)
        {
            InitializeComponent();
            t_kelas = kelas;
            t_tahun = tahun;
            koneksi.con.Close();
        }
        //private void bulan()
        //{
        //    try
        //    {
        //        koneksi.con.Open();
        //        cmd = new MySqlCommand("SELECT * FROM vpembayaran", koneksi.con);
        //        var rd = cmd.ExecuteReader();
        //        if (rd.Read())
        //        {
        //            nis = rd["nis"].ToString();
        //        }rd.Close();

        //        for (int no = 1; no <= 12; no++)
        //        {
        //            string o;
        //            cmd = new MySqlCommand("SELECT COUNT(*) FROM vpembayaran WHERE nis='" + nis + "' AND bulan_bayar='" + no + "'", koneksi.con);
        //            int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
        //            if (jumlah > 0)
        //            {
        //                o = "V";
        //            }
        //            else
        //            {
        //                o = "X";
        //            }
        //            if (no == 1)
        //                b1 = o;
        //            else if (no == 2)
        //                b2 = o;
        //            else if (no == 3)
        //                b3 = o;
        //            else if (no == 4)
        //                b4 = o;
        //            else if (no == 5)
        //                b5 = o;
        //            else if (no == 6)
        //                b6 = o;
        //            else if (no == 7)
        //                b7 = o;
        //            else if (no == 8)
        //                b8 = o;
        //            else if (no == 9)
        //                b9 = o;
        //            else if (no == 10)
        //                b10 = o;
        //            else if (no == 11)
        //                b11 = o;
        //            else if (no == 12)
        //                b12 = o;
        //            no++;
        //        }
        //        koneksi.con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("gagal mencari nis" + ex.Message);
        //    }
        //}
        private void ctktanggungan_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10 + b11 + b12);

            try
            {
                koneksi.con.Open();
                string query = "SELECT nis,nama FROM vpembayaran GROUP BY nis,nama";
                MySqlDataAdapter da = new MySqlDataAdapter(query, koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                koneksi.con.Close();
                tanggungan1.SetDataSource(dt);
                //tanggungan1.SetParameterValue("bulan1", b1);
                //tanggungan1.SetParameterValue("bulan2", b2);
                //tanggungan1.SetParameterValue("bulan3", b3);
                //tanggungan1.SetParameterValue("bulan4", b4);
                //tanggungan1.SetParameterValue("bulan5", b5);
                //tanggungan1.SetParameterValue("bulan6", b6);
                //tanggungan1.SetParameterValue("bulan7", b7);
                //tanggungan1.SetParameterValue("bulan8", b8);
                //tanggungan1.SetParameterValue("bulan9", b9);
                //tanggungan1.SetParameterValue("bulan10", b10);
                //tanggungan1.SetParameterValue("bulan11", b11);
                //tanggungan1.SetParameterValue("bulan12", b12);

                crystalReportViewer1.ReportSource = tanggungan1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal laporan tanggungan " + ex.Message);
            }
        }
    }
}
