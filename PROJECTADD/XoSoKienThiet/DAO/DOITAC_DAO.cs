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
    public class DOITAC_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public DOITAC_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }

        public List<DOITAC> Select()
        {
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel").ToList();
        }
        public List<DOITAC> SelectCompany()
        {
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel_Company").ToList();
        }

        public List<DOITAC> SelectAgency()
        {
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel_Agency").ToList();
        }
        public int Insert_Update(DOITAC doitac, string madoitac = null)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaLoaiDoiTac", doitac.MaLoaiDoiTac),
                new SqlParameter("@Ten", doitac.Ten),
                new SqlParameter("@DiaChi", doitac.DiaChi),
                new SqlParameter("@SDT", doitac.SDT),
                new SqlParameter("@Email",doitac.Email),
                new SqlParameter("@TiLeHoaHong", doitac.TiLeHoaHong)
            };

            if (madoitac != null)
            {
                object[] parametersUpd = 
                {
                    new SqlParameter("@MaDoiTac", madoitac),
                    new SqlParameter("@MaLoaiDoiTac", doitac.MaLoaiDoiTac),
                    new SqlParameter("@Ten", doitac.Ten),
                    new SqlParameter("@DiaChi", doitac.DiaChi),
                    new SqlParameter("@SDT", doitac.SDT),
                    new SqlParameter("@Email",doitac.Email),
                    new SqlParameter("@TiLeHoaHong", doitac.TiLeHoaHong)
                };
                return _Context.Database.ExecuteSqlCommand("DOITAC_Upd @MaDoiTac, @MaLoaiDoiTac, @Ten, @DiaChi, @SDT, @Email, @TiLeHoaHong", parametersUpd);
            }
            else
            {
                return _Context.Database.ExecuteSqlCommand("DOITAC_Ins @MaLoaiDoiTac, @Ten, @DiaChi, @SDT, @Email, @TiLeHoaHong", parameters);
            }
        }
        public int Delete(string madoitac)
        {
            var _MaDoiTac = new SqlParameter("@MaDoiTac", madoitac);
            return _Context.Database.ExecuteSqlCommand("DOITAC_Del @MaDoiTac", _MaDoiTac);
        }
        public string GetMaDoiTac(string tendoitac)
        {
            var _Ten = new SqlParameter("@Ten", SqlDbType.NVarChar, 20)
            {
                Value = tendoitac
            };
            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("DOITAC_GetID @Ten, @MaDoiTac out", _Ten, _MaDoiTac);

            return (string)_MaDoiTac.Value;
        }
    }
}