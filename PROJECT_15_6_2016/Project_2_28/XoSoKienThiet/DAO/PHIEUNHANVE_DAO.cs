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
    public class PHIEUNHANVE_DAO
    {
         XoSoKienThietDbContext _Context = null;
         public PHIEUNHANVE_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
         public List<PHIEUNHANVE> Select(string maphieunhanve)
         {
             var _MaPhieuNhanVe = new SqlParameter("@MaPhieuNhanVe", SqlDbType.NChar, 10)
             {
                 Value = maphieunhanve
             };
             return _Context.Database.SqlQuery<PHIEUNHANVE>("PHIEUNHANVE_Sel @MaPhieuNhanVe ", _MaPhieuNhanVe).ToList();
         }
        public string Insert(PHIEUNHANVE phieunhanve)
        {
            var _MaPhieuDangKy = new SqlParameter("@MaPhieuDangKy", SqlDbType.NChar, 10)
            {
                Value = phieunhanve.MaPhieuDangKy
            };
            var _TongSoVe = new SqlParameter("@TongSoVe", SqlDbType.Int)
            {
                Value = phieunhanve.TongSoVe
            };
            var _NgayLap = new SqlParameter("@NgayLap", SqlDbType.DateTime)
            {
                Value = phieunhanve.NgayLap
            };
            var _MaNhanVienLap = new SqlParameter("@MaNhanVienLap", SqlDbType.NChar, 10)
            {
                Value = phieunhanve.MaNhanVienLap
            };
            var _TongTien = new SqlParameter("@TongTien", SqlDbType.Float)
            {
                Value = phieunhanve.TongTien
            };
            var _MaPhieuNhanVe = new SqlParameter("@MaPhieuNhanVe", SqlDbType.NChar, 10)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("PHIEUNHANVE_Ins @MaPhieuDangKy,@TongSoVe, @NgayLap, @MaNhanVienLap, @TongTien, @MaPhieuNhanVe output",
                                                                        _MaPhieuDangKy, _TongSoVe, _NgayLap, _MaNhanVienLap, _TongTien, _MaPhieuNhanVe);
            return _MaPhieuNhanVe.Value.ToString();
        }
    }
}
