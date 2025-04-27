namespace Pembayaran_Spp.use_control
{
    partial class pnldashboard
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
            this.btnsiswa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang ";
            // 
            // btnsiswa
            // 
            this.btnsiswa.Location = new System.Drawing.Point(76, 121);
            this.btnsiswa.Name = "btnsiswa";
            this.btnsiswa.Size = new System.Drawing.Size(75, 23);
            this.btnsiswa.TabIndex = 1;
            this.btnsiswa.Text = "button1";
            this.btnsiswa.UseVisualStyleBackColor = true;
            this.btnsiswa.Click += new System.EventHandler(this.btnsiswa_Click);
            // 
            // pnldashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsiswa);
            this.Controls.Add(this.label1);
            this.Name = "pnldashboard";
            this.Size = new System.Drawing.Size(602, 379);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsiswa;
    }
}
