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
    public partial class NhomHang : Form
    {
        String constr = ConnectionString.getConnectionString();
        ErrorProvider error = new ErrorProvider();

        public NhomHang()
        {
            InitializeComponent();
            AcceptButton = btn_Them;
        }
        public void dataGridViewNhomHang_Load()
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
                        dataNhomHang.DataSource = tb;
                        dataNhomHang.Columns["PK_iNhomhangID"].HeaderText = "Mã Nhóm Hàng";
                        dataNhomHang.Columns["sTenNhomhang"].HeaderText = "Tên Nhóm Hàng";
                        dataNhomHang.Columns["sTenHanghoa"].HeaderText = "Tên Hàng hóa";
                        dataNhomHang.Columns["sMota"].HeaderText = "Mô Tả";
                       
                        dataNhomHang.AllowUserToResizeColumns = dataNhomHang.AllowUserToResizeRows = dataNhomHang.RowHeadersVisible = dataNhomHang.AllowUserToAddRows = false;
                        dataNhomHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            } 
        }
        // load nhóm hàng
        private void NhomHang_Load(object sender, EventArgs e)
        {
            txt_sTenNhomhang.Text = null;
            txt_sMota.Text = null;
            btn_sua.Enabled = btn_xoa.Enabled = false;
            dataGridViewNhomHang_Load();
        }
        // hàm truy vấn sang DB
        public void ThemNhomHang()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhomhang_Insert", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhomhangID","" );
                    cmd.Parameters.AddWithValue("@sTenNhomhang", txt_sTenNhomhang.Text.Trim());
                    cmd.Parameters.AddWithValue("@sMota", txt_sMota.Text.Trim());
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }
        public bool XoaNhomHang()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhomhang_Delete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhomhangID", btn_xoa.Tag);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        private bool SuaNhomHang()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhomhang_Update", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhomhangID", btn_sua.Tag);
                    cmd.Parameters.AddWithValue("@sTenNhomhang", txt_sTenNhomhang.Text.Trim());
                    cmd.Parameters.AddWithValue("@sMota", txt_sMota.Text.Trim());
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
                using (SqlCommand cmd = new SqlCommand("sp_tblNhomhang_Search", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sTenNhomhang",sFilter);
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
            if (!string.IsNullOrEmpty(txt_sTenNhomhang.Text.Trim()))
            {
                sFilter += string.Format(txt_sTenNhomhang.Text.Trim().ToString());
                dataNhomHang.DataSource = LayDanhsach(sFilter);
                txt_sTenNhomhang.Focus();
            }
        }
        // hàm clear
        public void Clear()
        {
            txt_sTenNhomhang.Clear();
            txt_sMota.Clear();
        }
        // hàm click

                // Insert
        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemNhomHang();
            dataGridViewNhomHang_Load();
            Clear();
        }
                //Delete
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (XoaNhomHang())
            {
                MessageBox.Show("Xóa thành công.");
            }
            else
            {
                MessageBox.Show("Xóa thất bại.");
            }
            NhomHang_Load(sender, e);
        }
                // Update
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (SuaNhomHang())
            {
                MessageBox.Show("Sửa thành công.");
                NhomHang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại.");
                NhomHang_Load(sender, e);
            }
        }
               // tìm kiếm //
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            Timkiem();
        }
                // đóng
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
                // làm sạch
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        // datagrindview cell click
        private void dataNhomHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sua.Enabled= btn_xoa.Enabled = true;
            btn_sua.Tag = btn_xoa.Tag = Convert.ToInt32(dataNhomHang.Rows[e.RowIndex].Cells["PK_iNhomhangID"].Value.ToString());
            txt_sTenNhomhang.Text = dataNhomHang.Rows[e.RowIndex].Cells["sTenNhomhang"].Value.ToString();
            txt_sMota.Text = dataNhomHang.Rows[e.RowIndex].Cells["sMota"].Value.ToString();
        }
        // kiểm tra tên nhóm hàng
        private void txt_sTenNhomhang_Validating(object sender, CancelEventArgs e)
        {
            string val = txt_sTenNhomhang.Text;
            if (string.IsNullOrEmpty(val))
            {
                error.SetError(txt_sTenNhomhang, "Tên nhóm hàng không được để trống!");
                btn_Them.Enabled = false;
                txt_sTenNhomhang.Focus();
            }
            else
            {
                error.Clear();
                btn_Them.Enabled = true;
            }
        }

        private void dataNhomHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    