using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class LOAIDOITAC_BUS
    {
        LOAIDOITAC_DAO _LOAIDOITAC_DAO = null;
        public LOAIDOITAC_BUS()
        {
            _LOAIDOITAC_DAO = new LOAIDOITAC_DAO();
        }
        public List<LOAIDOITAC> Select()
        {
            return _LOAIDOITAC_DAO.Select();
        }

        public string GetMaLoaiDoiTac(string tendoitac)
        {
            return _LOAIDOITAC_DAO.GetMaLoaiDoiTac(tendoitac);
        }
        public string GetTenDoiTac(string loaidoitac)
        {
            return _LOAIDOITAC_DAO.GetTenDoiTac(loaidoitac);
        }
    }
}
