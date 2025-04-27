namespace Pembayaran_Spp
{
    partial class pnllpsiswa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtahun = new System.Windows.Forms.ComboBox();
            this.cmbkelas = new System.Windows.Forms.ComboBox();
            this.btncetak = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Siswa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btncetak);
            this.panel1.Controls.Add(this.cmbkelas);
            this.panel1.Controls.Add(this.cmbtahun);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(42, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 217);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kelas : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tahun Ajar : ";
            // 
            // cmbtahun
            // 
            this.cmbtahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtahun.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtahun.FormattingEnabled = true;
            this.cmbtahun.Location = new System.Drawing.Point(453, 75);
            this.cmbtahun.Name = "cmbtahun";
            this.cmbtahun.Size = new System.Drawing.Size(177, 38);
            this.cmbtahun.TabIndex = 2;
            // 
            // cmbkelas
            // 
            this.cmbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkelas.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbkelas.FormattingEnabled = true;
            this.cmbkelas.Location = new System.Drawing.Point(55, 75);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(156, 38);
            this.cmbkelas.TabIndex = 3;
            // 
            // btncetak
            // 
            this.btncetak.BackColor = System.Drawing.Color.DarkRed;
            this.btncetak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncetak.FlatAppearance.BorderSize = 2;
            this.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncetak.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncetak.ForeColor = System.Drawing.Color.White;
            this.btncetak.Location = new System.Drawing.Point(724, 155);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(121, 43);
            this.btncetak.TabIndex = 4;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = false;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // pnllpsiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "pnllpsiswa";
            this.Size = new System.Drawing.Size(986, 625);
            this.Load += new System.EventHandler(this.pnllpsiswa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbkelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.ComboBox cmbtahun;
    }
}
