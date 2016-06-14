using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    class CT_PHIEUTRAVE_DAO
    {
         XoSoKienThietDbContext _Context = null;
         public CT_PHIEUTRAVE_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

         public int Insert(CT_PHIEUTRAVE ct_phieutrave)
         {
             object[] parameters = 
            {
                new SqlParameter("@MaPhieuTraVe", ct_phieutrave.MaPhieuTraVe),
                new SqlParameter("@MaCongTyPhatHanh", ct_phieutrave.MaCongTyPhatHanh),
                new SqlParameter("@MaDotPhatHanh", ct_phieutrave.MaDotPhatHanh),
                new SqlParameter("@MaLoaiVe",ct_phieutrave.MaLoaiVe),
                new SqlParameter("@SoVeNhan", ct_phieutrave.SoVeNhan),
                new SqlParameter("@SoVeTra",ct_phieutrave.SoVeTra),
                new SqlParameter("@SoTienPhaiTra", ct_phieutrave.SoTienPhaiTra)
            };
             return _Context.Database.ExecuteSqlCommand("CT_PHIEUTRAVE_Ins @MaPhieuTraVe,@MaCongTyPhatHanh, @MaDotPhatHanh, @MaLoaiVe, @SoVeNhan, @SoVeTra, @SoTienPhaiTra", parameters);
         }
        public List<CT_PHIEUTRAVE_VIEW> SelectView(string maphieutrave) //\lấy danh sách chi tiết phieeui trả vé đã trả theo mã phiếu trả vé
        {
             object[] parameters = 
            {
                new SqlParameter("@MaPhieuTraVe", maphieutrave)
            };
             return _Context.Database.SqlQuery<CT_PHIEUTRAVE_VIEW>("CT_PHIEUTRAVE_VIEW_Sel @MaPhieuTraVe",parameters).ToList();
        }
    }
}
