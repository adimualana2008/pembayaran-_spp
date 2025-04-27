namespace Pembayaran_Spp
{
    partial class laporantanggungan
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
            this.label4 = new System.Windows.Forms.Label();
            this.btncetak = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbtahun = new System.Windows.Forms.ComboBox();
            this.cmbkelas = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Laporan Tanggungan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btncetak);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbtahun);
            this.panel1.Controls.Add(this.cmbkelas);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(46, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 218);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Laporan";
            // 
            // btncetak
            // 
            this.btncetak.BackColor = System.Drawing.Color.Red;
            this.btncetak.FlatAppearance.BorderSize = 0;
            this.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncetak.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncetak.ForeColor = System.Drawing.Color.White;
            this.btncetak.Location = new System.Drawing.Point(760, 164);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(101, 37);
            this.btncetak.TabIndex = 4;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = false;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tahun Ajar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelas";
            // 
            // cmbtahun
            // 
            this.cmbtahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtahun.FormattingEnabled = true;
            this.cmbtahun.Location = new System.Drawing.Point(451, 98);
            this.cmbtahun.Name = "cmbtahun";
            this.cmbtahun.Size = new System.Drawing.Size(219, 33);
            this.cmbtahun.TabIndex = 1;
            // 
            // cmbkelas
            // 
            this.cmbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkelas.FormattingEnabled = true;
            this.cmbkelas.Location = new System.Drawing.Point(31, 98);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(219, 33);
            this.cmbkelas.TabIndex = 0;
            // 
            // laporantanggungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "laporantanggungan";
            this.Size = new System.Drawing.Size(986, 625);
            this.Load += new System.EventHandler(this.laporantanggungan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbtahun;
        private System.Windows.Forms.ComboBox cmbkelas;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.Label label4;
    }
}
