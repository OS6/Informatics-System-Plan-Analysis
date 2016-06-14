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
    class PHIEUTRAVE_DAO
    {
         XoSoKienThietDbContext _Context = null;
         public PHIEUTRAVE_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
         public string Insert(PHIEUTRAVE phieutrave)
         {
             var MaPhieuNhanVe = new SqlParameter("@MaPhieuNhanVe", SqlDbType.NChar, 10)
             {
                 Value = phieutrave.MaPhieuNhanVe
             };
             var MaNhanVienLap = new SqlParameter("@MaNhanVienLap", SqlDbType.NChar, 10)
             {
                 Value = phieutrave.MaNhanVienLap
             };
             var NgayLap = new SqlParameter("@NgayLap", SqlDbType.DateTime)
             {
                 Value = phieutrave.NgayLap
             };
             var TongSoVeTra = new SqlParameter("@TongSoVeTra", SqlDbType.Int)
             {
                 Value = phieutrave.TongSoVeTra
             };
             var TongTien = new SqlParameter("@TongTien", SqlDbType.Decimal)
             {
                 Value = phieutrave.TongTienPhaiTra
             };
             var MaPhieuTraVe = new SqlParameter("@MaPhieuTraVe", SqlDbType.NChar, 10)
             {
                 Direction = ParameterDirection.Output
             };
             _Context.Database.ExecuteSqlCommand("PHIEUTRAVE_Ins @MaPhieuNhanVe,@MaNhanVienLap, @NgayLap, @TongSoVeTra, @TongTien, @MaPhieuTraVe output",
                                                                         MaPhieuNhanVe, MaNhanVienLap, NgayLap, TongSoVeTra, TongTien, MaPhieuTraVe);
             return MaPhieuTraVe.Value.ToString();
         }
    }
}
