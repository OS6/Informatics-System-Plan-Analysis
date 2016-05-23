using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
   public class DOITAC_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public DOITAC_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
       public List<DOITAC> SelectAgency()
       {
           return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel_Agency").ToList();
       }

       public void Insert(DOITAC doitac)
       {
           object[] parameters = 
            {
                new SqlParameter("@MaLoaiDoiTac", doitac.MaLoaiDoiTac),
                new SqlParameter("@Ten", doitac.Ten),
                new SqlParameter("@DiaChi", doitac.DiaChi),
                new SqlParameter("@SDT", doitac.SDT),
                new SqlParameter("@Email",doitac.Email)
            };
           _Context.Database.ExecuteSqlCommand("DOITAC_Ins @MaLoaiDoiTac, @Ten, @DiaChi, @SDT, @Email", parameters);
       }
    }
}