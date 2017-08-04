namespace BTL.TaoReport
{
    partial class Report_tblHoadonbanhang
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
            this.crystalReportViewer_tblHoadonbanhang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_tblHoadonbanhang
            // 
            this.crystalReportViewer_tblHoadonbanhang.ActiveViewIndex = -1;
            this.crystalReportViewer_tblHoadonbanhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_tblHoadonbanhang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_tblHoadonbanhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_tblHoadonbanhang.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_tblHoadonbanhang.Name = "crystalReportViewer_tblHoadonbanhang";
            this.crystalReportViewer_tblHoadonbanhang.Size = new System.Drawing.Size(1084, 491);
            this.crystalReportViewer_tblHoadonbanhang.TabIndex = 0;
            // 
            // Report_tblHoadonbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 491);
            this.Controls.Add(this.crystalReportViewer_tblHoadonbanhang);
            this.Name = "Report_tblHoadonbanhang";
            this.Text = "Report_tblHoadonbanhang";
            this.Load += new System.EventHandler(this.Report_tblHoadonbanhang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_tblHoadonbanhang;
    }
}