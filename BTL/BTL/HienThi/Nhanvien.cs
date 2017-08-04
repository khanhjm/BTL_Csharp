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

namespace BTL.HienThi
{
    public partial class Nhanvien : Form
    {
        private DataTable table = new DataTable();
        private string sFilter;

        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            dataGridViewtblNhanvien.ClearSelection();
            buttonSua.Enabled = buttonXoa.Enabled = false;
            table = new XuLy_tblNhanvien().TimKiem(" 1>0 ");
            dataGridViewtblNhanvien.DataSource = table;
            dataGridViewtblNhanvien.ClearSelection();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            tblNhanvien nv = new tblNhanvien();
            nv.sTenNhanvien = txtTenNhanvien.Text.ToString();
            nv.sGioitinh = radioNam.Checked == true ? "Nam" : "Nữ";
            nv.dNgaysinh = dateNgaysinh.Value;
            nv.sChucvu = txtChucvu.Text.ToString();
            nv.sUserNV = txtUserNV.Text.ToString();
            nv.sPassNV = txtPassNV.Text.ToString();
            bool i;
            if (nhaplaipass.Text.ToString().Trim() == nv.sPassNV)
            {
                i = new XuLy_tblNhanvien().tblNhanvien_Insert(nv);
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu sai.");
                return;
            }
            if (i == true)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            buttonBoqua_Click(sender, e);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            tblNhanvien nv = new tblNhanvien();
            nv.iNhanvienID = Convert.ToInt32(buttonSua.Tag);
            nv.sTenNhanvien = txtTenNhanvien.Text.ToString();
            nv.sGioitinh = radioNam.Checked == true ? "Nam" : "Nữ";
            nv.dNgaysinh = dateNgaysinh.Value;
            nv.sChucvu = txtChucvu.Text.ToString();
            nv.sUserNV = txtUserNV.Text.ToString();
            nv.sPassNV = txtPassNV.Text.ToString();
            bool i = new XuLy_tblNhanvien().tblNhanvien_Update(nv);
            if (i == true)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            buttonBoqua_Click(sender, e);
        }

        private void buttonBoqua_Click(object sender, EventArgs e)
        {
            txtTenNhanvien.Text = txtChucvu.Text = txtUserNV.Text = txtPassNV.Text = null;
            dateNgaysinh.Value = DateTime.Today;
            buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonSua.Tag = buttonXoa.Tag = null;
            Nhanvien_Load(sender,e);
            dataGridViewtblNhanvien.ClearSelection();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count != 0)
            {
                foreach (DataRow r in table.Rows)
                {
                    if (Convert.ToInt32(r[0]) == Convert.ToInt32(buttonXoa.Tag))
                    {
                        DialogResult dialog = MessageBox.Show("Bạn có chắc chắn xóa mặt hàng!", "Xóa hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            bool i = new XuLy_tblNhanvien().tblNhanvien_Delete(Convert.ToInt32(buttonXoa.Tag));
                            if (i == true)
                                MessageBox.Show("Xóa thành công");
                            else
                                MessageBox.Show("Xóa thất bại");
                            buttonBoqua_Click(sender, e);
                        }
                    }
                }
            }

        }

        private void dataGridViewtblNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewtblNhanvien.Rows.Count > 0)
                buttonXoa.Tag = buttonSua.Tag = Convert.ToInt32(dataGridViewtblNhanvien.Rows[e.RowIndex].Cells["iNhanvienID"].Value.ToString());
            buttonSua.Enabled = buttonXoa.Enabled = true;
            txtTenNhanvien.Text = dataGridViewtblNhanvien.Rows[e.RowIndex].Cells["sTenNhanvien"].Value.ToString();
            dateNgaysinh.Value = Convert.ToDateTime(dataGridViewtblNhanvien.Rows[e.RowIndex].Cells["dNgaysinh"].Value.ToString());
            if (dataGridViewtblNhanvien.Rows[e.RowIndex].Cells["bGioitinh"].Equals("Nam"))
                radioNam.Checked = true;
            else
                radioNu.Checked = false;
            txtChucvu.Text = dataGridViewtblNhanvien.Rows[e.RowIndex].Cells["sChucvu"].Value.ToString();
            txtUserNV.Text = dataGridViewtblNhanvien.Rows[e.RowIndex].Cells["sUserNV"].Value.ToString();
            txtPassNV.Text = nhaplaipass.Text = dataGridViewtblNhanvien.Rows[e.RowIndex].Cells["sPassNV"].Value.ToString();

        }

        private void buttonThem_Enable()
        {
            buttonThem.Enabled = txtTenNhanvien.Text.ToString().Length > 0
                && txtChucvu.Text.ToString().Length > 0
                && txtUserNV.Text.ToString().Length > 0
                && txtPassNV.Text.ToString().Length > 0;
            AcceptButton = buttonThem;
        }

        private void txtTenNhanvien_TextChanged(object sender, EventArgs e)
        {
            buttonThem_Enable();
        }

        private void txtChucvu_TextChanged(object sender, EventArgs e)
        {
            buttonThem_Enable();
        }

        private void txtUserNV_TextChanged(object sender, EventArgs e)
        {
            buttonThem_Enable();
        }

        private void txtPassNV_TextChanged(object sender, EventArgs e)
        {
            buttonThem_Enable();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            sFilter = " 1>0 ";
            if (!string.IsNullOrEmpty(txtTenNhanvien.Text.Trim()))
                sFilter += string.Format("and sTenNhanvien LIKE '%{0}%' ", txtTenNhanvien.Text.Trim().ToString());
            if (!string.IsNullOrEmpty(txtChucvu.Text.Trim()))
                sFilter += string.Format(" and sChucvu LIKE '%{0}%' ", txtChucvu.Text.Trim());
            if (!string.IsNullOrEmpty(txtUserNV.Text.Trim()))
                sFilter += string.Format(" and sUserNV LIKE '%{0}%' ", txtUserNV.Text.Trim());
            if (!string.IsNullOrEmpty(txtPassNV.Text.Trim()))
                sFilter += string.Format(" and sPassNV LIKE '%{0}%' ", txtPassNV.Text.Trim());
            //if (radioNam.Checked == true)
            //    sFilter += string.Format(" and bGioitinh = '{0}' ", "true");
            //else
            //    sFilter += string.Format(" and bGioitinh = '{0}' ", "false");

            table = new XuLy_tblNhanvien().TimKiem(sFilter);
            dataGridViewtblNhanvien.DataSource = table;
            dataGridViewtblNhanvien.ClearSelection();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
