using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class CT_KEHOACHPHATHANH_BUS
    {
        CT_KEHOACHPHATHANH_DAO _CT_KEHOACHPHATHANH_DAO = null;
        public CT_KEHOACHPHATHANH_BUS()
        {
            _CT_KEHOACHPHATHANH_DAO = new CT_KEHOACHPHATHANH_DAO();
        }
        public void Insert(string makehoach, string maloaive, string sovedukien, string sovethucte)
        {
            int SoVeDuKien, SoVeThucTe;
            SoVeDuKien = int.Parse(sovedukien);
            SoVeThucTe = int.Parse(sovethucte);

            var CT_KeHoach  = new CT_KEHOACHPHATHANH(makehoach, maloaive, SoVeDuKien, SoVeThucTe);
            _CT_KEHOACHPHATHANH_DAO.Insert(CT_KeHoach);
        }
    }
}
