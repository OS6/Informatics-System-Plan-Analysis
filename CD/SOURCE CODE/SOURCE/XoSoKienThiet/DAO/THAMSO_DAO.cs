using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{

    class THAMSO_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public THAMSO_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

        public void Update(THAMSO thamso)
        {
            object[] parameters = 
            {
                new SqlParameter("@TiLeTieuThuDat", thamso.TiLeTieuThuDat ),
                new SqlParameter("@TiLeTienItNhatTra",   thamso.TiLeTienItNhatTra),
                new SqlParameter("@TiLeHoaHongLanDau",  thamso.TiLeHoaHongLanDau),
                new SqlParameter("@TiLeHoaHongTang",  thamso.TiLeHoaHongTang),
                new SqlParameter("@TiLeHoaHongGiam", thamso.TiLeHoaHongGiam),
                new SqlParameter("@HanTraVe",   thamso.HanTraVe),
                new SqlParameter("@SoNgayNhanGiai",  thamso.SoNgayNhanGiai),
                new SqlParameter("@SoDotGanDay",  thamso.SoDotGanDay),
                new SqlParameter("@ChietKhauGiaTriGiaTang", thamso.ChietKhauGiaTriGiaTang )
            };
            _Context.Database.ExecuteSqlCommand(@"THAMSO_Upd @TiLeTieuThuDat, @TiLeTienItNhatTra, @TiLeHoaHongLanDau,
                                                            @TiLeHoaHongTang, @TiLeHoaHongGiam, @HanTraVe,
                                                            @SoNgayNhanGiai,@SoDotGanDay, @ChietKhauGiaTriGiaTang", parameters);
        }
        public List<THAMSO> Select()
        {
            return _Context.Database.SqlQuery<THAMSO>("THAMSO_Sel ").ToList();
        }
    }
}
