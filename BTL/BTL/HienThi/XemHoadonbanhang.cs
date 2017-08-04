using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.ThucThe;
using BTL.XuLy;
using BTL.TaoReport;

namespace BTL.HienThi
{
    public partial class XemHoadonbanhang : Form
    {
        public static string sFilter = " 1>0 ";

        public XemHoadonbanhang()
        {
            InitializeComponent();
        }

        private void XemHoadonbanhang_Load(object sender, EventArgs e)
        {
            CancelButton = buttonBoqua;
            AcceptButton = buttonSua;
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            TimKiem();
            dataGridViewHoadonbanhang.ClearSelection();
        }

        private void TimKiem()
        {
            sFilter = " 1>0 ";
            if (!string.IsNullOrEmpty(txtHoadonbanhangID.Text.Trim()))
            {
                if (sFilter == " 1>0 ")
                {
                    sFilter = string.Format(" PK_iHoadonbanhangID = '{0}' ", txtHoadonbanhangID.Text.Trim().ToString());
                }
                else sFilter += string.Format("or PK_iHoadonbanhangID = '{0}' ", txtHoadonbanhangID.Text.Trim().ToString());
            }
                

            if (!string.IsNullOrEmpty(txtNhanvienID.Text.Trim()))
            {
                if (sFilter == " 1>0 ")
                {
                    sFilter = string.Format(" sTenKhachhang LIKE '%{0}%' ", txtTenKhachhang.Text.Trim());
                }
                else sFilter += string.Format(" or sTenKhachhang LIKE '%{0}%' ", txtTenKhachhang.Text.Trim());
            }

            if (!string.IsNullOrEmpty(txtTenKhachhang.Text.Trim()))
            {
                if (sFilter == " 1>0 ")
                {
                    sFilter = string.Format(" sTenKhachhang LIKE '%{0}%' ", txtTenKhachhang.Text.Trim());
                }
                else sFilter += string.Format(" or sTenKhachhang LIKE '%{0}%' ", txtTenKhachhang.Text.Trim());
            }

            if (!string.IsNullOrEmpty(txtTenNhanvien.Text.Trim()))
                sFilter += string.Format(" or tblNhanvien.sTenNhanvien LIKE '%{0}%' ", txtTenNhanvien.Text.Trim());

            if (!string.IsNullOrEmpty(txtDiachi.Text.Trim()))
                sFilter += string.Format(" or sDiachi LIKE '%{0}%' ", txtDiachi.Text.Trim());

            if (!string.IsNullOrEmpty(txtSdt.Text.Trim()))
                if (sFilter == " 1>0 ")
                {
                    sFilter = string.Format(" sSdt LIKE '%{0}%' ", txtSdt.Text.Trim());
                }
                else sFilter += string.Format(" or sSdt LIKE '%{0}%' ", txtSdt.Text.Trim());

            if (checkBoxNgay.Checked == true)
                sFilter += string.Format(" or dThoigianban = '{0}' ", dateThoigianban.Text.ToString());
            if (checkBoxThang.Checked == true)
                sFilter += string.Format(" or MONTH(dThoigianban) = MONTH('{0}') and YEAR(dThoigianban) = YEAR('{0}') ",
                    dateThoigianban.Text.ToString(), dateThoigianban.Text.ToString());
            if (checkBoxNam.Checked == true)
                sFilter += string.Format(" or YEAR(dThoigianban) = YEAR('{0}') ", dateThoigianban.Text.ToString());

            DataTable table = new XuLy_tblHoadonbanhang().TimKiem(sFilter);
            dataGridViewHoadonbanhang.DataSource = table;
            dataGridViewHoadonbanhang.ClearSelection();

            if (dataGridViewHoadonbanhang.Rows.Count == 1)
            {
                dataGridViewHoadonbanhang.SelectAll();
                buttonSua.Tag = buttonXoa.Tag = dataGridViewHoadonbanhang.Rows[0].Cells[0];
                buttonSua.Enabled = true;
                buttonXoa.Enabled = true;
            }
            else
            {
                dataGridViewHoadonbanhang.ClearSelection();
                buttonSua.Enabled = false;
                buttonXoa.Enabled = false;
            }
        }

        private void txtHoadonbanhangID_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtNhanvienID_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtTenKhachhang_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtTenNhanvien_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void dateThoigianban_ValueChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void checkBoxNgay_CheckedChanged(object sender, EventArgs e)
        {
            TimKiem();
            checkBoxNam.Checked = checkBoxThang.Checked = false;
        }

        private void checkBoxThang_CheckedChanged(object sender, EventArgs e)
        {
            TimKiem();
            checkBoxNam.Checked = checkBoxNgay.Checked = false;
        }

        private void checkBoxNam_CheckedChanged(object sender, EventArgs e)
        {
            TimKiem();
            checkBoxNgay.Checked = checkBoxThang.Checked = false;
        }

        private void buttonBoqua_Click(object sender, EventArgs e)
        {
            buttonSua.Enabled = buttonXoa.Enabled = false;
            txtHoadonbanhangID.Clear();
            txtNhanvienID.Clear();
            txtTenKhachhang.Clear();
            txtTenNhanvien.Clear();
            txtDiachi.Clear();
            txtSdt.Clear();
            dateThoigianban.Value = DateTime.Today;
            checkBoxNgay.Checked = checkBoxThang.Checked = checkBoxNam.Checked = false;
            sFilter = " 1>0 ";
            TimKiem();
        }

        private void dataGridViewHoadonbanhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 1)
            {
                buttonSua.Tag = buttonXoa.Tag = Convert.ToInt32(dataGridViewHoadonbanhang.Rows[e.RowIndex].Cells[0].Value.ToString());
                buttonSua.Enabled = true;
                buttonXoa.Enabled = true;
            }
        }


        private void buttonSua_Click(object sender, EventArgs e)
        {
            Form formSua = new BanHang(Convert.ToInt32(buttonSua.Tag));
            formSua.ShowDialog();
            XemHoadonbanhang_Load(sender, e);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn xóa hóa đơn! ", "Xóa hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                new XuLy_tblHangban().tblHangban_Delete(Convert.ToInt32(buttonXoa.Tag), 0);
                new XuLy_tblHoadonbanhang().tblHoadonbanhang_Delete(Convert.ToInt32(buttonXoa.Tag));
                MessageBox.Show("Xóa thành công");
            }
            XemHoadonbanhang_Load(sender, e);
        }

        private void buttonTaobaocao_Click(object sender, EventArgs e)
        {
            Report_tblHoadonbanhang report = new Report_tblHoadonbanhang(sFilter);
            report.Show();
        }

        private void dataGridViewHoadonbanhang_DoubleClick(object sender, EventArgs e)
        {
            Form formSua = new BanHang(Convert.ToInt32(buttonSua.Tag));
            formSua.ShowDialog();
            XemHoadonbanhang_Load(sender, e);
        }
    }
}
