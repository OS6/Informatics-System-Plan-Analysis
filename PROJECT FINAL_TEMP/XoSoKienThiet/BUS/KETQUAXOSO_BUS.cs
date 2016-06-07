using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class KETQUAXOSO_BUS
    {
        KETQUAXOSO_DAO _KETQUAXOSO_DAO = null;
        public KETQUAXOSO_BUS()
        {
            _KETQUAXOSO_DAO = new KETQUAXOSO_DAO();
        }
        public string Insert(string madotphathanh, string maloaive, string maketqua = "")
        {
            KETQUAXOSO ketquasoxo = new KETQUAXOSO  (madotphathanh, maloaive, maketqua);
            return _KETQUAXOSO_DAO.Insert(ketquasoxo);

        }
    }
}
