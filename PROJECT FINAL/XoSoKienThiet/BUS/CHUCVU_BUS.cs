using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class CHUCVU_BUS
    {
        CHUCVU_DAO _CHUCVU_DAO = null;
        public CHUCVU_BUS()
        {
            _CHUCVU_DAO = new CHUCVU_DAO();
        }
        public List<CHUCVU> Select()
        {
            return _CHUCVU_DAO.Select();
        }
    }
}
