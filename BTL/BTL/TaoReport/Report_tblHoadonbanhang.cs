using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL.TaoReport;
using BTL.ThucThe;
using BTL.XuLy;

namespace BTL.TaoReport
{
    public partial class Report_tblHoadonbanhang : Form
    {
        private string sql;

        public Report_tblHoadonbanhang()
        {
            InitializeComponent();
        }

        public Report_tblHoadonbanhang(string sFilter)
        {
            InitializeComponent();
            sql = sFilter;
        }

        private void Report_tblHoadonbanhang_Load(object sender, EventArgs e)
        {
            //List<tblHoadonbanhang> listHoadon = new List<tblHoadonbanhang>();
            //listHoadon = new XuLy_tblHoadonbanhang().tblHoadonbanhang_Select(0);

            DataTable t = new DataTable();
            t = new XuLy_tblHoadonbanhang().TimKiem(sql);

            //DataSet dataSet = new DataSet();
            //DataTable dataTable = new XuLy_tblHoadonbanhang().TimKiem(sql);
            //dataSet.Tables.Add(dataTable);

            Report_Hoadon rp = new Report_Hoadon();
            //CrystalReport_tblHoadonbanhang rp = new CrystalReport_tblHoadonbanhang();
            rp.SetDataSource(t);
            crystalReportViewer_tblHoadonbanhang.ReportSource = rp;
            //crystalReportViewer_tblHoadonbanhang.Show();
        }
    }
}
