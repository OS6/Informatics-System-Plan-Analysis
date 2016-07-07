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
    class KETQUAXOSO_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public KETQUAXOSO_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

        public List<CT_KQXS_GIAITHUONG_VIEW> Select(string madotphathanh, string maloaive, int sotrung)
        {
            var MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = madotphathanh
            };
            var MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar, 10)
            {
                Value = maloaive
            };
            var SoTrung = new SqlParameter("@SoTrung", SqlDbType.Int)
            {
                Value = sotrung
            };
            return _Context.Database.SqlQuery<CT_KQXS_GIAITHUONG_VIEW>("KETQUAXOSO_SearchResult @MaDotPhatHanh, @MaLoaiVe,@SoTrung",
                                                                                                MaDotPhatHanh, MaLoaiVe, SoTrung).ToList();
        }
        public string Insert(KETQUAXOSO ketqua)
        {
            var MaDotPhatHanh = new SqlParameter("@MaDotPhatHanh", SqlDbType.NChar, 10)
            {
                Value = ketqua.MaDotPhatHanh
            };
            var MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar, 10)
            {
                Value = ketqua.MaLoaiVe
            };
            var MaKetQuaXoSo = new SqlParameter("@MaKetQuaXoSo", SqlDbType.NChar, 10)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("KETQUAXOSO_Ins @MaDotPhatHanh, @MaLoaiVe, @MaKetQuaXoSo out", MaDotPhatHanh, MaLoaiVe, MaKetQuaXoSo);
            return MaKetQuaXoSo.Value.ToString();
        }
    }
}
