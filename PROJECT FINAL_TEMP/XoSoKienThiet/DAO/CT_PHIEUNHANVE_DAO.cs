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
    class CT_PHIEUNHANVE_DAO
    {
         XoSoKienThietDbContext _Context = null;
         public CT_PHIEUNHANVE_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

         public List<CT_PHIEUNHANVE> Select(string maphieunhanve)
         {
             var _MaPhieuNhanVe = new SqlParameter("@MaPhieuNhanVe", SqlDbType.NChar, 10)
             {
                 Value = maphieunhanve
             };

             return _Context.Database.SqlQuery<CT_PHIEUNHANVE>("CT_PHIEUNHANVE_Sel @MaPhieuNhanVe ", _MaPhieuNhanVe).ToList();
         }
        public int Insert(CT_PHIEUNHANVE ct_phieunhanve)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaPhieuNhanVe", ct_phieunhanve.MaPhieuNhanVe),
                new SqlParameter("@MaCongTyPhatHanh", ct_phieunhanve.MaCongTyPhatHanh),
                new SqlParameter("@MaDotPhatHanh", ct_phieunhanve.MaDotPhatHanh),
                new SqlParameter("@MaLoaiVe",ct_phieunhanve.MaLoaiVe),
                new SqlParameter("@SoLuongDangKy", ct_phieunhanve.SoLuongDangKy),
                new SqlParameter("@SoLuongNhan",ct_phieunhanve.SoLuongNhan),
                new SqlParameter("@ThanhTien", ct_phieunhanve.ThanhTien)
            };
            return _Context.Database.ExecuteSqlCommand("CT_PHIEUNHANVE_Ins @MaPhieuNhanVe,@MaCongTyPhatHanh, @MaDotPhatHanh, @MaLoaiVe, @SoLuongDangKy, @SoLuongNhan, @ThanhTien", parameters);
        }
        public float PercentageAmountofTicketReceive(string macongtyphathanh, string madotphathanh, string maloaive)
        {
            var _MaCongTy = new SqlParameter("@MaCongTy", SqlDbType.NChar, 10)
            {
                Value = macongtyphathanh
            };
            var _MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = madotphathanh
            };
            var _MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar, 10)
            {
                Value = maloaive
            };

            var _TiLeNhanVe = new SqlParameter("@TiLeNhan", SqlDbType.Float)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("PHIEUNHANVE_Sel_PercentageAmountofTicketReceive @MaCongTy, @MaDotPhatHanh,@MaLoaiVe, @TiLeNhan out",
                                                                                                _MaCongTy, _MaDotPhatHanh, _MaLoaiVe, _TiLeNhanVe);

            return float.Parse(_TiLeNhanVe.Value.ToString()); // 
        }
    }
}
