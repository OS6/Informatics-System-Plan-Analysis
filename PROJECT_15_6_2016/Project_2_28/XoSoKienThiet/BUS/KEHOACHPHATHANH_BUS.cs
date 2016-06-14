using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class KEHOACHPHATHANH_BUS
    {
        KEHOACHPHATHANH_DAO _KEHOACHPHATHANH_DAO = null;
        public KEHOACHPHATHANH_BUS()
        {
            _KEHOACHPHATHANH_DAO = new KEHOACHPHATHANH_DAO();
        }
        public List<CT_KEHOACHPHATHANH_VIEW> Select(string madotphathanh)
        {
            return _KEHOACHPHATHANH_DAO.Select(madotphathanh);
        }

        public string Insert(string madotphathanh, string tongve)
        {
            int TongVe;
            TongVe = int.Parse(tongve);
            var KeHoach = new KEHOACHPHATHANH(madotphathanh, TongVe);
            return _KEHOACHPHATHANH_DAO.Insert(KeHoach);
        }
    }
}
