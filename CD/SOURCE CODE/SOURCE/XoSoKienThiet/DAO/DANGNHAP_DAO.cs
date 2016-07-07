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
    public class DANGNHAP_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public DANGNHAP_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public THONGTINDANGNHAP GetMaBoPhan(string username, string password)
        {
            var UserName = new SqlParameter("@UserName", SqlDbType.NChar, 10)
            {
                Value = username
            };
            var PassWord = new SqlParameter("@PassWord", SqlDbType.NChar, 10)
            {
                Value = password
            };
            var MaBoPhan = new SqlParameter("@MaBoPhan", SqlDbType.NChar, 10)
            {
                Direction = ParameterDirection.Output
            };
            var TenNhanVien = new SqlParameter("@TenNhanVien", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Output
            };
            var TenBoPhan = new SqlParameter("@TenBoPhan", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.Output
            };
            var ID = new SqlParameter("@ID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            _Context.Database.ExecuteSqlCommand("TAIKHOAN_GetInformation @UserName, @PassWord ,@MaBoPhan out,@TenNhanVien out, @TenBoPhan out, @ID out", UserName, PassWord, MaBoPhan, TenNhanVien, TenBoPhan,ID);

            try
            {
                return new THONGTINDANGNHAP(MaBoPhan.Value.ToString(), TenNhanVien.Value.ToString(), TenBoPhan.Value.ToString(), int.Parse(ID.Value.ToString()));
            }
            catch (Exception)
            {
                return null;
            }
          
        }
        public void Update(int id, string pass)
        {
            object[] parameters = 
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@Pass", pass)
            };
            _Context.Database.ExecuteSqlCommand("TAIKHOAN_Upd @ID, @Pass", parameters);
        }
    }
     public class THONGTINDANGNHAP
    {
         public string TenNhanVien;
         public string MaBoPhan;
         public string TenBoPhan;
         public int ID;
         public THONGTINDANGNHAP(string mabophan, string tennhanvien, string tenbophan, int ID)
         {
             this.MaBoPhan = mabophan;
             this.TenNhanVien = tennhanvien;
             this.TenBoPhan = tenbophan;
             this.ID = ID;
         }
    }
}
