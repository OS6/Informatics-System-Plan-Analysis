using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class BAOCAODOANHTHUTHEODOTPHATHANH_BUS
    {
        BAOCAODOANHTHUTHEODOTPHATHANH_DAO _BAOCAODOANHTHUTHEODOTPHATHANH_DAO = null;
        public BAOCAODOANHTHUTHEODOTPHATHANH_BUS()
        {
            _BAOCAODOANHTHUTHEODOTPHATHANH_DAO = new BAOCAODOANHTHUTHEODOTPHATHANH_DAO();
        }
        public BAOCAODOANHTHUTHEODOT Select(string madotphathanh)
        {
            return _BAOCAODOANHTHUTHEODOTPHATHANH_DAO.Select(madotphathanh).SingleOrDefault();
        }
    }
}
