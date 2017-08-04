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
    class XuLy_tblHoadonbanhang
    {
        public string connectionString = ConnectionString.getConnectionString();

        public XuLy_tblHoadonbanhang() { }

        /// <summary>
        /// Lấy danh sách Hóa đơn bán hàng theo Khóa chính
        /// </summary>
        /// <param name="PK_iHoadonbanhangID">Mã hóa đơn bán hàng</param>
        /// <returns>List<tblHoadonbanhang></returns>
        public List<tblHoadonbanhang> tblHoadonbanhang_Select(int PK_iHoadonbanhangID)
        {
            List<tblHoadonbanhang> listHoadonbanhang = new List<tblHoadonbanhang>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonbanhang_Select", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHoadonbanhangID", PK_iHoadonbanhangID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblHoadonbanhang hoadon = new tblHoadonbanhang();
                                hoadon.PK_iHoadonbanhangID = Convert.ToInt32(rd["PK_iHoadonbanhangID"].ToString());
                                hoadon.FK_iNhanvienID = Convert.ToInt32(rd["FK_iNhanvienID"].ToString());
                                hoadon.sTenKhachhang = rd["sTenKhachhang"].ToString();
                                hoadon.sDiachi = rd["sDiachi"].ToString();
                                hoadon.sSdt = rd["sSdt"].ToString();
                                hoadon.dThoigianban = Convert.ToDateTime(rd["dThoigianban"].ToString());
                                hoadon.iTongtien = Convert.ToInt32(rd["iTongtien"].ToString());
                                listHoadonbanhang.Add(hoadon);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listHoadonbanhang;
                    }
                }
            }
        }

        /// <summary>
        /// Lấy danh sách Hóa đơn bán hàng theo Khóa phụ
        /// </summary>
        /// <param name="FK_iNhanvienID">Mã nhân viên</param>
        /// <returns>List<tblHoadonbanhang></returns>
        public List<tblHoadonbanhang> tblHoadonbanhang_SelectByFK(int FK_iNhanvienID)
        {
            List<tblHoadonbanhang> listHoadonbanhang = new List<tblHoadonbanhang>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonbanhang_SelectByFK", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHoadonbanhangID", FK_iNhanvienID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblHoadonbanhang hoadon = new tblHoadonbanhang();
                                hoadon.PK_iHoadonbanhangID = Convert.ToInt32(rd["PK_iHoadonbanhangID"].ToString());
                                hoadon.FK_iNhanvienID = Convert.ToInt32(rd["FK_iNhanvienID"].ToString());
                                hoadon.sTenKhachhang = rd["sTenKhachhang"].ToString();
                                hoadon.sDiachi = rd["sDiachi"].ToString();
                                hoadon.sSdt = rd["sSdt"].ToString();
                                hoadon.dThoigianban = Convert.ToDateTime(rd["dThoigianban"].ToString());
                                hoadon.iTongtien = Convert.ToInt32(rd["iTongtien"].ToString());
                                listHoadonbanhang.Add(hoadon);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listHoadonbanhang;
                    }
                }
            }
        }

        /// <summary>
        /// Xóa Hóa đơn bán hàng theo Khóa chính
        /// </summary>
        /// <param name="PK_iHoadonbanhangID">Mã hóa đơn bán hàng</param>
        /// <returns>bool</returns>
        public bool tblHoadonbanhang_Delete(int PK_iHoadonbanhangID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonbanhang_Delete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHoadonbanhangID", PK_iHoadonbanhangID);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Xóa Hóa đơn bán hàng theo Khóa phụ
        /// </summary>
        /// <param name="FK_iNhanvienID">Mã nhân viên</param>
        /// <returns>bool</returns>
        public bool tblHoadonbanhang_DeleteByFK(int FK_iNhanvienID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonbanhang_DeleteByFK", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iNhanvienID", FK_iNhanvienID);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Thêm Hóa đơn bán hàng
        /// </summary>
        /// <param name="hoadon">tblHoadonbanhang</param>
        /// <returns>int</returns>
        public int tblHoadonbanhang_Insert(tblHoadonbanhang hoadon)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonbanhang_Insert", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@PK_iHoadonbanhangID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@FK_iNhanvienID", hoadon.FK_iNhanvienID);
                    cmd.Parameters.AddWithValue("@sTenKhachhang", hoadon.sTenKhachhang);
                    cmd.Parameters.AddWithValue("@sDiachi", hoadon.sDiachi);
                    cmd.Parameters.AddWithValue("@sSdt", hoadon.sSdt);
                    cmd.Parameters.AddWithValue("@dThoigianban", hoadon.dThoigianban);
                    cmd.Parameters.AddWithValue("@iTongtien", hoadon.iTongtien);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return Convert.ToInt32(cmd.Parameters["@PK_iHoadonbanhangID"].Value);
                }
            }
        }

        /// <summary>
        /// Cập nhật Hóa đơn bán hàng theo PK_iHoadonbanhangID
        /// </summary>
        /// <param name="hoadon">tblHoadonbanhang</param>
        /// <returns>bool</returns>
        public bool tblHoadonbanhang_Update(tblHoadonbanhang hoadon)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonbanhang_Update", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHoadonbanhangID", hoadon.PK_iHoadonbanhangID);
                    cmd.Parameters.AddWithValue("@FK_iNhanvienID", hoadon.FK_iNhanvienID);
                    cmd.Parameters.AddWithValue("@sTenKhachhang", hoadon.sTenKhachhang);
                    cmd.Parameters.AddWithValue("@sDiachi", hoadon.sDiachi);
                    cmd.Parameters.AddWithValue("@sSdt", hoadon.sSdt);
                    cmd.Parameters.AddWithValue("@dThoigianban", hoadon.dThoigianban);
                    cmd.Parameters.AddWithValue("@iTongtien", hoadon.iTongtien);
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
                string sqlSelect = "Select DISTINCT PK_iHoadonbanhangID, tblHoadonbanhang.FK_iNhanvienID, tblNhanvien.sTenNhanvien, sTenKhachhang , sDiachi, sSdt, dThoigianban, iTongtien from tblHoadonbanhang left join tblNhanvien on tblHoadonbanhang.FK_iNhanvienID = tblNhanvien.PK_iNhanvienID where " + sFilter;
                using(SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using(SqlDataAdapter da=new SqlDataAdapter(cmd))
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
