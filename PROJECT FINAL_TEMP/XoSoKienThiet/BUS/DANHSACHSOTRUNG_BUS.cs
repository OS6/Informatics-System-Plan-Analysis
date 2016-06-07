using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class DANHSACHSOTRUNG_BUS
    {
        DANHSACHSOTRUNG_DAO _DANHSACHSOTRUNG_DAO = null;
        public DANHSACHSOTRUNG_BUS()
        {
            _DANHSACHSOTRUNG_DAO = new DANHSACHSOTRUNG_DAO();
        }
        public void Insert(string mact_ketqua, string sotrung)
        {
            DANHSACHSOTRUNG danhsach = new DANHSACHSOTRUNG(mact_ketqua, sotrung);
            _DANHSACHSOTRUNG_DAO.Insert(danhsach);
        }
    }
}
