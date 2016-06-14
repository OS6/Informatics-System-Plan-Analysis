using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    class DANHSACHSOTRUNG_DAO
    {
         XoSoKienThietDbContext _Context = null;
         public DANHSACHSOTRUNG_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public void Insert(DANHSACHSOTRUNG dachsach)
         {
             object[] parameters = 
            {
                new SqlParameter("@MaChiTietKQXS", dachsach.MaChiTietKQXS),
                new SqlParameter("@SoTrung", dachsach.SoTrung)
            };
             _Context.Database.ExecuteSqlCommand("DANHSACHSOTRUNG_Ins @MaChiTietKQXS, @SoTrung", parameters);
         }
    }
}
