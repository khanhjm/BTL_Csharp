namespace BTL.TaoReport
{
    partial class Report_tblHanghoa
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
            this.crystalReportViewer_tblHanghoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_tblHanghoa
            // 
            this.crystalReportViewer_tblHanghoa.ActiveViewIndex = -1;
            this.crystalReportViewer_tblHanghoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_tblHanghoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_tblHanghoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_tblHanghoa.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_tblHanghoa.Name = "crystalReportViewer_tblHanghoa";
            this.crystalReportViewer_tblHanghoa.Size = new System.Drawing.Size(1068, 452);
            this.crystalReportViewer_tblHanghoa.TabIndex = 0;
            // 
            // Report_tblHanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 452);
            this.Controls.Add(this.crystalReportViewer_tblHanghoa);
            this.Name = "Report_tblHanghoa";
            this.Text = "Report_tblHanghoa";
            this.Load += new System.EventHandler(this.Report_tblHanghoa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_tblHanghoa;
    }
}