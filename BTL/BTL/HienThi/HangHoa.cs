using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BTL.HienThi
{
    public partial class HangHoa : Form
    {
        String constr = ConnectionString.getConnectionString();
        ErrorProvider error = new ErrorProvider();
        public HangHoa()
        {
            InitializeComponent();
        }
        public void dataHangHoa_Load()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select_tblHanghoa", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        cnn.Close();
                        dataHangHoa.DataSource = tb;
                        dataHangHoa.Columns["PK_iHanghoaID"].HeaderText = "Mã Hàng Hóa";
                        dataHangHoa.Columns["sTenHanghoa"].HeaderText = "Tên Hàng Hóa";
                        dataHangHoa.Columns["sNhacungcap"].HeaderText = "Nhà Cung Cấp";
                        dataHangHoa.Columns["sTenNhomhang"].HeaderText = "Nhóm Hàng";
                        dataHangHoa.Columns["iSoluong"].HeaderText = "Số Lượng";
                        dataHangHoa.Columns["iDongia"].HeaderText = "Đồng Giá";
                        dataHangHoa.Columns["iThoigianbaohanh"].HeaderText = "Bảo Hành ( số tháng) ";
                        dataHangHoa.AllowUserToResizeColumns = dataHangHoa.AllowUserToResizeRows = dataHangHoa.RowHeadersVisible = dataHangHoa.AllowUserToAddRows = false;
                        //dataHangHoa.AutoResizeRow;
                        dataHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }
        public void TenNhomHang_load()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select_NhomHang", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        cnn.Close();
                        cb_NhomHang.DataSource = tb;
                        cb_NhomHang.DisplayMember = "sTenNhomhang";
                        cb_NhomHang.ValueMember = "PK_iNhomhangID";
                    }
                }
            }
        }
        // load hàng hóa
        private void HangHoa_Load(object sender, EventArgs e)
        {
            //txt_sTenNhomhang.Text = null;
            //txt_sMota.Text = null;
            btn_Sua.Enabled = btn_Xoa.Enabled = false;
            dataHangHoa_Load();
            TenNhomHang_load();
        }
        // hàm clear
        public void Clear()
        {
            txt_TenHangHoa.Clear();
            txt_NhaCC.Clear();
            txt_SoLuong.Clear();
            txt_DonGia.Clear();
            txt_BaoHanh.Clear();
        }
        // hàm truy vấn sang DB
        public void ThemHangHoa()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_Insert", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHanghoaID", "");
                    cmd.Parameters.AddWithValue("@FK_iNhomhangID", Convert.ToInt32(cb_NhomHang.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@sTenHanghoa", txt_TenHangHoa.Text.Trim());
                    cmd.Parameters.AddWithValue("@sNhacungcap", txt_NhaCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@iSoluong", Convert.ToInt32(txt_SoLuong.Text.Trim().ToString()));
                    cmd.Parameters.AddWithValue("@iDongia", Convert.ToInt32(txt_DonGia.Text.Trim().ToString()));
                    cmd.Parameters.AddWithValue("@iThoigianbaohanh", Convert.ToInt32(txt_BaoHanh.Text.Trim().ToString()));
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }
        public bool XoaHangHoa()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_Delete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHanghoaID", btn_Xoa.Tag);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        private bool SuaHangHoa()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_Update", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHanghoaID", btn_Sua.Tag);
                    cmd.Parameters.AddWithValue("@sTenHanghoa", txt_TenHangHoa.Text.Trim());
                    cmd.Parameters.AddWithValue("@sNhacungcap", txt_NhaCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@iSoluong", Convert.ToInt32(txt_SoLuong.Text.Trim().ToString()));
                    cmd.Parameters.AddWithValue("@iDongia", Convert.ToInt32(txt_DonGia.Text.Trim().ToString()));
                    cmd.Parameters.AddWithValue("@iThoigianbaohanh", Convert.ToInt32(txt_BaoHanh.Text.Trim().ToString()));
                    cmd.Parameters.AddWithValue("@FK_iNhomhangID", cb_NhomHang.SelectedValue.ToString());
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private DataTable LayDanhsach(string sFilter)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_Search", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sTenHanghoa", sFilter);
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        cnn.Close();
                        return tb;
                    }
                }
            }
        }
        private DataTable LayDanhsachNhaCC(string sNhacc)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Search_NhaCC_tblHangHoa", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sNhacungcap", sNhacc);
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        cnn.Close();
                        return tb;
                    }
                }
            }
        }
        // tìm kiếm //
        private void Timkiem()
        {
            string sFilter = "";
            if (!string.IsNullOrEmpty(txt_TenHangHoa.Text.Trim()))
            {
                sFilter += string.Format(txt_TenHangHoa.Text.Trim().ToString());
                dataHangHoa.DataSource = LayDanhsach(sFilter);
                txt_TenHangHoa.Focus();
            }
            String sNhacc = "";
            if (!string.IsNullOrEmpty(txt_NhaCC.Text.Trim()))
            {
                sNhacc += string.Format(txt_NhaCC.Text.Trim().ToString());
                dataHangHoa.DataSource = LayDanhsachNhaCC(sNhacc);
                txt_NhaCC.Focus();
            }
        }
        // hàm click
        // Insert ///
        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemHangHoa();
            dataHangHoa_Load();
            Clear();
        }
        // Delete //
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (XoaHangHoa())
            {
                MessageBox.Show("Xóa thành công.");
            }
            else
            {
                MessageBox.Show("Xóa thất bại.");
            }
            HangHoa_Load(sender, e);
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (SuaHangHoa())
            {
                MessageBox.Show("Sửa thành công.");
                HangHoa_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại.");
                HangHoa_Load(sender, e);
            }
        }
        // tìm kiếm //
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            Timkiem();
        }
        // datagrindview cell click ///
        private void dataHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Sua.Enabled = btn_Xoa.Enabled = true;
            btn_Sua.Tag = btn_Xoa.Tag = Convert.ToInt32(dataHangHoa.Rows[e.RowIndex].Cells["PK_iHanghoaID"].Value.ToString());
            txt_TenHangHoa.Text = dataHangHoa.Rows[e.RowIndex].Cells["sTenHanghoa"].Value.ToString();
            txt_NhaCC.Text = dataHangHoa.Rows[e.RowIndex].Cells["sNhacungcap"].Value.ToString();
            txt_SoLuong.Text = dataHangHoa.Rows[e.RowIndex].Cells["iSoluong"].Value.ToString();
            txt_DonGia.Text = dataHangHoa.Rows[e.RowIndex].Cells["iDongia"].Value.ToString();
            txt_BaoHanh.Text = dataHangHoa.Rows[e.RowIndex].Cells["iThoigianbaohanh"].Value.ToString();
            cb_NhomHang.Text = dataHangHoa.Rows[e.RowIndex].Cells["sTenNhomhang"].Value.ToString();
        }
        // Thoát //
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        // làm sạch //
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // kiểm tra tên nhóm hàng ///
        //private void txt_TenHangHoa_Validating(object sender, CancelEventArgs e)
        //{
        //    string val = txt_TenHangHoa.Text;
        //    if (string.IsNullOrEmpty(val))
        //    {
        //        error.SetError(txt_TenHangHoa, "Tên hàng hóa không được để trống!");
        //        btn_Them.Enabled = false;
        //        txt_TenHangHoa.Focus();
        //    }
        //    else
        //    {
        //        error.Clear();
        //        btn_Them.Enabled = true;
        //    }
        //}



    }
}
