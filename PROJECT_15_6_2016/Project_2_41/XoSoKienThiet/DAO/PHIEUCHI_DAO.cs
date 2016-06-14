using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    class PHIEUCHI_DAO
    {
          XoSoKienThietDbContext _Context = null;
          public PHIEUCHI_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
          public void Insert(PHIEUCHI phieuchi)
          {
              object[] parameters = 
            {
                new SqlParameter("@MaDotPhatHanh", phieuchi.MaDotPhatHanh),
                new SqlParameter("@MaDonVi", phieuchi.MaDonVi),
                new SqlParameter("@MaNhanVienLap", phieuchi.MaNhanVienLap),
                 new SqlParameter("@NgayLap", phieuchi.NgayLap),
                new SqlParameter("@NoiDungChi", phieuchi.NoiDungChi),
                new SqlParameter("@SoTienChi", phieuchi.SoTienChi)
            };
              _Context.Database.ExecuteSqlCommand(@"PHIEUCHI_Ins @MaDotPhatHanh, @MaDonVi, @MaNhanVienLap, @NgayLap, @NoiDungChi, @SoTienChi", parameters);
          }
    }
}
