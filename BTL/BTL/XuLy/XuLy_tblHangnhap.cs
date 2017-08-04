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
    class XuLy_tblHangnhap
    {
        public string connectionString = ConnectionString.getConnectionString();

        public XuLy_tblHangnhap() { }

        /// <summary>
        /// Lấy danh sách Hàng nhập
        /// </summary>
        /// <param name="FK_iHoadonnhaphangID">Mã hóa đơn nhập hàng</param>
        /// <param name="FK_iHanghoaID">Mã Nhóm hàng</param>
        /// <returns>List<tblHangnhap></returns>
        public List<tblHangnhap> tblHangnhap_Select(int FK_iHoadonnhaphangID, int FK_iHanghoaID)
        {
            List<tblHangnhap> listHangnhap = new List<tblHangnhap>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHangnhap_Select", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iHoadonnhaphangID", FK_iHoadonnhaphangID);
                    cmd.Parameters.AddWithValue("@FK_iHanghoaID", FK_iHanghoaID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblHangnhap hangnhap = new tblHangnhap();
                                hangnhap.iHoadonnhaphangID = Convert.ToInt32(rd["FK_iHoadonnhaphangID"].ToString());
                                hangnhap.iHanghoaID = Convert.ToInt32(rd["FK_iHanghoaID"].ToString());
                                hangnhap.iSoluongnhap = Convert.ToInt32(rd["iSoluongnhap"].ToString());
                                hangnhap.iGianhap = Convert.ToInt32(rd["iGianhap"].ToString());
                                hangnhap.iThanhtien = Convert.ToInt32(rd["iThanhtien"].ToString());
                                listHangnhap.Add(hangnhap);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listHangnhap;
                    }
                }
            }
        }

        /// <summary>
        /// Xóa Hàng bán
        /// </summary>
        /// <param name="FK_iHoadonnhaphangID">Mã Hóa đơn bán hàng</param>
        /// <param name="FK_iNhomhangID">Mã Nhóm hàng</param>
        /// <returns>bool</returns>
        public bool tblHangnhap_Delete(int FK_iHoadonnhaphangID, int FK_iHanghoaID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHangnhap_Delete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iHoadonnhaphangID", FK_iHoadonnhaphangID);
                    cmd.Parameters.AddWithValue("@FK_iHanghoaID", FK_iHanghoaID);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Thêm Hàng bán
        /// </summary>
        /// <param name="hangnhap">tblHangnhap</param>
        /// <returns>bool</returns>
        public bool tblHangnhap_Insert(tblHangnhap hangnhap)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHangnhap_Insert", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iHoadonnhaphangID", hangnhap.iHoadonnhaphangID);
                    cmd.Parameters.AddWithValue("@FK_iHanghoaID", hangnhap.iHanghoaID);
                    cmd.Parameters.AddWithValue("@iSoluongnhap", hangnhap.iSoluongnhap);
                    cmd.Parameters.AddWithValue("@iGianhap", hangnhap.iGianhap);
                    cmd.Parameters.AddWithValue("@iThanhtien", hangnhap.iThanhtien);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Cập nhật Hàng bán theo FK_iHoadonnhaphangID và FK_iHanghoaID
        /// </summary>
        /// <param name="hangnhap">tblHangnhap</param>
        /// <returns></returns>
        public bool tblHangnhap_Update(tblHangnhap hangnhap)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHangnhap_Update", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iHoadonnhaphangID", hangnhap.iHoadonnhaphangID);
                    cmd.Parameters.AddWithValue("@FK_iHanghoaID", hangnhap.iHanghoaID);
                    cmd.Parameters.AddWithValue("@iSoluongnhap", hangnhap.iSoluongnhap);
                    cmd.Parameters.AddWithValue("@iGianhap", hangnhap.iGianhap);
                    cmd.Parameters.AddWithValue("@iThanhtien", hangnhap.iThanhtien);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

    }
}
