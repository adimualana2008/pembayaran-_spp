namespace Pembayaran_Spp.use_control
{
    partial class pnlsiswa
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
            this.btnbersih = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgsiswa = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.txtthnajar = new System.Windows.Forms.ComboBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidspp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbersih
            // 
            this.btnbersih.Location = new System.Drawing.Point(18, 321);
            this.btnbersih.Margin = new System.Windows.Forms.Padding(2);
            this.btnbersih.Name = "btnbersih";
            this.btnbersih.Size = new System.Drawing.Size(56, 32);
            this.btnbersih.TabIndex = 36;
            this.btnbersih.Text = "Bersih";
            this.btnbersih.UseVisualStyleBackColor = true;
            this.btnbersih.Click += new System.EventHandler(this.btnbersih_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.dgsiswa);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(277, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 187);
            this.panel1.TabIndex = 35;
            // 
            // dgsiswa
            // 
            this.dgsiswa.BackgroundColor = System.Drawing.Color.White;
            this.dgsiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsiswa.Location = new System.Drawing.Point(13, 36);
            this.dgsiswa.Margin = new System.Windows.Forms.Padding(2);
            this.dgsiswa.Name = "dgsiswa";
            this.dgsiswa.RowTemplate.Height = 28;
            this.dgsiswa.Size = new System.Drawing.Size(265, 139);
            this.dgsiswa.TabIndex = 1;
            this.dgsiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsiswa_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(13, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 13);
            this.panel3.TabIndex = 0;
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "aktif",
            "tidak aktif",
            "berhenti"});
            this.txtstatus.Location = new System.Drawing.Point(104, 204);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(133, 21);
            this.txtstatus.TabIndex = 34;
            // 
            // txtthnajar
            // 
            this.txtthnajar.FormattingEnabled = true;
            this.txtthnajar.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.txtthnajar.Location = new System.Drawing.Point(104, 182);
            this.txtthnajar.Margin = new System.Windows.Forms.Padding(2);
            this.txtthnajar.Name = "txtthnajar";
            this.txtthnajar.Size = new System.Drawing.Size(133, 21);
            this.txtthnajar.TabIndex = 33;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(104, 119);
            this.txtalamat.Margin = new System.Windows.Forms.Padding(2);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(133, 59);
            this.txtalamat.TabIndex = 32;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(104, 95);
            this.txtnama.Margin = new System.Windows.Forms.Padding(2);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(133, 20);
            this.txtnama.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nis";
            // 
            // txtnis
            // 
            this.txtnis.Location = new System.Drawing.Point(104, 72);
            this.txtnis.Margin = new System.Windows.Forms.Padding(2);
            this.txtnis.Name = "txtnis";
            this.txtnis.Size = new System.Drawing.Size(133, 20);
            this.txtnis.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tahun Ajar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nama";
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(170, 321);
            this.btnsimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(56, 32);
            this.btnsimpan.TabIndex = 37;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 22);
            this.button3.TabIndex = 38;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(245, 321);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(56, 32);
            this.btnedit.TabIndex = 40;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(93, 321);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(56, 32);
            this.btndelete.TabIndex = 41;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(18, 321);
            this.btnnew.Margin = new System.Windows.Forms.Padding(2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(56, 32);
            this.btnnew.TabIndex = 42;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Data siswa";
            // 
            // txtidspp
            // 
            this.txtidspp.FormattingEnabled = true;
            this.txtidspp.Location = new System.Drawing.Point(104, 229);
            this.txtidspp.Margin = new System.Windows.Forms.Padding(2);
            this.txtidspp.Name = "txtidspp";
            this.txtidspp.Size = new System.Drawing.Size(133, 21);
            this.txtidspp.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "id spp";
            // 
            // pnlsiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtidspp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnbersih);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtthnajar);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "pnlsiswa";
            this.Size = new System.Drawing.Size(602, 379);
            this.Load += new System.EventHandler(this.pnlsiswa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgsiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbersih;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgsiswa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.ComboBox txtthnajar;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtidspp;
        private System.Windows.Forms.Label label2;
    }
}
