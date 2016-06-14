using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;

namespace XoSoKienThiet.BUS
{
    public class COCAUTOCHUC_BUS
    {
        COCAUTOCHUC_DAO _COCAUTOCHUC_DAO = null;
        public COCAUTOCHUC_BUS()
        {
            _COCAUTOCHUC_DAO = new COCAUTOCHUC_DAO();
        }
        public string GetID(string mabophan, string machucvu)
        {
            return _COCAUTOCHUC_DAO.GetID(mabophan, machucvu);
        }
    }
}
