using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    class PHIEUTHANHTOAN_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public PHIEUTHANHTOAN_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public void Insert(PHIEUTHANHTOAN phieuthanhtoan)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaDoiTac", phieuthanhtoan.MaDoiTac),
                new SqlParameter("@MaDotPhatHanh", phieuthanhtoan.MaDotPhatHanh),
                new SqlParameter("@SoTienNo", phieuthanhtoan.SoTienNo),
                new SqlParameter("@SoTienThu", phieuthanhtoan.SoTienThu),
                new SqlParameter("@SoTienConLai", phieuthanhtoan.SoTienConLai),
                new SqlParameter("@NgayLap", phieuthanhtoan.NgayLap),
                new SqlParameter("@MaNhanVienLap", phieuthanhtoan.MaNhanVienLap),
                new SqlParameter("@TenNguoiNop", phieuthanhtoan.TenNguoiNop),
                new SqlParameter("@SDT", phieuthanhtoan.SDT),
                new SqlParameter("@DiaChi", phieuthanhtoan.DiaChi),
                new SqlParameter("@Email", phieuthanhtoan.Email)
            };
            _Context.Database.ExecuteSqlCommand(@"PHIEUTHANHTOAN_Ins @MaDoiTac, @MaDotPhatHanh, @SoTienNo, 
                                                        @SoTienThu, @SoTienConLai, @NgayLap,@MaNhanVienLap, @TenNguoiNop, @SDT, @DiaChi , @Email", parameters);
        }
        public List<PHIEUTHANHTOAN> Select(string madoitac = "")
        {
            object[] parameters = 
            {
                new SqlParameter("@MaDoiTac", madoitac)
            };
            return _Context.Database.SqlQuery<PHIEUTHANHTOAN>("PHIEUTHANHTOAN_Sel @MaDoiTac", parameters).ToList();
        }
    }
}
