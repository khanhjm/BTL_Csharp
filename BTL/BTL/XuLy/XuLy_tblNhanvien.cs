using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BTL.ThucThe;

namespace BTL.XuLy
{
    class XuLy_tblNhanvien
    {
        public string connectionString = ConnectionString.getConnectionString();

        public XuLy_tblNhanvien() { }
        
        /// <summary>
        /// Lấy danh sách Nhân viên
        /// </summary>
        /// <param name="iNhanvienID">Mã nhân viên</param>
        /// <returns>List<tblNhanvien></returns>
        public List<tblNhanvien> tblNhanvien_Select(int iNhanvienID)
        {
            List<tblNhanvien> listNhanvien = new List<tblNhanvien>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhanvien_Select", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhanvienID", iNhanvienID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblNhanvien nhanvien = new tblNhanvien();
                                nhanvien.iNhanvienID = Convert.ToInt32(rd["PK_iNhanvienID"].ToString());
                                nhanvien.sTenNhanvien = rd["sTenNhanvien"].ToString();
                                nhanvien.dNgaysinh = Convert.ToDateTime(rd["dNgaysinh"].ToString());
                                nhanvien.sGioitinh = rd["bGioitinh"].ToString();
                                nhanvien.sChucvu = rd["sChucvu"].ToString();
                                nhanvien.sUserNV = rd["sUserNV"].ToString();
                                nhanvien.sPassNV = rd["sPassNV"].ToString();
                                listNhanvien.Add(nhanvien);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listNhanvien;
                    }
                }
            }
        }

        /// <summary>
        /// Lấy thông tin đăng nhập
        /// </summary>
        /// <param name="sUserNV">Tên đăng nhập</param>
        /// <param name="sPassNV">Mật khẩu</param>
        /// <returns>iNhanvienID</returns>
        public int tblNhanvien_Login(string sUserNV, string sPassNV)
        {
            List<tblHanghoa> listKho = new List<tblHanghoa>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhanvien_Login", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sUserNV", sUserNV);
                    cmd.Parameters.AddWithValue("@sPassNV", sPassNV);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                return Convert.ToInt32(rd["PK_iNhanvienID"].ToString());
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return 0;
                    }
                }
            }
        }

        /// <summary>
        /// Xóa Nhân viên
        /// </summary>
        /// <param name="PK_iNhanvienID">Mã Nhân viên</param>
        /// <returns>bool</returns>
        public bool tblNhanvien_Delete(int PK_iNhanvienID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhanvien_Delete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhanvienID", PK_iNhanvienID);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Thêm Nhân viên
        /// </summary>
        /// <param name="hanghoa">tblHanghoa</param>
        /// <returns>bool</returns>
        public bool tblNhanvien_Insert(tblNhanvien nhanvien)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhanvien_Insert", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@PK_iNhanvienID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@sTenNhanvien", nhanvien.sTenNhanvien);
                    cmd.Parameters.AddWithValue("@dNgaysinh", nhanvien.dNgaysinh);
                    cmd.Parameters.AddWithValue("@bGioitinh", nhanvien.sGioitinh=="Nam"?"true":"false");
                    cmd.Parameters.AddWithValue("@sChucvu", nhanvien.sChucvu);
                    cmd.Parameters.AddWithValue("@sUserNV", nhanvien.sUserNV);
                    cmd.Parameters.AddWithValue("@sPassNV", nhanvien.sPassNV);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Cập nhật thông tin Nhân viên
        /// </summary>
        /// <param name="hanghoa">tblHanghoa</param>
        /// <returns></returns>
        public bool tblNhanvien_Update(tblNhanvien nhanvien)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhanvien_Update", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhanvienID", nhanvien.iNhanvienID);
                    cmd.Parameters.AddWithValue("@sTenNhanvien", nhanvien.sTenNhanvien);
                    cmd.Parameters.AddWithValue("@dNgaysinh", nhanvien.dNgaysinh);
                    cmd.Parameters.AddWithValue("@bGioitinh", nhanvien.sGioitinh == "Nam" ? "true" : "false");
                    cmd.Parameters.AddWithValue("@sChucvu", nhanvien.sChucvu);
                    cmd.Parameters.AddWithValue("@sUserNV", nhanvien.sUserNV);
                    cmd.Parameters.AddWithValue("@sPassNV", nhanvien.sPassNV);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Tìm kiếm theo điều kiện sFilter
        /// </summary>
        /// <param name="sFilter">điều kiện</param>
        /// <returns>DataTable</returns>
        public DataTable TimKiem(string sFilter)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sqlSelect = "Select PK_iNhanvienID, sTenNhanvien, dNgaysinh, case bGioitinh when 'true' then 'true' when 'false' then N'false' end as bGioitinh, sChucvu, sUserNV, sPassNV from tblNhanvien where " + sFilter;
                using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable t = new DataTable();
                        da.Fill(t);
                        cnn.Close();
                        return t;
                    }
                }
            }
        }


    }
}
