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
        public List<DOITAC> SelectAgency()
        {
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel_Agency").ToList();
        }

        public List<DOITAC> SelectCompany()
        {
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel_Company").ToList();
        }
        public bool IsYourCompany(string madoitac)
        {
            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = madoitac
            };

            var _IsYourCompany = new SqlParameter("@IsYourCompany", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("DOITAC_IsYourCompany @MaDoiTac, @IsYourCompany out", _MaDoiTac, _IsYourCompany);

            return (bool)_IsYourCompany.Value;
        }
        public void Insert_UpDate(DOITAC doitac)
        {
            if (doitac.MaDoiTac == "")
            {
                object[] parameters = 
            {
                new SqlParameter("@MaLoaiDoiTac", doitac.MaLoaiDoiTac),
                new SqlParameter("@Ten", doitac.Ten),
                new SqlParameter("@DiaChi", doitac.DiaChi),
                new SqlParameter("@SDT", doitac.SDT),
                new SqlParameter("@Email",doitac.Email)
            };
                _Context.Database.ExecuteSqlCommand("DOITAC_Ins @MaLoaiDoiTac, @Ten, @DiaChi, @SDT, @Email", parameters);
            }
            else
            {
                object[] parameters = 
            {
                new SqlParameter("@MaDoiTac", doitac.MaDoiTac),
                new SqlParameter("@MaLoaiDoiTac", doitac.MaLoaiDoiTac),
                new SqlParameter("@Ten", doitac.Ten),
                new SqlParameter("@DiaChi", doitac.DiaChi),
                new SqlParameter("@SDT", doitac.SDT),
                new SqlParameter("@Email",doitac.Email)
            };
                _Context.Database.ExecuteSqlCommand("DOITAC_Upd @MaDoiTac, @MaLoaiDoiTac, @Ten, @DiaChi, @SDT, @Email", parameters);
            }

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

        public string GetTenDoiTac(string madoitac)
        {
            var _Ten = new SqlParameter("@Ten", SqlDbType.NVarChar, 100)
            {
                Direction = ParameterDirection.Output
            };
            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = madoitac
            };

            _Context.Database.ExecuteSqlCommand("DOITAC_GetName @MaDoiTac, @Ten out", _MaDoiTac, _Ten);

            return (string)_Ten.Value;
        }
        public float GetPercentage(string madoitac)
        {
            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = madoitac
            };
            var _TiLeHoaHong = new SqlParameter("@TiLeHoaHong", SqlDbType.Float)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("DOITAC_GetPercentage @MaDoiTac, @TiLeHoaHong out", _MaDoiTac, _TiLeHoaHong);

            return float.Parse(_TiLeHoaHong.Value.ToString()); // 
        }
        public float GetDebt(string madoitac)
        {
            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = madoitac
            };
            var _CongNo = new SqlParameter("@CongNo", SqlDbType.Float)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("DOITAC_GetDebt @MaDoiTac, @CongNo out", _MaDoiTac, _CongNo);

            return float.Parse(_CongNo.Value.ToString()); // 
        }
        public float GetPercentageConsume(string madoitac)
        {
            var _MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = madoitac
            };
            var _TiLeTieuThu = new SqlParameter("@TiLeTieuThu", SqlDbType.Float)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("DOITAC_GetPercentageConsume @MaDoiTac, @TiLeTieuThu out", _MaDoiTac, _TiLeTieuThu);

            return float.Parse(_TiLeTieuThu.Value.ToString());
        }
        // Cập nhật công nợ
        public void Update_Debt(string madoitac, int congno)
        {
            object[] parameters = 
            {
                new SqlParameter("@MaDoiTac", madoitac),
                new SqlParameter("@CongNo", congno)
            };
            _Context.Database.ExecuteSqlCommand("DOITAC_Upd_Debt @MaDoiTac, @CongNo", parameters);
        }
    }
}