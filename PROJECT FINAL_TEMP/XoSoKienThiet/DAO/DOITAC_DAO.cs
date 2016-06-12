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
        public List<DOITAC> Select(string madoitac = "")
        {
            var MaDoiTac = new SqlParameter("@MaDoiTac", madoitac);
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel @MaDoiTac",MaDoiTac).ToList();
        }

        public float GetPercentagenDot(string madoitac, int sodot)
        {
            var MaDoiTac = new SqlParameter("@MaDoiTac", SqlDbType.NChar, 10)
            {
                Value = madoitac
            };
            var SoDot = new SqlParameter("@SoDot", SqlDbType.Int)
            {
                Value = sodot
            };
            var TiLe = new SqlParameter("@TiLe", SqlDbType.Float)
            {
                Direction = ParameterDirection.Output
            };

            _Context.Database.ExecuteSqlCommand("DOITAC_GetPercentageN @MaDoiTac, @SoDot,@TiLe out", MaDoiTac, SoDot, TiLe);

            return float.Parse(TiLe.Value.ToString()); 
        }
        public List<DOITAC> SelectAgency()
        {
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel_Agency").ToList();
        }

        public List<DOITAC> SelectCompany()
        {
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel_Company").ToList();
        }
        public List<DOITAC> SelectYourCompany()
        {
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel_YourCompany").ToList();
        }

        public List<DOITAC> SelectNotYourCompany()
        {
            return _Context.Database.SqlQuery<DOITAC>("DOITAC_Sel_Not_YourCompany").ToList();
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