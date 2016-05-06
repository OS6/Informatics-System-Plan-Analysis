using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    public class GIAITHUONG_DAO
    {
       XoSoKienThietDbContext _Context = null;
       public GIAITHUONG_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<LOAIVE> Select()
        {
            return _Context.Database.SqlQuery<LOAIVE>("LOAIVE_Sel").ToList();
        }
        public void Insert(GIAITHUONG giaithuong)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaLoaiVe", giaithuong.MaLoaiVe),
                new SqlParameter("@Ten", giaithuong.Ten),
                new SqlParameter("@SoTienTrung", giaithuong.SoTienTrung),
                new SqlParameter("@SoGiai", giaithuong.SoGiai)
            };
             _Context.Database.ExecuteSqlCommand("GIAITHUONG_Ins @MaLoaiVe, @Ten, @SoTienTrung, @SoGiai", parameters);
        }
    }
}
