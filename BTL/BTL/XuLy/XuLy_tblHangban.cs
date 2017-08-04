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
    class XuLy_tblHangban
    {
        public string connectionString = ConnectionString.getConnectionString();

        public XuLy_tblHangban() { }

        /// <summary>
        /// Lấy danh sách Hàng bán
        /// </summary>
        /// <param name="FK_iHoadonbanhangID">Mã hóa đơn bán hàng</param>
        /// <param name="FK_iHanghoaID">Mã hàng hóa</param>
        /// <returns>List<tblHangban></returns>
        public List<tblHangban> tblHangban_Select(int FK_iHoadonbanhangID, int FK_iHanghoaID)
        {
            List<tblHangban> listHangban = new List<tblHangban>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHangban_Select", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iHoadonbanhangID", FK_iHoadonbanhangID);
                    cmd.Parameters.AddWithValue("@FK_iHanghoaID", FK_iHanghoaID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblHangban hangban = new tblHangban();
                                hangban.iHoadonbanhangID = Convert.ToInt32(rd["FK_iHoadonbanhangID"].ToString());
                                hangban.iHanghoaID = Convert.ToInt32(rd["FK_iHanghoaID"].ToString());
                                hangban.iSoluongban = Convert.ToInt32(rd["iSoluongban"].ToString());
                                hangban.iGiaban = Convert.ToInt32(rd["iGiaban"].ToString());
                                hangban.iThanhtien = Convert.ToInt32(rd["iThanhtien"].ToString());
                                listHangban.Add(hangban);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listHangban;
                    }
                }
            }
        }

        /// <summary>
        /// Xóa Hàng bán
        /// </summary>
        /// <param name="FK_iHoadonbanhangID">Mã Hóa đơn bán hàng</param>
        /// <param name="FK_iHanghoaID">Mã Hàng hóa</param>
        /// <returns>bool</returns>
        public bool tblHangban_Delete(int FK_iHoadonbanhangID, int FK_iHanghoaID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHangban_Delete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iHoadonbanhangID", FK_iHoadonbanhangID);
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
        /// <param name="hangban">tblHangban</param>
        /// <returns>bool</returns>
        public bool tblHangban_Insert(tblHangban hangban)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHangban_Insert", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iHoadonbanhangID", hangban.iHoadonbanhangID);
                    cmd.Parameters.AddWithValue("@FK_iHanghoaID", hangban.iHanghoaID);
                    cmd.Parameters.AddWithValue("@iSoluongban", hangban.iSoluongban);
                    cmd.Parameters.AddWithValue("@iGiaban", hangban.iGiaban);
                    cmd.Parameters.AddWithValue("@iThanhtien", hangban.iThanhtien);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Cập nhật Hàng bán theo FK_iHoadonbanhangID và FK_iHanghoaID
        /// </summary>
        /// <param name="hangban">tblHangban</param>
        /// <returns></returns>
        public bool tblHangban_Update(tblHangban hangban)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHangban_Update", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iHoadonbanhangID", hangban.iHoadonbanhangID);
                    cmd.Parameters.AddWithValue("@FK_iHanghoaID", hangban.iHanghoaID);
                    cmd.Parameters.AddWithValue("@iSoluongban", hangban.iSoluongban);
                    cmd.Parameters.AddWithValue("@iGiaban", hangban.iGiaban);
                    cmd.Parameters.AddWithValue("@iThanhtien", hangban.iThanhtien);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Lấy danh sách Hàng bán
        /// </summary>
        /// <param name="sFilter">Điều kiện</param>
        /// <returns>DataTable</returns>
        public DataTable TimKiem(string sFilter)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sqlSelect = "select tblHangban.FK_iHanghoaID as iHanghoaID, tblHanghoa.FK_iNhomhangID as iNhomhangID, tblNhomhang.sTenNhomhang as sTenNhomhang, tblHanghoa.sTenHanghoa as sTenHanghoa, tblHanghoa.sNhacungcap as sNhacungcap, tblHanghoa.iThoigianbaohanh as iThoigianbaohanh, tblHangban.iGiaban as iDongia, tblHangban.iSoluongban as iSoluongban, tblHangban.iThanhtien as iThanhtien from tblHangban left join tblHanghoa on tblHangban.FK_iHanghoaID = tblHanghoa.PK_iHanghoaID left join tblNhomhang on tblHanghoa.FK_iNhomhangID = tblNhomhang.PK_iNhomhangID where " + sFilter;
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
