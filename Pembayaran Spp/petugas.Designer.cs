namespace Pembayaran_Spp
{
    partial class petugas
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncetak = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgpetugas = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbljumlah = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.rdlaki = new System.Windows.Forms.RadioButton();
            this.rdperempuan = new System.Windows.Forms.RadioButton();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnbersih = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtjabatan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnotelp = new System.Windows.Forms.MaskedTextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpetugas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "DATA PETUGAS";
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(720, 16);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(197, 26);
            this.txtcari.TabIndex = 43;
            this.txtcari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcari_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btncetak);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dgpetugas);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtcari);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Location = new System.Drawing.Point(27, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 280);
            this.panel1.TabIndex = 42;
            // 
            // btncetak
            // 
            this.btncetak.BackColor = System.Drawing.Color.White;
            this.btncetak.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncetak.FlatAppearance.BorderSize = 2;
            this.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncetak.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncetak.ForeColor = System.Drawing.Color.Black;
            this.btncetak.Location = new System.Drawing.Point(169, 16);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(129, 39);
            this.btncetak.TabIndex = 71;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = false;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(611, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 27);
            this.label10.TabIndex = 70;
            this.label10.Text = "Search";
            // 
            // dgpetugas
            // 
            this.dgpetugas.BackgroundColor = System.Drawing.Color.White;
            this.dgpetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpetugas.Location = new System.Drawing.Point(62, 70);
            this.dgpetugas.Name = "dgpetugas";
            this.dgpetugas.RowTemplate.Height = 28;
            this.dgpetugas.Size = new System.Drawing.Size(855, 154);
            this.dgpetugas.TabIndex = 1;
            this.dgpetugas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgpetugas_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(19, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 154);
            this.panel3.TabIndex = 0;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.White;
            this.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnnew.FlatAppearance.BorderSize = 2;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.Location = new System.Drawing.Point(19, 14);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(129, 39);
            this.btnnew.TabIndex = 59;
            this.btnnew.Text = "[ + ] New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Navy;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(767, 230);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(150, 38);
            this.btndelete.TabIndex = 62;
            this.btndelete.Text = "[ - ] Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "No Telepon";
            // 
            // lbljumlah
            // 
            this.lbljumlah.AutoSize = true;
            this.lbljumlah.Location = new System.Drawing.Point(233, 34);
            this.lbljumlah.Name = "lbljumlah";
            this.lbljumlah.Size = new System.Drawing.Size(51, 20);
            this.lbljumlah.TabIndex = 46;
            this.lbljumlah.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Nama Petugas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Alamat ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(314, 447);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(310, 35);
            this.txtpassword.TabIndex = 53;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(314, 376);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(310, 35);
            this.txtusername.TabIndex = 54;
            // 
            // txtalamat
            // 
            this.txtalamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalamat.Location = new System.Drawing.Point(27, 520);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(246, 75);
            this.txtalamat.TabIndex = 55;
            // 
            // rdlaki
            // 
            this.rdlaki.AutoSize = true;
            this.rdlaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlaki.Location = new System.Drawing.Point(320, 521);
            this.rdlaki.Name = "rdlaki";
            this.rdlaki.Size = new System.Drawing.Size(132, 33);
            this.rdlaki.TabIndex = 57;
            this.rdlaki.TabStop = true;
            this.rdlaki.Text = "Laki Laki";
            this.rdlaki.UseVisualStyleBackColor = true;
            // 
            // rdperempuan
            // 
            this.rdperempuan.AutoSize = true;
            this.rdperempuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdperempuan.Location = new System.Drawing.Point(461, 521);
            this.rdperempuan.Name = "rdperempuan";
            this.rdperempuan.Size = new System.Drawing.Size(163, 33);
            this.rdperempuan.TabIndex = 58;
            this.rdperempuan.TabStop = true;
            this.rdperempuan.Text = "Perempuan";
            this.rdperempuan.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Navy;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(654, 496);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(246, 42);
            this.btnupdate.TabIndex = 63;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.Navy;
            this.btnsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.Location = new System.Drawing.Point(654, 439);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(246, 42);
            this.btnsimpan.TabIndex = 61;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnbersih
            // 
            this.btnbersih.BackColor = System.Drawing.Color.Navy;
            this.btnbersih.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnbersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbersih.ForeColor = System.Drawing.Color.White;
            this.btnbersih.Location = new System.Drawing.Point(654, 554);
            this.btnbersih.Name = "btnbersih";
            this.btnbersih.Size = new System.Drawing.Size(246, 42);
            this.btnbersih.TabIndex = 60;
            this.btnbersih.Text = "Bersih";
            this.btnbersih.UseVisualStyleBackColor = false;
            this.btnbersih.Click += new System.EventHandler(this.btnbersih_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(28, 375);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(246, 35);
            this.txtid.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Id Petugas";
            // 
            // txtjabatan
            // 
            this.txtjabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtjabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjabatan.FormattingEnabled = true;
            this.txtjabatan.Items.AddRange(new object[] {
            "",
            "admin",
            "petugas"});
            this.txtjabatan.Location = new System.Drawing.Point(654, 376);
            this.txtjabatan.Name = "txtjabatan";
            this.txtjabatan.Size = new System.Drawing.Size(246, 37);
            this.txtjabatan.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Jabatan";
            // 
            // txtnotelp
            // 
            this.txtnotelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotelp.Location = new System.Drawing.Point(412, 560);
            this.txtnotelp.Mask = "0000000000000";
            this.txtnotelp.Name = "txtnotelp";
            this.txtnotelp.PromptChar = ' ';
            this.txtnotelp.Size = new System.Drawing.Size(212, 35);
            this.txtnotelp.TabIndex = 68;
            // 
            // txtnama
            // 
            this.txtnama.Enabled = false;
            this.txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(27, 447);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(246, 35);
            this.txtnama.TabIndex = 69;
            this.txtnama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnama_KeyPress);
            // 
            // petugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtnotelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtjabatan);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnbersih);
            this.Controls.Add(this.rdperempuan);
            this.Controls.Add(this.rdlaki);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbljumlah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "petugas";
            this.Size = new System.Drawing.Size(986, 625);
            this.Load += new System.EventHandler(this.petugas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpetugas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgpetugas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbljumlah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.RadioButton rdlaki;
        private System.Windows.Forms.RadioButton rdperempuan;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnbersih;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtjabatan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtnotelp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.TextBox txtnama;
    }
}
