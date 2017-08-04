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
    class XuLy_tblHoadonnhaphang
    {
        public string connectionString = ConnectionString.getConnectionString();

        public XuLy_tblHoadonnhaphang() { }

        /// <summary>
        /// Lấy danh sách Hóa đơn nhập hàng theo Khóa chính
        /// </summary>
        /// <param name="PK_iHoadonnhaphangID">Mã hóa đơn nhập hàng</param>
        /// <returns>List<tblHoadonnhaphang></returns>
        public List<tblHoadonnhaphang> tblHoadonnhaphang_Select(int PK_iHoadonnhaphangID)
        {
            List<tblHoadonnhaphang> listHoadonnhaphang = new List<tblHoadonnhaphang>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonnhaphang_Select", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHoadonnhaphangID", PK_iHoadonnhaphangID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblHoadonnhaphang hoadon = new tblHoadonnhaphang();
                                hoadon.iHoadonnhaphangID = Convert.ToInt32(rd["PK_iHoadonnhaphangID"].ToString());
                                hoadon.iNhanvienID = Convert.ToInt32(rd["FK_iNhanvienID"].ToString());
                                hoadon.dThoigiannhap = Convert.ToDateTime(rd["dThoigiannhap"].ToString());
                                hoadon.iTongtien = Convert.ToInt32(rd["iTongtien"].ToString());
                                listHoadonnhaphang.Add(hoadon);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listHoadonnhaphang;
                    }
                }
            }
        }

        /// <summary>
        /// Lấy danh sách Hóa đơn nhập hàng theo Khóa phụ
        /// </summary>
        /// <param name="FK_iNhanvienID">Mã nhân viên</param>
        /// <returns>List<tblHoadonnhaphang></returns>
        public List<tblHoadonnhaphang> tblHoadonnhaphang_SelectByFK(int FK_iNhanvienID)
        {
            List<tblHoadonnhaphang> listHoadonnhaphang = new List<tblHoadonnhaphang>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonnhaphang_SelectByFK", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHoadonnhaphangID", FK_iNhanvienID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblHoadonnhaphang hoadon = new tblHoadonnhaphang();
                                hoadon.iHoadonnhaphangID = Convert.ToInt32(rd["PK_iHoadonnhaphangID"].ToString());
                                hoadon.iNhanvienID = Convert.ToInt32(rd["FK_iNhanvienID"].ToString());
                                hoadon.dThoigiannhap = Convert.ToDateTime(rd["dThoigiannhap"].ToString());
                                hoadon.iTongtien = Convert.ToInt32(rd["iTongtien"].ToString());
                                listHoadonnhaphang.Add(hoadon);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listHoadonnhaphang;
                    }
                }
            }
        }

        /// <summary>
        /// Xóa Hóa đơn nhập hàng theo Khóa chính
        /// </summary>
        /// <param name="PK_iHoadonnhaphangID">Mã hóa đơn nhập hàng</param>
        /// <returns>bool</returns>
        public bool tblHoadonnhaphang_Delete(int PK_iHoadonnhaphangID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonnhaphang_Delete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHoadonnhaphangID", PK_iHoadonnhaphangID);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Xóa Hóa đơn nhập hàng theo Khóa phụ
        /// </summary>
        /// <param name="FK_iNhanvienID">Mã nhân viên</param>
        /// <returns>bool</returns>
        public bool tblHoadonnhaphang_DeleteByFK(int FK_iNhanvienID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonnhaphang_DeleteByFK", cnn))
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
        /// Thêm Hóa đơn nhập hàng
        /// </summary>
        /// <param name="hoadon">tblHoadonnhaphang</param>
        /// <returns>bool</returns>
        public bool tblHoadonnhaphang_Insert(tblHoadonnhaphang hoadon)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonnhaphang_Insert", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@PK_iHoadonnhaphangID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@FK_iNhanvienID", hoadon.iNhanvienID);
                    cmd.Parameters.AddWithValue("@dThoigiannhap", hoadon.dThoigiannhap);
                    cmd.Parameters.AddWithValue("@iTongtien", hoadon.iTongtien);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return Convert.ToInt32(cmd.Parameters["@PK_iHoadonnhaphangID"].Value) > 0;
                }
            }
        }

        /// <summary>
        /// Cập nhật Hóa đơn nhập hàng theo PK_iHoadonnhaphangID
        /// </summary>
        /// <param name="hoadon">tblHoadonnhaphang</param>
        /// <returns>bool</returns>
        public bool tblHoadonnhaphang_Update(tblHoadonnhaphang hoadon)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHoadonnhaphang_Update", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHoadonnhaphangID", hoadon.iHoadonnhaphangID);
                    cmd.Parameters.AddWithValue("@FK_iNhanvienID", hoadon.iNhanvienID);
                    cmd.Parameters.AddWithValue("@dThoigiannhap", hoadon.dThoigiannhap);
                    cmd.Parameters.AddWithValue("@iTongtien", hoadon.iTongtien);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
    }
}
