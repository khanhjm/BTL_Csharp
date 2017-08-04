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
    public partial class BanHang : Form
    {
        private bool clicked = false;
        private int Mahoadon = 0;
        private DataTable table = new DataTable();
        private string sFilter = " 1>0 ";

        private List<tblHanghoa> hanghoa = new List<tblHanghoa>();

        public BanHang()
        {
            InitializeComponent();
            labelHoadonbanhangID.Visible = txtHoadonbanhangID.Visible = false;
            dateThoigianban.Enabled = false;
            try
            {
                table = new XuLy_tblHangban().TimKiem(sFilter + " and FK_iHoadonbanhangID = (select top 1 FK_iHoadonbanhangID from tblHangban order by FK_iHoadonbanhangID desc) + 1");
            }
            catch
            {
                table = new XuLy_tblHangban().TimKiem(sFilter + " and FK_iHoadonbanhangID = 1");
            }
            buttonTao.Text = "Tạo";
        }

        public BanHang(int HoadonbanhangID)
        {
            InitializeComponent();
            labelHoadonbanhangID.Visible = txtHoadonbanhangID.Visible = true;
            dateThoigianban.Enabled = true;
            Mahoadon = HoadonbanhangID;

            txtHoadonbanhangID.Text = Mahoadon.ToString();
            tblHoadonbanhang hoadon = new XuLy_tblHoadonbanhang().tblHoadonbanhang_Select(Mahoadon)[0];
            txtNhanvienID.Text = hoadon.FK_iNhanvienID.ToString();
            txtTenKhachhang.Text = hoadon.sTenKhachhang;
            txtDiachi.Text = hoadon.sDiachi;
            txtSdt.Text = hoadon.sSdt;
            dateThoigianban.Value = hoadon.dThoigianban;
            txtTongtien.Text = hoadon.iTongtien.ToString();

            sFilter += string.Format(" and tblHangban.FK_iHoadonbanhangID = '{0}' ", Mahoadon.ToString());
            table = new XuLy_tblHangban().TimKiem(sFilter);
            dataGridViewtblHangban.DataSource = table;
            dataGridViewtblHangban.ClearSelection();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            buttonMua.Enabled = buttonXoa.Enabled = false;
            buttonMua.Tag = null;
            if (Mahoadon == 0)
            {
                if (buttonMua.Enabled == true)
                    AcceptButton = buttonMua;
                else
                {
                    if (buttonTao.Enabled == true)
                    {
                        AcceptButton = buttonTao;
                    }
                }
                Clear();
            }
            else
            {
                buttonTao.Text = "Sửa";
                CancelButton = buttonBoqua;
                buttonTao_Enable();
            }
        }

        private void dataGridViewtblHangban_Load()
        {
            dataGridViewtblHangban.ClearSelection();
            foreach (DataRow r in table.Rows)
            {
                txtTongtien.Text = Convert.ToInt32(r["iThanhtien"].ToString()).ToString();
            }
        }

        private void txtHanghoaID_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHanghoaID.Text.Trim()))
            {
                if (string.IsNullOrEmpty(txtTenHanghoa.Text.Trim()))
                {
                    errorProviderHanghoaID.SetError(txtHanghoaID, "Mã hàng hóa không tồn tại!");
                    e.Cancel = true;
                    txtHanghoaID.Focus();
                }
                else
                {
                    errorProviderHanghoaID.Clear();
                }
            }
        }

        private void txtHanghoaID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHanghoaID.Text.Trim()))
            {
                hanghoa = new XuLy_tblHanghoa().tblHanghoa_Select(Convert.ToInt32(txtHanghoaID.Text.ToString()));
                if (hanghoa.Count == 1)
                {
                    txtTenHanghoa.Text = hanghoa[0].sTenHanghoa;
                    txtNhacungcap.Text = hanghoa[0].sNhacungcap;
                    txtDongia.Text = hanghoa[0].iDongia.ToString();
                    txtThoigianbaohanh.Text = hanghoa[0].iThoigianbaohanh.ToString();
                    txtThanhtien.Text = "0";
                    txtSoluongban.Enabled = true;
                }
                else
                {
                    Clear();
                }
            }
            else
            {
                Clear();
            }
            KiemTraMatHang();
        }

        private void txtSoluongban_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSoluongban.Text.Trim()))
                txtThanhtien.Text = (Convert.ToInt32(txtDongia.Text.Trim()) * Convert.ToInt32(txtSoluongban.Text.Trim())).ToString();
            else
                txtThanhtien.Text = "0";
            KiemTraMatHang();
        }

        private void txtSoluongban_Validating(object sender, CancelEventArgs e)
        {
            //hanghoa = new XuLy_tblHanghoa().tblHanghoa_Select(Convert.ToInt32(txtHanghoaID.Text.Trim().ToString()));
            if (!string.IsNullOrEmpty(txtSoluongban.Text.Trim()))
            {
                if (Convert.ToInt32(txtSoluongban.Text.Trim()) > hanghoa[0].iSoluong)
                {
                    errorProviderSoluongban.SetError(txtSoluongban, "Số lượng hàng không đủ!");
                    e.Cancel = true;
                    txtSoluongban.Focus();
                }
                else
                {
                    errorProviderSoluongban.Clear();
                }
            }
        }

        private void txtNhanvienID_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNhanvienID.Text.Trim()))
            {
                if (string.IsNullOrEmpty(txtTenNhanvien.Text.Trim()))
                {
                    errorProviderNhanvienID.SetError(txtNhanvienID, "Mã nhân viên không tồn tại!");
                    e.Cancel = true;
                    txtNhanvienID.Focus();
                }
                else
                {
                    errorProviderNhanvienID.Clear();
                }
            }
        }

        private void txtNhanvienID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNhanvienID.Text.Trim()))
            {
                List<tblNhanvien> nhanvien = new XuLy_tblNhanvien().tblNhanvien_Select(Convert.ToInt32(txtNhanvienID.Text.ToString()));
                if (nhanvien.Count == 1)
                {
                    txtTenNhanvien.Text = nhanvien[0].sTenNhanvien;
                }
                else
                {
                    txtTenNhanvien.Clear();
                }
            }
            else
            {
                txtTenNhanvien.Clear();
            }
            buttonTao_Enable();
        }

        private void buttonTao_Enable()
        {
            buttonTao.Enabled = txtNhanvienID.Text.Trim().ToString().Length > 0
                && txtTenNhanvien.Text.Trim().Length > 0
                && txtTenKhachhang.Text.Trim().ToString().Length > 0
                && txtTongtien.Text.Trim().ToString().Length > 0;
            if (buttonTao.Enabled == true) AcceptButton = buttonTao;
            else AcceptButton = null;
        }

        private void buttonMua_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtSoluongban.Text.Trim()))
            //{
            //    if (Convert.ToInt32(txtSoluongban.Text.Trim()) > hanghoa[0].iSoluong)
            //    {
            //        MessageBox.Show("Kho không đủ hàng! Chỉ còn: " + hanghoa[0].iSoluong);
            //        return;
            //    }
            //    else
            //    {
            //        errorProviderSoluongban.Clear();
            //    }
            //}

            int kiemtramuahang = 0;
            DataRow dataRow = table.NewRow();

            tblHanghoa hb = new tblHanghoa();
            hb = hanghoa[0]; // lấy thông tin hàng hóa vừa nhập

            dataRow["iHanghoaID"] = hb.iHanghoaID;
            dataRow["iNhomhangID"] = hb.iNhomhangID;
            dataRow["sTenNhomhang"] = new XuLy_tblNhomhang().tblNhomhang_Select(hb.iNhomhangID)[0].sTenNhomhang;
            dataRow["sTenHanghoa"] = hb.sTenHanghoa;
            dataRow["sNhacungcap"] = hb.sNhacungcap;
            dataRow["iThoigianbaohanh"] = hb.iThoigianbaohanh;
            dataRow["iDongia"] = hb.iDongia;
            dataRow["iSoluongban"] = txtSoluongban.Text.Trim();
            dataRow["iThanhtien"] = (Convert.ToInt32(dataRow["iDongia"]) * Convert.ToInt32(dataRow["iSoluongban"])).ToString();

            //foreach (DataRow r in table.Rows)
            //{
            //    if (Convert.ToInt32(r["iHanghoaID"]) == hb.iHanghoaID)
            //    {
            //        r["iSoluongban"] = Convert.ToInt32(r["iSoluongban"]) + Convert.ToInt32(txtSoluongban.Text.Trim());
            //        r["iThanhtien"] = Convert.ToInt32(r["iDongia"]) * Convert.ToInt32(r["iSoluongban"]);
            //        kiemtramuahang++;
            //    }
            //}

            if (kiemtramuahang == 0)
                table.Rows.Add(dataRow);
            dataGridViewtblHangban.DataSource = table;

            TinhTongtien();
            txtHanghoaID.Clear();
            txtSoluongban.Clear();

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
                            table.Rows.Remove(r);
                        dataGridViewtblHangban.DataSource = table;
                        buttonXoa.Enabled = false;
                        return;
                    }
                }
            }
            TinhTongtien();
        }

        private void TinhTongtien()
        {
            int Tong = 0;
            foreach (DataRow r in table.Rows)
            {
                Tong += Convert.ToInt32(r["iThanhtien"]);
            }
            txtTongtien.Text = Tong.ToString();
            buttonTao_Enable();
        }

        private void dataGridViewtblHangban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewtblHangban.Rows.Count > 0)
                buttonMua.Tag = buttonXoa.Tag = Convert.ToInt32(dataGridViewtblHangban.Rows[e.RowIndex].Cells[0].Value.ToString());
            buttonXoa.Enabled = true;
        }

        private void KiemTraMatHang()
        {
            if (txtThanhtien.Text.Trim().Equals("0") || string.IsNullOrEmpty(txtThanhtien.Text.Trim()))
                buttonMua.Enabled = false;
            else
                buttonMua.Enabled = true;

            if (clicked == true)
                buttonXoa.Enabled = true;
            else buttonXoa.Enabled = false;
        }

        private void buttonBoqua_Click(object sender, EventArgs e)
        {
            Clear();
            txtHoadonbanhangID.Clear();
            txtNhanvienID.Clear();
            txtTenKhachhang.Clear();
            txtSdt.Clear();
            txtDiachi.Clear();
            txtTongtien.Clear();
            dateThoigianban.Value = DateTime.Today;
            table.Rows.Clear();
        }

        private void Clear()
        {
            sFilter = " 1>0 ";
            txtNhacungcap.Clear();
            txtTenHanghoa.Clear();
            txtThoigianbaohanh.Clear();
            txtDongia.Clear();
            txtSoluongban.Clear();
            txtThanhtien.Clear();
            txtSoluongban.Enabled = false;
        }

        private void buttonTao_Click(object sender, EventArgs e)
        {
            tblHoadonbanhang hoadonban = new tblHoadonbanhang();
            hoadonban.FK_iNhanvienID = Convert.ToInt32(txtNhanvienID.Text.Trim());
            hoadonban.sTenKhachhang = txtTenKhachhang.Text.Trim();
            hoadonban.sDiachi = txtDiachi.Text.Trim();
            hoadonban.sSdt = txtSdt.Text.Trim();
            hoadonban.dThoigianban = DateTime.Today;
            hoadonban.iTongtien = Convert.ToInt32(txtTongtien.Text.Trim());

            if (Mahoadon == 0)
            {
                hoadonban.PK_iHoadonbanhangID = new XuLy_tblHoadonbanhang().tblHoadonbanhang_Insert(hoadonban);
                foreach (DataRow r in table.Rows)
                {
                    tblHangban h = new tblHangban();
                    h.iHoadonbanhangID = hoadonban.PK_iHoadonbanhangID;
                    h.iHanghoaID = Convert.ToInt32(r["iHanghoaID"]);
                    h.iSoluongban = Convert.ToInt32(r["iSoluongban"]);
                    h.iGiaban = Convert.ToInt32(r["iDongia"]);
                    h.iThanhtien = Convert.ToInt32(r["iThanhtien"]);
                    new XuLy_tblHangban().tblHangban_Insert(h);
                }
                MessageBox.Show("Tạo thành công!");
            }
            else
            {
                hoadonban.PK_iHoadonbanhangID = Mahoadon;
                new XuLy_tblHoadonbanhang().tblHoadonbanhang_Update(hoadonban);

                List<tblHangban> listHangban = new XuLy_tblHangban().tblHangban_Select(Mahoadon, 0);
                foreach (tblHangban hb in listHangban)
                {
                    new XuLy_tblHangban().tblHangban_Delete(Mahoadon, hb.iHanghoaID);
                }
                //new XuLy_tblHangban().tblHangban_Delete(hoadonban.PK_iHoadonbanhangID, 0);
                foreach (DataRow r in table.Rows)
                {
                    tblHangban h = new tblHangban();
                    h.iHoadonbanhangID = hoadonban.PK_iHoadonbanhangID;
                    h.iHanghoaID = Convert.ToInt32(r["iHanghoaID"]);
                    h.iSoluongban = Convert.ToInt32(r["iSoluongban"]);
                    h.iGiaban = Convert.ToInt32(r["iDongia"]);
                    h.iThanhtien = Convert.ToInt32(r["iThanhtien"]);
                    new XuLy_tblHangban().tblHangban_Insert(h);
                }
                MessageBox.Show("Sửa thành công.");
                this.Close();
            }
            buttonBoqua_Click(sender, e);
        }
    }
}
