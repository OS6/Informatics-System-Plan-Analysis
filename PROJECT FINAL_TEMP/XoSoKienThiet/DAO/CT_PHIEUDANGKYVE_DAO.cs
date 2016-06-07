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
    class CT_PHIEUDANGKYVE_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public CT_PHIEUDANGKYVE_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<CT_PHIEUDANGKYVE> Select(string maphieudangkyve)
        {
            var _MaPhieuDangKyVe = new SqlParameter("@MaPhieuDangKyVe", SqlDbType.NChar, 10)
            {
                Value = maphieudangkyve
            };

            return _Context.Database.SqlQuery<CT_PHIEUDANGKYVE>("CT_PHIEUDANGKYVE_Sel @MaPhieuDangKyVe ", _MaPhieuDangKyVe).ToList();
        }
        public int GetAmountOfRegisterTicket(string madoitac, string macongty, string madotphathanh, string maloaive)
        {
            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = madoitac
            };
            var _MaCongTy = new SqlParameter("@MaCongTy", SqlDbType.NChar, 10)
            {
                Value = macongty
            };
            var _MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = madotphathanh
            };
            var _MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar, 10)
            {
                Value = maloaive
            };
            var _SoVeDangKy = new SqlParameter("@SoVeDangKy", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("CT_PHIEUDANGKYVE_GetAmountOfRegisterTicket @MaDoiTac, @MaCongTy, @MaDotPhatHanh, @MaLoaiVe, @SoVeDangKy out",
                                                                                           _MaDoiTac, _MaCongTy, _MaDotPhatHanh, _MaLoaiVe, _SoVeDangKy);
            return Convert.ToInt32(_SoVeDangKy.Value.ToString());
        }

        public int GetAmountOfMaxRegisterTicket(string madoitac, string macongty, string madotphathanh, string maloaive)
        {
            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = madoitac
            };
            var _MaCongTy = new SqlParameter("@MaCongTy", SqlDbType.NChar, 10)
            {
                Value = macongty
            };
            var _MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = madotphathanh
            };
            var _MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar, 10)
            {
                Value = maloaive
            };
            var _SoVeDangKyToiDa = new SqlParameter("@SoVeDangKyToiDa", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("DOITAC_GetAmountOfMaxRegisterTicket @MaDoiTac, @MaCongTy, @MaDotPhatHanh, @MaLoaiVe, @SoVeDangKyToiDa out",
                                                                                     _MaDoiTac, _MaCongTy, _MaDotPhatHanh, _MaLoaiVe, _SoVeDangKyToiDa);
            return Convert.ToInt32(_SoVeDangKyToiDa.Value.ToString());
        }

        public int Insert(CT_PHIEUDANGKYVE ct_phieudangkyve)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaPhieuDangKyVe", ct_phieudangkyve.MaPhieuDangKy),
                new SqlParameter("@MaCongTy", ct_phieudangkyve.MaCongTy),
                new SqlParameter("@MaDotPhatHanh", ct_phieudangkyve.MaDotPhatHanh),
                new SqlParameter("@MaLoaiVe",ct_phieudangkyve.MaLoaiVe),
                new SqlParameter("@SoLuongDangKyToiDa", ct_phieudangkyve.SoVeDangKyToiDa),
                new SqlParameter("@SoLuongDangKy",ct_phieudangkyve.SoVeDangKy)
            };
            return _Context.Database.ExecuteSqlCommand("CT_PHIEUDANGKYVE_Ins @MaPhieuDangKyVe,@MaCongTy, @MaDotPhatHanh, @MaLoaiVe, @SoLuongDangKyToiDa, @SoLuongDangKy", parameters);
        }
    }
}
