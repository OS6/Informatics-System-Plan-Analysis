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
    class COCAUTOCHUC_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public COCAUTOCHUC_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

        public string GetID(string mabophan, string machucvu)
        {
            var _MaBoPhan = new SqlParameter("@MaBoPhan", SqlDbType.NVarChar, 20)
            {
                Value = mabophan
            };
            var _MaChucVu = new SqlParameter("@MaChucVu", SqlDbType.NVarChar, 20)
            {
                Value = machucvu
            };
             var _MaCoCauToChuc = new SqlParameter("@MaCoCauToChuc", SqlDbType.NChar, 10)
           {
               Direction = ParameterDirection.Output
           };
             _Context.Database.ExecuteSqlCommand("COCAUTOCHUC_GetID @MaBoPhan, @MaChucVu, @MaCoCauToChuc out", _MaBoPhan, _MaChucVu, _MaCoCauToChuc);

             return (string)_MaCoCauToChuc.Value;
            
        }
    }
}
