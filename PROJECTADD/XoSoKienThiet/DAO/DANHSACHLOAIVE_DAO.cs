using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    class DANHSACHLOAIVE_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public DANHSACHLOAIVE_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

        public List<LOAIVE> Select(string madoitac)
        {
            var _MaDoiTac = new SqlParameter("@MaCongTy", madoitac);
            return _Context.Database.SqlQuery<LOAIVE>("DANHSACHLOAIVE_Sel @MaCongTy", _MaDoiTac).ToList();
        }

        public int Insert(DANHSACHLOAIVE danhsach)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaCongTy", danhsach.MaCongTy),
                new SqlParameter("@MaLoaiVe", danhsach.MaLoaiVe)
            };
            return _Context.Database.ExecuteSqlCommand("DANHSACHLOAIVE_Ins @MaCongTy, @MaLoaiVe", parameters);
        }
    }
}
