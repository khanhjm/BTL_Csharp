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
    class XuLy_tblNhomhang
    {
        public string connectionString = ConnectionString.getConnectionString();

        public XuLy_tblNhomhang() { }

        /// <summary>
        /// Lấy danh sách Nhóm hàng
        /// </summary>
        /// <param name="PK_iNhomhangID">Mã nhóm hàng</param>
        /// <returns>List<tblHanghoa></returns>
        public List<tblNhomhang> tblNhomhang_Select(int PK_iNhomhangID)
        {
            List<tblNhomhang> listNhomhang = new List<tblNhomhang>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhomhang_Select", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhomhangID", PK_iNhomhangID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblNhomhang nhomhang = new tblNhomhang();
                                nhomhang.iNhomhangID = Convert.ToInt32(rd["PK_iNhomhangID"].ToString());
                                nhomhang.sTenNhomhang = rd["sTenNhomhang"].ToString();
                                nhomhang.sMota = rd["sMota"].ToString();
                                listNhomhang.Add(nhomhang);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listNhomhang;
                    }
                }
            }
        }

        /// <summary>
        /// Xóa Nhóm hàng
        /// </summary>
        /// <param name="PK_iNhomhangID">Mã Nhómn hàng</param>
        /// <returns>bool</returns>
        public bool tblNhomhang_Delete(int PK_iNhomhangID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhomhang_Delete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhomhangID", PK_iNhomhangID);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Thêm Nhóm hàng
        /// </summary>
        /// <param name="nhomhang">tblNhomhang</param>
        /// <returns>bool</returns>
        public bool tblNhomhang_Insert(tblNhomhang nhomhang)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhomhang_Insert", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhomhangID", nhomhang.iNhomhangID);
                    cmd.Parameters.AddWithValue("@sTenNhomhang", nhomhang.sTenNhomhang);
                    cmd.Parameters.AddWithValue("@sMota", nhomhang.sMota);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Cập nhật Hàng hóa trong Kho
        /// </summary>
        /// <param name="nhomhang">tblNhomhang</param>
        /// <returns>bool</returns>
        public bool tblNhomhang_Update(tblNhomhang nhomhang)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblNhomhang_Update", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iNhomhangID", nhomhang.iNhomhangID);
                    cmd.Parameters.AddWithValue("@sTenNhomhang", nhomhang.sTenNhomhang);
                    cmd.Parameters.AddWithValue("@sMota", nhomhang.sMota);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
    }
}
