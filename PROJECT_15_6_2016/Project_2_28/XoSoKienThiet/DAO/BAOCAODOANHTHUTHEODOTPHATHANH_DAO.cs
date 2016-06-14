using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    class BAOCAODOANHTHUTHEODOTPHATHANH_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public BAOCAODOANHTHUTHEODOTPHATHANH_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<BAOCAODOANHTHUTHEODOT> Select(string madotphathanh)
        {
            var MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = madotphathanh
            };
            return _Context.Database.SqlQuery<BAOCAODOANHTHUTHEODOT>("BAOCAODOANHTHUDOT_Sel @MaDotPhatHanh", MaDotPhatHanh).ToList();
        }
    }
}
