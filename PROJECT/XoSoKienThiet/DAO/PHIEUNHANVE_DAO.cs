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

        public string Insert(PHIEUNHANVE phieunhanve)
        {
            //object[] parameters = 
            //{
            //    new SqlParameter("@MaDoiTac", phieunhanve.MaDoiTac),
            //    new SqlParameter("@TongSoVe", phieunhanve.TongSoVe),
            //    new SqlParameter("@NgayLap", phieunhanve.NgayLap),
            //    new SqlParameter("@MaNhanVienLap",phieunhanve.MaNhanVienLap),
            //    new SqlParameter("@TongTien", phieunhanve.TongTien)
            //};
            //return _Context.Database.ExecuteSqlCommand("PHIEUNHANVE_Ins @MaDoiTac,@TongSoVe, @NgayLap, @MaNhanVienLap, @TongTien", parameters);

            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = phieunhanve.MaDoiTac
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
            _Context.Database.ExecuteSqlCommand("PHIEUNHANVE_Ins @MaDoiTac,@TongSoVe, @NgayLap, @MaNhanVienLap, @TongTien, @MaPhieuNhanVe output", 
                                                                        _MaDoiTac, _TongSoVe, _NgayLap, _MaNhanVienLap, _TongTien, _MaPhieuNhanVe );
            return _MaPhieuNhanVe.Value.ToString();
        }
    }
}
