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
    public class PHIEUDANGKYVE_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public PHIEUDANGKYVE_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

        public List<PHIEUDANGKYVE> Select(string maphieudangky)
        {
            var _MaPhieuDangKy = new SqlParameter("@MaPhieuDangKy", SqlDbType.NChar, 10)
            {
                Value = maphieudangky
            };
            return _Context.Database.SqlQuery<PHIEUDANGKYVE>("PHIEUDANGKYVE_Sel @MaPhieuDangKy ", _MaPhieuDangKy).ToList();
        }
        public string Insert(PHIEUDANGKYVE phieudangkyve)
        {
            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = phieudangkyve.MaDoiTac
            };
            var _NgayLap = new SqlParameter("@NgayLap", SqlDbType.DateTime)
            {
                Value = phieudangkyve.NgayLap
            };
            var _MaNhanVienLap = new SqlParameter("@MaNhanVienLap", SqlDbType.NChar, 10)
            {
                Value = phieudangkyve.MaNhanVienLap
            };
            var _TongSoVeDangKy = new SqlParameter("@TongSoVeDangKy", SqlDbType.Int)
            {
                Value = phieudangkyve.TongSoVeDangKy
            };
            var _MaPhieuDangKyVe = new SqlParameter("@MaPhieuDangKyVe", SqlDbType.NChar, 10)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("PHIEUDANGKYVE_Ins @MaDoiTac, @MaNhanVienLap,@NgayLap, @TongSoVeDangKy,@MaPhieuDangKyVe output",
                                                                        _MaDoiTac, _MaNhanVienLap, _NgayLap, _TongSoVeDangKy, _MaPhieuDangKyVe);
            return _MaPhieuDangKyVe.Value.ToString();
        }
    }
}
