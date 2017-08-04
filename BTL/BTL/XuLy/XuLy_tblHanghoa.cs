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
    class XuLy_tblHanghoa
    {
        public string connectionString = ConnectionString.getConnectionString();

        public XuLy_tblHanghoa() { }

        /// <summary>
        /// Lấy danh sách Hàng hóa trong Kho theo Khóa chính
        /// </summary>
        /// <param name="PK_iHanghoaID">Mã Hàng hóa</param>
        /// <returns>List<tblHanghoa></returns>
        public List<tblHanghoa> tblHanghoa_Select(int PK_iHanghoaID)
        {
            List<tblHanghoa> listKho = new List<tblHanghoa>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_Select", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHanghoaID", PK_iHanghoaID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblHanghoa hanghoa = new tblHanghoa();
                                hanghoa.iHanghoaID = Convert.ToInt32(rd["PK_iHanghoaID"].ToString());
                                hanghoa.iNhomhangID = Convert.ToInt32(rd["FK_iNhomhangID"].ToString());
                                hanghoa.sTenHanghoa = rd["sTenHanghoa"].ToString();
                                hanghoa.sNhacungcap = rd["sNhacungcap"].ToString();
                                hanghoa.iSoluong = Convert.ToInt32(rd["iSoluong"].ToString());
                                hanghoa.iDongia = Convert.ToInt32(rd["iDongia"].ToString());
                                hanghoa.iThoigianbaohanh = Convert.ToInt32(rd["iThoigianbaohanh"].ToString());
                                listKho.Add(hanghoa);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listKho;
                    }
                }
            }
        }

        /// <summary>
        /// Lấy danh sách Hàng hóa trong Kho theo Khóa phụ
        /// </summary>
        /// <param name="FK_iNhomhangID">Mã Nhóm hàng</param>
        /// <returns>List<tblHanghoa></returns>
        public List<tblHanghoa> tblHanghoa_SelectByFK(int FK_iNhomhangID)
        {
            List<tblHanghoa> listKho = new List<tblHanghoa>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_SelectByFK", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iNhomhangID", FK_iNhomhangID);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                tblHanghoa hanghoa = new tblHanghoa();
                                hanghoa.iHanghoaID = Convert.ToInt32(rd["PK_iHanghoaID"].ToString());
                                hanghoa.iNhomhangID = Convert.ToInt32(rd["FK_iNhomhangID"].ToString());
                                hanghoa.sTenHanghoa = rd["sTenHanghoa"].ToString();
                                hanghoa.sNhacungcap = rd["sNhacungcap"].ToString();
                                hanghoa.iSoluong = Convert.ToInt32(rd["iSoluong"].ToString());
                                hanghoa.iDongia = Convert.ToInt32(rd["iDongia"].ToString());
                                hanghoa.iThoigianbaohanh = Convert.ToInt32(rd["iThoigianbaohanh"].ToString());
                                listKho.Add(hanghoa);
                            }
                            rd.Close();
                        }
                        cnn.Close();
                        return listKho;
                    }
                }
            }
        }

        /// <summary>
        /// Xóa Hàng hóa theo khóa chính
        /// </summary>
        /// <param name="PK_iHanghoaID">Mã Hàng hóa</param>
        /// <returns>bool</returns>
        public bool tblHanghoa_Delete(int PK_iHanghoaID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_Delete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHanghoaID", PK_iHanghoaID);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        /// <summary>
        /// Xóa Hàng hóa trong Kho theo khóa phụ
        /// </summary>
        /// <param name="FK_iNhomhangID">Mã Nhóm hàng</param>
        /// <returns>bool</returns>
        public bool tblHanghoa_DeleteByFK(int FK_iNhomhangID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_DeleteByFK", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FK_iNhomhangID", FK_iNhomhangID);
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
        /// <param name="hanghoa">tblHanghoa</param>
        /// <returns>bool</returns>
        public bool tblHanghoa_Insert(tblHanghoa hanghoa)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_Insert", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHanghoaID", hanghoa.iHanghoaID);
                    cmd.Parameters.AddWithValue("@FK_iNhomhangID", hanghoa.iNhomhangID);
                    cmd.Parameters.AddWithValue("@sTenHanghoa", hanghoa.sTenHanghoa);
                    cmd.Parameters.AddWithValue("@sNhacungcap", hanghoa.sNhacungcap);
                    cmd.Parameters.AddWithValue("@iSoluong", hanghoa.iSoluong);
                    cmd.Parameters.AddWithValue("@iDongia", hanghoa.iDongia);
                    cmd.Parameters.AddWithValue("@iThoigianbaohanh", hanghoa.iThoigianbaohanh);
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
        /// <param name="hanghoa">tblHanghoa</param>
        /// <returns>bool</returns>
        public bool tblHanghoa_Update(tblHanghoa hanghoa)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_tblHanghoa_Update", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PK_iHanghoaID", hanghoa.iHanghoaID);
                    cmd.Parameters.AddWithValue("@FK_iNhomhangID", hanghoa.iNhomhangID);
                    cmd.Parameters.AddWithValue("@sTenHanghoa", hanghoa.sTenHanghoa);
                    cmd.Parameters.AddWithValue("@sNhacungcap", hanghoa.sNhacungcap);
                    cmd.Parameters.AddWithValue("@iSoluong", hanghoa.iSoluong);
                    cmd.Parameters.AddWithValue("@iDongia", hanghoa.iDongia);
                    cmd.Parameters.AddWithValue("@iThoigianbaohanh", hanghoa.iThoigianbaohanh);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public DataTable LayToanbo()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sqlSelect = "Select * from tblHanghoa";
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
