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
    public class LOAIDOITAC_DAO
    {
        XoSoKienThietDbContext _Context = null;

        public LOAIDOITAC_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<LOAIDOITAC> Select()
        {
            return _Context.Database.SqlQuery<LOAIDOITAC>("LOAIDOITAC_Sel").ToList();
        }

        public string GetMaLoaiDoiTac(string tendoitac)
        {
            var _Ten = new SqlParameter("@Ten", SqlDbType.NVarChar,20)
                {
                    Value = tendoitac
                };
            var _MaLoaiDoiTac = new SqlParameter("@MaLoaiDoiTac", SqlDbType.NChar,10)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("LOAIDOITAC_GetMaLoaiDoitac @Ten, @MaLoaiDoiTac out", _Ten, _MaLoaiDoiTac);

            return (string)_MaLoaiDoiTac.Value;
        }
        public string GetTenDoiTac(string loaidoitac)
        {
            var _MaLoaiDoiTac = new SqlParameter("@MaLoaiDoiTac", SqlDbType.NVarChar, 20)
            {
                Value = loaidoitac
            };
            var _Ten = new SqlParameter("@Ten", SqlDbType.NChar, 10)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("LOAIDOITAC_GetTenDoitac @MaLoaiDoiTac, @Ten out", _MaLoaiDoiTac, _Ten);

            return (string)_Ten.Value;
        }
       
    }
}
