using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class DOTPHATHANH_BUS
    {
        DOTPHATHANH_DAO _DOTPHATHANH_DAO = null;
        public DOTPHATHANH_BUS()
        {
            _DOTPHATHANH_DAO = new DOTPHATHANH_DAO();
        }

        public void Insert(string ngayphathanh, string ngayxoso, string gioxoso, string macongty)
        {
            DOTPHATHANH _DOTPHATHANH = new DOTPHATHANH(Convert.ToDateTime(ngayphathanh), Convert.ToDateTime(ngayxoso), Convert.ToInt32(gioxoso), macongty);
        }
        public List<DOTPHATHANH> Select()
        {
            return _DOTPHATHANH_DAO.Select();
        }
        public List<DOTPHATHANH> Select_Con_Company(string macongty)
        {
            return _DOTPHATHANH_DAO.Select_Con_Company(macongty);
        }
        public List<DOTPHATHANH> Select_Your_Company()
        {
            return _DOTPHATHANH_DAO.Select_Your_Company();
        }
    }
}
