using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    public class DOTPHATHANH_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public DOTPHATHANH_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

        public void Insert(DOTPHATHANH dotphathanh)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaCongTy", dotphathanh.MaCongTy),
                new SqlParameter("@NgayPhatHanh", dotphathanh.NgayPhatHanh),
                new SqlParameter("@NgayXoSo", dotphathanh.NgayXoSo),
                new SqlParameter("@GioXoSo", dotphathanh.GioXoSo)
            };
            _Context.Database.ExecuteSqlCommand("DOTPHATHANH_Ins", parameters);
        }
        public List<DOTPHATHANH> Select()
        {
            return _Context.Database.SqlQuery<DOTPHATHANH>("DOTPHATHANH_Sel").ToList();
        }

        public List<DOTPHATHANH> Select_Con_Company(string macongty)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaCongTy", macongty)
            };
            return _Context.Database.SqlQuery<DOTPHATHANH>(" DOTPHATHANH_Sel_Con_Company @MaCongTy", parameters).ToList();
        }
        public List<DOTPHATHANH> Select_Your_Company()
        {
            return _Context.Database.SqlQuery<DOTPHATHANH>(" DOTPHATHANH_Sel_Your_Company").ToList();
        }

        public List<DOTPHATHANH> DOITAC_Sel_not_YourCompany(string macongty)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaCongTy", macongty)
            };
            return _Context.Database.SqlQuery<DOTPHATHANH>(" DOTPHATHANH_Sel_Con_Company @MaCongTy", parameters).ToList();
        }
    }
}
