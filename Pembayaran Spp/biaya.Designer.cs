namespace Pembayaran_Spp
{
    partial class biaya
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
            this.txtcari = new System.Windows.Forms.TextBox();
            this.lbljumlah = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgspp = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnbersih = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.txtid_spp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttahun = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btncetak = new System.Windows.Forms.Button();
            this.txtnominal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttingkat = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgspp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcari
            // 
            this.txtcari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcari.Location = new System.Drawing.Point(123, 18);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(210, 32);
            this.txtcari.TabIndex = 45;
            this.txtcari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcari_KeyPress);
            // 
            // lbljumlah
            // 
            this.lbljumlah.AutoSize = true;
            this.lbljumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljumlah.Location = new System.Drawing.Point(322, 99);
            this.lbljumlah.Name = "lbljumlah";
            this.lbljumlah.Size = new System.Drawing.Size(64, 25);
            this.lbljumlah.TabIndex = 44;
            this.lbljumlah.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 42);
            this.label2.TabIndex = 43;
            this.label2.Text = "DATA SPP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgspp);
            this.panel1.Location = new System.Drawing.Point(327, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 396);
            this.panel1.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(22, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(37, 349);
            this.panel3.TabIndex = 2;
            // 
            // dgspp
            // 
            this.dgspp.BackgroundColor = System.Drawing.Color.White;
            this.dgspp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgspp.Location = new System.Drawing.Point(83, 23);
            this.dgspp.Name = "dgspp";
            this.dgspp.RowTemplate.Height = 28;
            this.dgspp.Size = new System.Drawing.Size(529, 352);
            this.dgspp.TabIndex = 1;
            this.dgspp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgspp_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nominal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tahun";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Olive;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(327, 531);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(99, 42);
            this.btnupdate.TabIndex = 57;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Maroon;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(860, 531);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 42);
            this.btndelete.TabIndex = 56;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.Navy;
            this.btnsimpan.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.Location = new System.Drawing.Point(214, 317);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(99, 42);
            this.btnsimpan.TabIndex = 55;
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
            this.btnbersih.Location = new System.Drawing.Point(469, 531);
            this.btnbersih.Name = "btnbersih";
            this.btnbersih.Size = new System.Drawing.Size(99, 42);
            this.btnbersih.TabIndex = 54;
            this.btnbersih.Text = "Bersih";
            this.btnbersih.UseVisualStyleBackColor = false;
            this.btnbersih.Click += new System.EventHandler(this.btnbersih_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.OrangeRed;
            this.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(23, 317);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(99, 42);
            this.btnnew.TabIndex = 53;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtid_spp
            // 
            this.txtid_spp.Enabled = false;
            this.txtid_spp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_spp.Location = new System.Drawing.Point(110, 99);
            this.txtid_spp.Name = "txtid_spp";
            this.txtid_spp.Size = new System.Drawing.Size(203, 32);
            this.txtid_spp.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 58;
            this.label6.Text = "Id Spp";
            // 
            // txttahun
            // 
            this.txttahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttahun.Location = new System.Drawing.Point(110, 204);
            this.txttahun.Mask = "0000/0000";
            this.txttahun.Name = "txttahun";
            this.txttahun.PromptChar = ' ';
            this.txttahun.Size = new System.Drawing.Size(203, 32);
            this.txttahun.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtcari);
            this.panel2.Location = new System.Drawing.Point(606, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 68);
            this.panel2.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 46;
            this.label9.Text = "Search";
            // 
            // btncetak
            // 
            this.btncetak.BackColor = System.Drawing.Color.Navy;
            this.btncetak.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncetak.ForeColor = System.Drawing.Color.White;
            this.btncetak.Location = new System.Drawing.Point(606, 531);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(99, 42);
            this.btncetak.TabIndex = 63;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = false;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // txtnominal
            // 
            this.txtnominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnominal.Location = new System.Drawing.Point(132, 264);
            this.txtnominal.Mask = "00000000000";
            this.txtnominal.Name = "txtnominal";
            this.txtnominal.PromptChar = ' ';
            this.txtnominal.Size = new System.Drawing.Size(181, 32);
            this.txtnominal.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tingkat";
            // 
            // txttingkat
            // 
            this.txttingkat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttingkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttingkat.FormattingEnabled = true;
            this.txttingkat.Items.AddRange(new object[] {
            "",
            "X",
            "XI",
            "XII"});
            this.txttingkat.Location = new System.Drawing.Point(110, 152);
            this.txttingkat.Name = "txttingkat";
            this.txttingkat.Size = new System.Drawing.Size(203, 34);
            this.txttingkat.TabIndex = 3;
            // 
            // biaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txttingkat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncetak);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txttahun);
            this.Controls.Add(this.txtnominal);
            this.Controls.Add(this.txtid_spp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnbersih);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbljumlah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "biaya";
            this.Size = new System.Drawing.Size(986, 625);
            this.Load += new System.EventHandler(this.biaya_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgspp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Label lbljumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgspp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnbersih;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtid_spp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txttahun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.MaskedTextBox txtnominal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txttingkat;
    }
}
