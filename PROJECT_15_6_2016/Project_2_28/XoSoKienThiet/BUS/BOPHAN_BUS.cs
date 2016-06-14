using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class BOPHAN_BUS
    {
        BOPHAN_DAO _BOPHAN_DAO = null;
        public BOPHAN_BUS()
        {
            _BOPHAN_DAO = new BOPHAN_DAO();
        }
        public List<BOPHAN> Select()
        {
            return _BOPHAN_DAO.Select();
        }
    }
}
