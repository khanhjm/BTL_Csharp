using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.ThucThe
{
    class tblHoadonbanhang
    {
        public int PK_iHoadonbanhangID;
        public int FK_iNhanvienID;
        public string sTenKhachhang;
        public string sDiachi;
        public string sSdt;
        public DateTime dThoigianban;
        public int iTongtien;

        public tblHoadonbanhang() { }
    }
}
