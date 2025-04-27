namespace Pembayaran_Spp
{
    partial class kenaikan
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnaiknominal = new System.Windows.Forms.ComboBox();
            this.txtnaiktingkat = new System.Windows.Forms.ComboBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtnaiktahun = new System.Windows.Forms.ComboBox();
            this.txtnaikkelas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtdata = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpilihkelas = new System.Windows.Forms.ComboBox();
            this.txtpilihtahun = new System.Windows.Forms.ComboBox();
            this.txtfitur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncek = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdata)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kenaikan Kelas And Periode";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtnaiknominal);
            this.panel1.Controls.Add(this.txtnaiktingkat);
            this.panel1.Controls.Add(this.btnsimpan);
            this.panel1.Controls.Add(this.txtnaiktahun);
            this.panel1.Controls.Add(this.txtnaikkelas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(34, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 423);
            this.panel1.TabIndex = 1;
            // 
            // txtnaiknominal
            // 
            this.txtnaiknominal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtnaiknominal.FormattingEnabled = true;
            this.txtnaiknominal.Location = new System.Drawing.Point(276, 375);
            this.txtnaiknominal.Name = "txtnaiknominal";
            this.txtnaiknominal.Size = new System.Drawing.Size(145, 28);
            this.txtnaiknominal.TabIndex = 10;
            // 
            // txtnaiktingkat
            // 
            this.txtnaiktingkat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtnaiktingkat.FormattingEnabled = true;
            this.txtnaiktingkat.Location = new System.Drawing.Point(194, 375);
            this.txtnaiktingkat.Name = "txtnaiktingkat";
            this.txtnaiktingkat.Size = new System.Drawing.Size(64, 28);
            this.txtnaiktingkat.TabIndex = 11;
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.DimGray;
            this.btnsimpan.FlatAppearance.BorderSize = 0;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.Location = new System.Drawing.Point(677, 354);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(136, 49);
            this.btnsimpan.TabIndex = 10;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // txtnaiktahun
            // 
            this.txtnaiktahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtnaiktahun.FormattingEnabled = true;
            this.txtnaiktahun.Location = new System.Drawing.Point(290, 339);
            this.txtnaiktahun.Name = "txtnaiktahun";
            this.txtnaiktahun.Size = new System.Drawing.Size(131, 28);
            this.txtnaiktahun.TabIndex = 9;
            // 
            // txtnaikkelas
            // 
            this.txtnaikkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtnaikkelas.FormattingEnabled = true;
            this.txtnaikkelas.Location = new System.Drawing.Point(25, 373);
            this.txtnaikkelas.Name = "txtnaikkelas";
            this.txtnaikkelas.Size = new System.Drawing.Size(128, 28);
            this.txtnaikkelas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tahun Ajar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Naik Ke Kelas  :";
            // 
            // dtdata
            // 
            this.dtdata.Location = new System.Drawing.Point(60, 131);
            this.dtdata.Name = "dtdata";
            this.dtdata.Size = new System.Drawing.Size(869, 346);
            this.dtdata.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahun Ajar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kelas";
            // 
            // txtpilihkelas
            // 
            this.txtpilihkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtpilihkelas.FormattingEnabled = true;
            this.txtpilihkelas.Location = new System.Drawing.Point(74, 13);
            this.txtpilihkelas.Name = "txtpilihkelas";
            this.txtpilihkelas.Size = new System.Drawing.Size(128, 28);
            this.txtpilihkelas.TabIndex = 4;
            // 
            // txtpilihtahun
            // 
            this.txtpilihtahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtpilihtahun.FormattingEnabled = true;
            this.txtpilihtahun.Location = new System.Drawing.Point(366, 13);
            this.txtpilihtahun.Name = "txtpilihtahun";
            this.txtpilihtahun.Size = new System.Drawing.Size(131, 28);
            this.txtpilihtahun.TabIndex = 5;
            // 
            // txtfitur
            // 
            this.txtfitur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfitur.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfitur.FormattingEnabled = true;
            this.txtfitur.Items.AddRange(new object[] {
            "kenaikan",
            "periode"});
            this.txtfitur.Location = new System.Drawing.Point(817, 20);
            this.txtfitur.Name = "txtfitur";
            this.txtfitur.Size = new System.Drawing.Size(135, 33);
            this.txtfitur.TabIndex = 6;
            this.txtfitur.TextChanged += new System.EventHandler(this.txtfitur_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pilih Fitur";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btncek);
            this.panel2.Controls.Add(this.txtpilihkelas);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtpilihtahun);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(60, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 44);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // btncek
            // 
            this.btncek.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btncek.FlatAppearance.BorderSize = 0;
            this.btncek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncek.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncek.ForeColor = System.Drawing.Color.White;
            this.btncek.Location = new System.Drawing.Point(524, 7);
            this.btncek.Name = "btncek";
            this.btncek.Size = new System.Drawing.Size(106, 34);
            this.btncek.TabIndex = 11;
            this.btncek.Text = "Submit";
            this.btncek.UseVisualStyleBackColor = false;
            this.btncek.Click += new System.EventHandler(this.btncek_Click);
            // 
            // kenaikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfitur);
            this.Controls.Add(this.dtdata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "kenaikan";
            this.Size = new System.Drawing.Size(986, 625);
            this.Load += new System.EventHandler(this.kenaikan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdata)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtpilihtahun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtpilihkelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtdata;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.ComboBox txtnaiktahun;
        private System.Windows.Forms.ComboBox txtnaikkelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtfitur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txtnaiknominal;
        private System.Windows.Forms.ComboBox txtnaiktingkat;
        private System.Windows.Forms.Button btncek;
    }
}
