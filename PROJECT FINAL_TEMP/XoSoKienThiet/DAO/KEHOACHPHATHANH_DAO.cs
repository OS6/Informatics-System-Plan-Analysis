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
    class KEHOACHPHATHANH_DAO
    {
        XoSoKienThietDbContext _Context = null;
        LOAIVE_DAO _LOAIVE_DAO = null;
        public KEHOACHPHATHANH_DAO()
        {
            _Context = new XoSoKienThietDbContext();
            _LOAIVE_DAO = new LOAIVE_DAO();
        }

        public int GetAmountofTicketRegister(string madotphathanh, string maloaive)
        {
            var MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = madotphathanh
            };
            var MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar, 10)
            {
                Value = maloaive
            };
            var TongVeDuKien = new SqlParameter("@TongVeDuKien", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("KEHOACHPHATHANH_GetAmountofTicketRegister @MaDotPhatHanh, @MaLoaiVe, @TongVeDuKien out",
                                                                                          MaDotPhatHanh, MaLoaiVe, TongVeDuKien);

            return (int)TongVeDuKien.Value;
        }
        public int GetAmountofTicketMax(string madotphathanh, string maloaive)
        {
            var MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = madotphathanh
            };
            var MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar, 10)
            {
                Value = maloaive
            };
            var TongVeDuKien = new SqlParameter("@TongVeDuKien", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("KEHOACHPHATHANH_GetAmountofTicketMax @MaDotPhatHanh, @MaLoaiVe, @TongVeDuKien out",
                                                                                         MaDotPhatHanh, MaLoaiVe, TongVeDuKien);

            return (int)TongVeDuKien.Value;
        }
        public List<CT_KEHOACHPHATHANH_VIEW> Select(string madotphathanh)
        {
            var List_KeHoachPhatHanh = new List<CT_KEHOACHPHATHANH_VIEW>();
            var List_LoaiVe = _LOAIVE_DAO.SelectYourCompany();
            int TongVeDuKien = 0, TongVePhatHanh = 0;
            foreach (var item in List_LoaiVe)
            {
                var ct_kehoachphathanh = new CT_KEHOACHPHATHANH_VIEW();

                ct_kehoachphathanh.MaLoaiVe = item.MaLoaiVe;
                TongVeDuKien = GetAmountofTicketRegister(madotphathanh, item.MaLoaiVe);
                TongVePhatHanh = GetAmountofTicketMax(madotphathanh, item.MaLoaiVe);
                ct_kehoachphathanh.SoVePhatHanhDuKien = TongVeDuKien;
                ct_kehoachphathanh.SoVePhatHanhThucTe = TongVePhatHanh;
                ct_kehoachphathanh.MenhGia = int.Parse(_LOAIVE_DAO.GetPrice(item.MaLoaiVe).SingleOrDefault().ToString());
                List_KeHoachPhatHanh.Add(ct_kehoachphathanh);
            }
            return List_KeHoachPhatHanh;
        }

        public string Insert(KEHOACHPHATHANH kehoachphathanh)
        {
            var MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = kehoachphathanh.MaDotPhatHanh
            };
            var TongSoVePhatHanh = new SqlParameter("@TongSoVePhatHanh", SqlDbType.Int)
            {
                Value = kehoachphathanh.TongSoVePhatHanh
            };
            var MaKeHoachPhatHanh = new SqlParameter("@MaKeHoachPhatHanh", SqlDbType.NChar, 10)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("KEHOACHPHATHANH_Ins @MaDotPhatHanh, @TongSoVePhatHanh,@MaKeHoachPhatHanh out",
                                                                MaDotPhatHanh, TongSoVePhatHanh, MaKeHoachPhatHanh);
            return MaKeHoachPhatHanh.Value.ToString();
        }
    }
}
