using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;

namespace XoSoKienThiet.BUS
{
    class DANGNHAP_BUS
    {
        DANGNHAP_DAO _DANGNHAP_DAO = null;
        public DANGNHAP_BUS()
        {
            _DANGNHAP_DAO = new DANGNHAP_DAO();
        }
        public THONGTINDANGNHAP GetMaBoPhan(string username, string password)
        {
            return _DANGNHAP_DAO.GetMaBoPhan(username, password);
        }
        public void Update(int id, string pass)
        {
            _DANGNHAP_DAO.Update(id, pass);
        }
    }
}
