using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    public class NHANVIEN_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public NHANVIEN_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<NHANVIEN> Select()
        {
            return _Context.Database.SqlQuery<NHANVIEN>("NHANVIEN_Sel").ToList();
        }
    }
}
