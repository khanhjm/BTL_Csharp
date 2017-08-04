using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.XuLy;
using BTL.ThucThe;

namespace BTL.TaoReport
{
    public partial class Report_tblHanghoa : Form
    {
        public Report_tblHanghoa()
        {
            InitializeComponent();
        }

        private void Report_tblHanghoa_Load(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            t = new XuLy_tblHanghoa().LayToanbo();
            CrystalReport_tblHanghoa rp = new CrystalReport_tblHanghoa();
            rp.SetDataSource(t);
            crystalReportViewer_tblHanghoa.ReportSource = rp;
        }


    }
}
