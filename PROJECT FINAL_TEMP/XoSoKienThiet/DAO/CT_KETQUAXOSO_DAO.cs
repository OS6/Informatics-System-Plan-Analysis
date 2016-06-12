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
    class CT_KETQUAXOSO_DAO
    {
         XoSoKienThietDbContext _Context = null;
         public CT_KETQUAXOSO_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public string Insert(CT_KETQUAXOSO ct_ketqua)
         {
             var MaKetQuaXoSo = new SqlParameter("@MaKetQuaXoSo", SqlDbType.NChar, 10)
             {
                 Value = ct_ketqua.MaKetQuaXoSo
             };
             var MaGiaiThuong = new SqlParameter("@MaGiaiThuong", SqlDbType.NChar, 10)
             {
                 Value = ct_ketqua.MaGiaiThuong
             };
             var SoLuongVeTrung = new SqlParameter("@SoLuongVeTrung", SqlDbType.Int)
             {
                 Value = ct_ketqua.SoLuongVeTrung
             };
             var TongTien = new SqlParameter("@TongTien", SqlDbType.Decimal)
             {
                 Value = ct_ketqua.TongTien
             };
             var MaChiTietKQXS = new SqlParameter("@MaChiTietKQXS", SqlDbType.NChar, 10)
             {
                 Direction = ParameterDirection.Output
             };

             _Context.Database.ExecuteSqlCommand("CT_KETQUAXOSO_Ins @MaKetQuaXoSo, @MaGiaiThuong, @SoLuongVeTrung, @TongTien,@MaChiTietKQXS  out", 
                                                                    MaKetQuaXoSo, MaGiaiThuong, SoLuongVeTrung, TongTien, MaChiTietKQXS);
             return MaChiTietKQXS.Value.ToString();
         }

        public void Update(string mact_ketqua, string madssotrung)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaChiTietKQXS", mact_ketqua),
                new SqlParameter("@MaDanhSachVeTrung", madssotrung)
            };
            _Context.Database.ExecuteSqlCommand("CT_KETQUAXOSO_Update @MaChiTietKQXS, @MaDanhSachVeTrung", parameters);
        }
    }
}
