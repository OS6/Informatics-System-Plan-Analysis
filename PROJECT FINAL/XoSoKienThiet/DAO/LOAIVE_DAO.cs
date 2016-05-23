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
    class LOAIVE_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public LOAIVE_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<LOAIVE> Select()
        {
            return _Context.Database.SqlQuery<LOAIVE>("LOAIVE_Sel").ToList();
        }

        // Lay loai ve cua cong ty minh

        public List<LOAIVE> SelectYourCompany()
        {
            return _Context.Database.SqlQuery<LOAIVE>(" LOAIVE_Sel_YourCompany ").ToList();
        }
        public List<LOAIVE> Select_Con_Company(string macongty)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaCongTy", macongty)
            };
            return _Context.Database.SqlQuery<LOAIVE>(" LOAIVE_Sel_Con_Company @MaCongTy", parameters).ToList();
        }
        public int Insert(LOAIVE loaive)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaCongTy", loaive.MaCongty),
                new SqlParameter("@MenhGia", loaive.MenhGia)
            };
            return _Context.Database.ExecuteSqlCommand("LOAIVE_Ins @MaCongTy, @MenhGia", parameters);
        }
        public List<LOAIVE> GetTypeofTicketnotInCompany(string macongty)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaCongTy", macongty)
            };
            return _Context.Database.SqlQuery<LOAIVE>("GetTypeofTicketnotInCompany @MaCongTy", parameters).ToList();
        }

        public string GetID(int menhgia)
        {
            var _MenhGia = new SqlParameter("@MenhGia", SqlDbType.Int)
            {
                Value = menhgia
            };
            var _MaLoaiVe = new SqlParameter("@MaLoaiVe", SqlDbType.NChar, 10)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("LOAIVE_GetID @MenhGia, @MaLoaiVe out", _MenhGia, _MaLoaiVe);

            return (string)_MaLoaiVe.Value;
        }

        public List<int> GetPrice(string macongty, string maloaive)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaCongTy", macongty),
                new SqlParameter("@MaLoaiVe", maloaive)
            };
           return  _Context.Database.SqlQuery<int>("LOAIVE_GetPrice @MaCongTy, @MaLoaiVe", parameters).ToList();
        }
    }
}
