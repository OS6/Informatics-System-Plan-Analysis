using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class PHIEUNHANVE_BUS
    {
        PHIEUNHANVE_DAO _PHIEUNHANVE_DAO = null;
        public PHIEUNHANVE_BUS()
        {
            _PHIEUNHANVE_DAO = new PHIEUNHANVE_DAO();
        }

        public string Insert(string madoitac, string tongsove, string ngaylap, string manhanvienlap, string tongtien)
        {
            DateTime _NgayLap;
            int _TongSoVe;
            float _TongTien;
            _NgayLap = Convert.ToDateTime(ngaylap);
            _TongSoVe = int.Parse(tongsove);
            _TongTien = float.Parse(tongtien);

            PHIEUNHANVE _PHIEUNHANVE = new PHIEUNHANVE(madoitac, _TongSoVe, _NgayLap, manhanvienlap, _TongTien);
            return _PHIEUNHANVE_DAO.Insert(_PHIEUNHANVE);
        }
    }
}
