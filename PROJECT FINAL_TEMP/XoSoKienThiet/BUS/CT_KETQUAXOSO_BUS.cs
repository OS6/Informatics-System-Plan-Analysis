using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class CT_KETQUAXOSO_BUS
    {
        CT_KETQUAXOSO_DAO _CT_KETQUAXOSO_DAO = null;
        public CT_KETQUAXOSO_BUS()
        {
            _CT_KETQUAXOSO_DAO = new CT_KETQUAXOSO_DAO();
        }
        public string Insert(string maketquaxoso, string magiaithuong, string soluongvetrung, string tongtien, string machitietketqua = "")
        {
            int SoLuongVeTrung, TongTien;
            SoLuongVeTrung = int.Parse(soluongvetrung);
            TongTien = int.Parse(tongtien);
            CT_KETQUAXOSO ct_ketqua = new CT_KETQUAXOSO(maketquaxoso, magiaithuong, SoLuongVeTrung, TongTien, machitietketqua);
            return _CT_KETQUAXOSO_DAO.Insert(ct_ketqua);
        }
        public void Update(string mact_ketqua, string madssotrung)
        {
            _CT_KETQUAXOSO_DAO.Update(mact_ketqua, madssotrung);
        }
    }
}
