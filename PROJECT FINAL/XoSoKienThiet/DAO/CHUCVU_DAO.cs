using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    public class CHUCVU_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public CHUCVU_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<CHUCVU> Select()
        {
            return _Context.Database.SqlQuery<CHUCVU>("CHUCVU_Sel").ToList();
        }
    }
}
