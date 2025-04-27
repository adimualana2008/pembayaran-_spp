namespace Pembayaran_Spp
{
    partial class ctkkuitansi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvkuitansi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.kwitansi1 = new Pembayaran_Spp.kwitansi();
            this.SuspendLayout();
            // 
            // crvkuitansi
            // 
            this.crvkuitansi.ActiveViewIndex = 0;
            this.crvkuitansi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvkuitansi.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvkuitansi.DisplayStatusBar = false;
            this.crvkuitansi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvkuitansi.Location = new System.Drawing.Point(0, 0);
            this.crvkuitansi.Name = "crvkuitansi";
            this.crvkuitansi.ReportSource = this.kwitansi1;
            this.crvkuitansi.Size = new System.Drawing.Size(1081, 531);
            this.crvkuitansi.TabIndex = 0;
            this.crvkuitansi.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvkuitansi.ToolPanelWidth = 75;
            this.crvkuitansi.Load += new System.EventHandler(this.crvkuitansi_Load);
            // 
            // ctkkuitansi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 531);
            this.Controls.Add(this.crvkuitansi);
            this.Name = "ctkkuitansi";
            this.Text = "ctkkuitansi";
            this.Load += new System.EventHandler(this.ctkkuitansi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvkuitansi;
        private kwitansi kwitansi1;
    }
}