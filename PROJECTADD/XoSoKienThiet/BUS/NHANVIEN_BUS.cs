using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class NHANVIEN_BUS
    {
        NHANVIEN_DAO _NHANVIEN_DAO = null;
        public NHANVIEN_BUS()
        {
            _NHANVIEN_DAO = new NHANVIEN_DAO();
        }

        public List<NHANVIEN> Select()
        {
            return _NHANVIEN_DAO.Select();
        }
    }
}
