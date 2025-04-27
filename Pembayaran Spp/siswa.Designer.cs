namespace Pembayaran_Spp
{
    partial class siswa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgsiswa = new System.Windows.Forms.DataGridView();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.lbljumlah = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtlaki = new System.Windows.Forms.RadioButton();
            this.txtperempuan = new System.Windows.Forms.RadioButton();
            this.btnbersih = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtnis = new System.Windows.Forms.MaskedTextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgsiswa);
            this.panel1.Controls.Add(this.txtcari);
            this.panel1.Controls.Add(this.lbljumlah);
            this.panel1.Location = new System.Drawing.Point(28, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 274);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 52;
            this.label1.Text = "Search";
            // 
            // dgsiswa
            // 
            this.dgsiswa.BackgroundColor = System.Drawing.Color.White;
            this.dgsiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsiswa.Location = new System.Drawing.Point(19, 55);
            this.dgsiswa.Name = "dgsiswa";
            this.dgsiswa.RowTemplate.Height = 28;
            this.dgsiswa.Size = new System.Drawing.Size(901, 197);
            this.dgsiswa.TabIndex = 1;
            this.dgsiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsiswa_CellContentClick);
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(723, 16);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(197, 26);
            this.txtcari.TabIndex = 40;
            this.txtcari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcari_KeyPress);
            // 
            // lbljumlah
            // 
            this.lbljumlah.AutoSize = true;
            this.lbljumlah.Location = new System.Drawing.Point(15, 20);
            this.lbljumlah.Name = "lbljumlah";
            this.lbljumlah.Size = new System.Drawing.Size(51, 20);
            this.lbljumlah.TabIndex = 38;
            this.lbljumlah.Text = "label3";
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(152, 402);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(227, 78);
            this.txtalamat.TabIndex = 31;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(152, 367);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(227, 26);
            this.txtnama.TabIndex = 30;
            this.txtnama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnama_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Nis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "DATA SISWA";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(36, 447);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(99, 42);
            this.btnnew.TabIndex = 42;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Jenis kelamin";
            // 
            // txtlaki
            // 
            this.txtlaki.AutoSize = true;
            this.txtlaki.Location = new System.Drawing.Point(526, 330);
            this.txtlaki.Name = "txtlaki";
            this.txtlaki.Size = new System.Drawing.Size(96, 24);
            this.txtlaki.TabIndex = 44;
            this.txtlaki.TabStop = true;
            this.txtlaki.Text = "Laki Laki";
            this.txtlaki.UseVisualStyleBackColor = true;
            // 
            // txtperempuan
            // 
            this.txtperempuan.AutoSize = true;
            this.txtperempuan.Location = new System.Drawing.Point(628, 330);
            this.txtperempuan.Name = "txtperempuan";
            this.txtperempuan.Size = new System.Drawing.Size(116, 24);
            this.txtperempuan.TabIndex = 45;
            this.txtperempuan.TabStop = true;
            this.txtperempuan.Text = "Perempuan";
            this.txtperempuan.UseVisualStyleBackColor = true;
            // 
            // btnbersih
            // 
            this.btnbersih.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnbersih.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnbersih.FlatAppearance.BorderSize = 0;
            this.btnbersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbersih.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbersih.ForeColor = System.Drawing.Color.White;
            this.btnbersih.Location = new System.Drawing.Point(444, 553);
            this.btnbersih.Name = "btnbersih";
            this.btnbersih.Size = new System.Drawing.Size(178, 42);
            this.btnbersih.TabIndex = 46;
            this.btnbersih.Text = "Bersih";
            this.btnbersih.UseVisualStyleBackColor = false;
            this.btnbersih.Click += new System.EventHandler(this.btnbersih_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btntambah.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btntambah.FlatAppearance.BorderSize = 0;
            this.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntambah.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btntambah.Location = new System.Drawing.Point(242, 553);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(178, 42);
            this.btntambah.TabIndex = 47;
            this.btntambah.Text = "Simpan";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(645, 553);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(178, 42);
            this.btndelete.TabIndex = 48;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(849, 353);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(99, 42);
            this.btnupdate.TabIndex = 49;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtnis
            // 
            this.txtnis.Location = new System.Drawing.Point(152, 334);
            this.txtnis.Mask = "0000/000.000";
            this.txtnis.Name = "txtnis";
            this.txtnis.PromptChar = ' ';
            this.txtnis.Size = new System.Drawing.Size(227, 26);
            this.txtnis.TabIndex = 51;
            // 
            // txtstatus
            // 
            this.txtstatus.Enabled = false;
            this.txtstatus.Location = new System.Drawing.Point(526, 364);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(218, 26);
            this.txtstatus.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Status";
            // 
            // siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnis);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.btnbersih);
            this.Controls.Add(this.txtperempuan);
            this.Controls.Add(this.txtlaki);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Name = "siswa";
            this.Size = new System.Drawing.Size(986, 625);
            this.Load += new System.EventHandler(this.siswa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgsiswa;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbljumlah;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton txtlaki;
        private System.Windows.Forms.RadioButton txtperempuan;
        private System.Windows.Forms.Button btnbersih;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.MaskedTextBox txtnis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label label3;
    }
}
