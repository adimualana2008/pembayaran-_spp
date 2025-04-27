namespace Pembayaran_Spp
{
    partial class laporan
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
            this.btncetak = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbkelas = new System.Windows.Forms.ComboBox();
            this.cmbtahun = new System.Windows.Forms.ComboBox();
            this.dtsampai = new System.Windows.Forms.DateTimePicker();
            this.dtmulai = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laporan Pembayaran";
            // 
            // btncetak
            // 
            this.btncetak.BackColor = System.Drawing.Color.White;
            this.btncetak.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btncetak.FlatAppearance.BorderSize = 0;
            this.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncetak.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncetak.ForeColor = System.Drawing.Color.Maroon;
            this.btncetak.Location = new System.Drawing.Point(705, 321);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(99, 42);
            this.btncetak.TabIndex = 61;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = false;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btncetak);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbkelas);
            this.panel1.Controls.Add(this.cmbtahun);
            this.panel1.Controls.Add(this.dtsampai);
            this.panel1.Controls.Add(this.dtmulai);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(36, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 387);
            this.panel1.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 30);
            this.label6.TabIndex = 72;
            this.label6.Text = "Laporan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 30);
            this.label5.TabIndex = 71;
            this.label5.Text = "Mulai Dari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 30);
            this.label4.TabIndex = 70;
            this.label4.Text = "Sampai Dari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 69;
            this.label3.Text = "Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tahun Ajar";
            // 
            // cmbkelas
            // 
            this.cmbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbkelas.FormattingEnabled = true;
            this.cmbkelas.Location = new System.Drawing.Point(73, 124);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(230, 34);
            this.cmbkelas.TabIndex = 67;
            // 
            // cmbtahun
            // 
            this.cmbtahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtahun.FormattingEnabled = true;
            this.cmbtahun.Location = new System.Drawing.Point(404, 124);
            this.cmbtahun.Name = "cmbtahun";
            this.cmbtahun.Size = new System.Drawing.Size(230, 34);
            this.cmbtahun.TabIndex = 66;
            // 
            // dtsampai
            // 
            this.dtsampai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtsampai.Location = new System.Drawing.Point(404, 246);
            this.dtsampai.Name = "dtsampai";
            this.dtsampai.Size = new System.Drawing.Size(295, 32);
            this.dtsampai.TabIndex = 65;
            // 
            // dtmulai
            // 
            this.dtmulai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmulai.Location = new System.Drawing.Point(73, 246);
            this.dtmulai.Name = "dtmulai";
            this.dtmulai.Size = new System.Drawing.Size(295, 32);
            this.dtmulai.TabIndex = 64;
            // 
            // laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "laporan";
            this.Size = new System.Drawing.Size(986, 625);
            this.Load += new System.EventHandler(this.laporan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbkelas;
        private System.Windows.Forms.ComboBox cmbtahun;
        private System.Windows.Forms.DateTimePicker dtsampai;
        private System.Windows.Forms.DateTimePicker dtmulai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}
