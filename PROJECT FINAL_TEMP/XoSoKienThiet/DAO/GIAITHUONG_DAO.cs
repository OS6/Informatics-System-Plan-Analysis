using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    public class GIAITHUONG_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public GIAITHUONG_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<GIAITHUONG> Select(string maloaive)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaLoaiVe", maloaive)
            };
            return _Context.Database.SqlQuery<GIAITHUONG>("GIAITHUONG_Sel @MaLoaiVe", parameters).ToList();
        }
        public void Insert_Update(GIAITHUONG giaithuong)
        {
            if (giaithuong.MaGiaiThuong == "")
            {
                object[] parameters = 
            {
                new SqlParameter("@MaLoaiVe", giaithuong.MaLoaiVe),
                new SqlParameter("@Ten", giaithuong.Ten),
                new SqlParameter("@SoTienTrung",giaithuong.SoTienTrung),
                new SqlParameter("@SoGiai", giaithuong.SoGiai)
            };
                _Context.Database.ExecuteSqlCommand("GIAITHUONG_Ins @MaLoaiVe, @Ten, @SoTienTrung, @SoGiai", parameters);
            }
            else
            {

                object[] parameters = 
            {
                new SqlParameter("@MaGiaiThuong", giaithuong.MaGiaiThuong),
                new SqlParameter("@Ten", giaithuong.Ten),
                new SqlParameter("@SoTienTrung", giaithuong.SoTienTrung),
                new SqlParameter("@SoGiai", giaithuong.SoGiai)
            };
                _Context.Database.ExecuteSqlCommand("GIAITHUONG_Upd @MaGiaiThuong, @Ten, @SoTienTrung, @SoGiai", parameters);
            }
        }
    }
}
