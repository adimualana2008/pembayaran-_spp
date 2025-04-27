namespace Pembayaran_Spp
{
    partial class Transaksi_pembayaran
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgtransaksi = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtjumlahbayar = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttahunbayar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.txtnis = new System.Windows.Forms.TextBox();
            this.txtbulan_bayar = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttglbayar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncetak = new System.Windows.Forms.Button();
            this.txtkelas = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.White;
            this.btnsimpan.FlatAppearance.BorderSize = 2;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.ForeColor = System.Drawing.Color.Black;
            this.btnsimpan.Location = new System.Drawing.Point(231, 562);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(488, 49);
            this.btnsimpan.TabIndex = 51;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Maroon;
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(38, 276);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(108, 41);
            this.btnnew.TabIndex = 50;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.dgtransaksi);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(24, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(936, 226);
            this.panel4.TabIndex = 49;
            // 
            // dgtransaksi
            // 
            this.dgtransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtransaksi.Location = new System.Drawing.Point(60, 19);
            this.dgtransaksi.Name = "dgtransaksi";
            this.dgtransaksi.RowTemplate.Height = 28;
            this.dgtransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtransaksi.Size = new System.Drawing.Size(852, 190);
            this.dgtransaksi.TabIndex = 1;
            this.dgtransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtransaksi_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(14, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(27, 190);
            this.panel5.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 31);
            this.label10.TabIndex = 48;
            this.label10.Text = "Transaksi";
            // 
            // txtjumlahbayar
            // 
            this.txtjumlahbayar.Enabled = false;
            this.txtjumlahbayar.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjumlahbayar.Location = new System.Drawing.Point(682, 224);
            this.txtjumlahbayar.Name = "txtjumlahbayar";
            this.txtjumlahbayar.Size = new System.Drawing.Size(278, 37);
            this.txtjumlahbayar.TabIndex = 68;
            // 
            // txtnama
            // 
            this.txtnama.Enabled = false;
            this.txtnama.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(213, 169);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(301, 37);
            this.txtnama.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nominal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 30);
            this.label3.TabIndex = 61;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 60;
            this.label4.Text = "Kelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 30);
            this.label5.TabIndex = 59;
            this.label5.Text = "Nis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 30);
            this.label6.TabIndex = 58;
            this.label6.Text = "Bulan Bayar";
            // 
            // txttahunbayar
            // 
            this.txttahunbayar.Enabled = false;
            this.txttahunbayar.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttahunbayar.Location = new System.Drawing.Point(682, 113);
            this.txttahunbayar.Name = "txttahunbayar";
            this.txttahunbayar.Size = new System.Drawing.Size(278, 37);
            this.txttahunbayar.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 71;
            this.label1.Text = "Tahun Bayar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtcari);
            this.panel2.Location = new System.Drawing.Point(619, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 46);
            this.panel2.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Search";
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(127, 11);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(190, 26);
            this.txtcari.TabIndex = 0;
            this.txtcari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcari_KeyPress);
            // 
            // txtnis
            // 
            this.txtnis.Enabled = false;
            this.txtnis.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnis.Location = new System.Drawing.Point(213, 113);
            this.txtnis.Name = "txtnis";
            this.txtnis.Size = new System.Drawing.Size(301, 37);
            this.txtnis.TabIndex = 74;
            // 
            // txtbulan_bayar
            // 
            this.txtbulan_bayar.Enabled = false;
            this.txtbulan_bayar.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbulan_bayar.Location = new System.Drawing.Point(682, 62);
            this.txtbulan_bayar.Name = "txtbulan_bayar";
            this.txtbulan_bayar.Size = new System.Drawing.Size(278, 37);
            this.txtbulan_bayar.TabIndex = 75;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(213, 62);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(301, 37);
            this.txtid.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 30);
            this.label7.TabIndex = 76;
            this.label7.Text = "ID Pembayaran";
            // 
            // txttglbayar
            // 
            this.txttglbayar.Enabled = false;
            this.txttglbayar.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttglbayar.Location = new System.Drawing.Point(682, 166);
            this.txttglbayar.Name = "txttglbayar";
            this.txttglbayar.Size = new System.Drawing.Size(278, 37);
            this.txttglbayar.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(520, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 78;
            this.label8.Text = "Tgl Bayar";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.FlatAppearance.BorderSize = 2;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(166, 276);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(108, 41);
            this.btndelete.TabIndex = 80;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncetak
            // 
            this.btncetak.BackColor = System.Drawing.Color.Black;
            this.btncetak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncetak.FlatAppearance.BorderSize = 2;
            this.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncetak.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncetak.ForeColor = System.Drawing.Color.White;
            this.btncetak.Location = new System.Drawing.Point(292, 276);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(108, 41);
            this.btncetak.TabIndex = 81;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = false;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // txtkelas
            // 
            this.txtkelas.Enabled = false;
            this.txtkelas.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkelas.Location = new System.Drawing.Point(213, 221);
            this.txtkelas.Name = "txtkelas";
            this.txtkelas.Size = new System.Drawing.Size(301, 37);
            this.txtkelas.TabIndex = 82;
            // 
            // Transaksi_pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtkelas);
            this.Controls.Add(this.btncetak);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txttglbayar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbulan_bayar);
            this.Controls.Add(this.txtnis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txttahunbayar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtjumlahbayar);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Name = "Transaksi_pembayaran";
            this.Size = new System.Drawing.Size(986, 625);
            this.Load += new System.EventHandler(this.Transaksi_pembayaran_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgtransaksi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtjumlahbayar;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttahunbayar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.TextBox txtnis;
        private System.Windows.Forms.TextBox txtbulan_bayar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttglbayar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.TextBox txtkelas;
    }
}
