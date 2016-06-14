using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    class CT_KEHOACHPHATHANH_DAO
    {
         XoSoKienThietDbContext _Context = null;
        public CT_KEHOACHPHATHANH_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public void Insert(CT_KEHOACHPHATHANH ct_kehoach)
        {
             object[] parameters = 
            {
                new SqlParameter("@MaKeHoachPhatHanh", ct_kehoach.MaKeHoachPhatHanh),
                new SqlParameter("@MaLoaiVe", ct_kehoach.MaLoaiVe),
                new SqlParameter("@SoVePhatHanhDuKien", ct_kehoach.SoVePhatHanhDuKien),
                new SqlParameter("@SoVePhatHanhThucTe", ct_kehoach.SoVePhatHanhThucTe)
            };
             _Context.Database.ExecuteSqlCommand(@"CT_KEHOACHPHATHANH_Ins @MaKeHoachPhatHanh, @MaLoaiVe,
                                                                                @SoVePhatHanhDuKien,@SoVePhatHanhThucTe", parameters);
        }
    }
}
