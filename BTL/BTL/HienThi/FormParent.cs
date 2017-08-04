using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.TaoReport;

namespace BTL.HienThi
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private Form findOpenedForm(string formName)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(formName))
                    return f;
            }
            return null;
        }

        private void taoHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("BanHang");
            if (f == null)
            {
                f = new BanHang();
                f.MdiParent = this;
            }
            f.Show();
            f.Activate();
        }

        private void xemHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("XemHoadonbanhang");
            if (f == null)
            {
                f = new XemHoadonbanhang();
                f.MdiParent = this;
            }
            f.Show();
            f.Activate();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Nhanvien");
            if (f == null)
            {
                f = new Nhanvien();
                f.MdiParent = this;
            }
            f.Show();
            f.Activate();
        }

        private void nhomHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("NhomHang");
            if (f == null)
            {
                f = new NhomHang();
                f.MdiParent = this;
            }
            f.Show();
            f.Activate();
        }

        private void hangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("HangHoa");
            if (f == null)
            {
                f = new HangHoa();
                f.MdiParent = this;
            }
            f.Show();
            f.Activate();
        }

        private void baoCaoHangHoaTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Report_tblHanghoa");
            if (f == null)
            {
                f = new Report_tblHanghoa();
                f.MdiParent = this;
            }
            f.Show();
            f.Activate();
        }
    }
}
