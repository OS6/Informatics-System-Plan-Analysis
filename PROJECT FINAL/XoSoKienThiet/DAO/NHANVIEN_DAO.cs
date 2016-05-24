using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.DAO
{
    public class NHANVIEN_DAO
    {
        XoSoKienThietDbContext _Context = null;
        public NHANVIEN_DAO()
        {
            _Context = new XoSoKienThietDbContext();
        }
        public List<NHANVIEN> Select()
        {
            return _Context.Database.SqlQuery<NHANVIEN>("NHANVIEN_Sel").ToList();
        }
        public void Insert(NHANVIEN nhanvien)
        {
            object[] parameters = 
            {
                new SqlParameter("@Ten", nhanvien.Ten),
                new SqlParameter("@SDT", nhanvien.SDT),
                new SqlParameter("@DiaChi", nhanvien.DiaChi),
                 new SqlParameter("@Email", nhanvien.Email),
                new SqlParameter("@MaCoCauToChuc",nhanvien.MaCoCauToChuc)
            };
            _Context.Database.ExecuteSqlCommand("NHANVIEN_Ins @Ten, @SDT, @DiaChi,@Email, @MaCoCauToChuc", parameters);
        }
    }
}
