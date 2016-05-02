using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    class CT_PHIEUNHANVE_DAO
    {
         XoSoKienThietDbContext _Context = null;
         public CT_PHIEUNHANVE_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

        public int Insert(CT_PHIEUNHANVE ct_phieunhanve)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaPhieuNhanVe", ct_phieunhanve.MaPhieuNhanVe),
                new SqlParameter("@MaDoiTac", ct_phieunhanve.MaDoiTac),
                new SqlParameter("@MaDotPhatHanh", ct_phieunhanve.MaDotPhatHanh),
                new SqlParameter("@MaLoaiVe",ct_phieunhanve.MaLoaiVe),
                new SqlParameter("@SoLuongDangKy", ct_phieunhanve.SoLuongDangKy),
                new SqlParameter("@SoLuongNhan",ct_phieunhanve.SoLuongNhan),
                new SqlParameter("@ThanhTien", ct_phieunhanve.ThanhTien)
            };
            return _Context.Database.ExecuteSqlCommand("CT_PHIEUNHANVE_Ins @MaPhieuNhanVe,@MaDoiTac, @MaDotPhatHanh, @MaLoaiVe, @SoLuongDangKy, @SoLuongNhan, @ThanhTien", parameters);
        }
    }
}
