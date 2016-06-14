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
    class PHIEUNHANGIAI_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public PHIEUNHANGIAI_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public void Insert(PHIEUNHANGIAI phieunhangiai)
        {

            var MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar,10);
            MaDotPhatHanh.Value = phieunhangiai.MaDotPhatHanh;
            var MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar,10 );
            MaLoaiVe.Value = phieunhangiai.MaLoaiVe;
            var MaGiaiThuong = new SqlParameter("@MaGiaiThuong", SqlDbType.NChar,10);
            MaGiaiThuong.Value = phieunhangiai.MaGiaiThuong;
            var MaNhanVienLap = new SqlParameter("@MaNhanVienLap",SqlDbType.NChar,10 );
            MaNhanVienLap.Value = phieunhangiai.MaNhanVienLap;

            var SoTienTrungThuong = new SqlParameter("@SoTienTrungThuong", SqlDbType.Decimal);
            SoTienTrungThuong.Value = phieunhangiai.SoTienTrungThuong;
            var SoTienDongThue = new SqlParameter("@SoTienDongThue", SqlDbType.Decimal);
            SoTienDongThue.Value = phieunhangiai.SoTienDongThue;
            var SoTienNhanDuoc = new SqlParameter("@SoTienNhanDuoc", SqlDbType.Decimal);
            SoTienNhanDuoc.Value = phieunhangiai.SoTienNhanDuoc;

            var NgayLap = new SqlParameter("@NgayLap", SqlDbType.DateTime);
            NgayLap.Value = phieunhangiai.NgayLap;
            var HoTen = new SqlParameter("@HoTen", SqlDbType.NVarChar, 50);
            HoTen.Value = phieunhangiai.HoTen;
            var SDT = new SqlParameter("@SDT", SqlDbType.NVarChar, 50);
            SDT.Value =phieunhangiai.SDT;
            var CMND = new SqlParameter("@CMND", SqlDbType.NVarChar, 50);
            CMND.Value = phieunhangiai.CMND;

            _Context.Database.ExecuteSqlCommand(@"PHIEUNHANGIAI_Ins @MaDotPhatHanh, @MaLoaiVe, @MaGiaiThuong, @MaNhanVienLap,
                                                @SoTienTrungThuong,@SoTienDongThue,@SoTienNhanDuoc,
                                                @NgayLap,@HoTen,@SDT,@CMND",
                                                    MaDotPhatHanh, MaLoaiVe, MaGiaiThuong, MaNhanVienLap, 
                                                    SoTienTrungThuong,SoTienDongThue, SoTienNhanDuoc, 
                                                    NgayLap, HoTen, SDT,CMND);
            //CHƯA VIẾT PROC INSERT PHIEUNHANGIAI
        }
    }
}
