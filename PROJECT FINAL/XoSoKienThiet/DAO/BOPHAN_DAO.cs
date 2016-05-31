using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    public class BOPHAN_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public BOPHAN_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<BOPHAN> Select()
        {
            return _Context.Database.SqlQuery<BOPHAN>("BOPHAN_Sel").ToList();
        }
    }
}
