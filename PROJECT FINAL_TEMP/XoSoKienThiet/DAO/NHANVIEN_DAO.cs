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

        public List<NHANVIEN_VIEW> SelectView()
        {
            return _Context.Database.SqlQuery<NHANVIEN_VIEW>("NHANVIEN_VIEW_Sel").ToList();
        }
        public void Insert_Update(NHANVIEN nhanvien)
        {
            if (nhanvien.MaNhanVien == "")
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
            else
            {
                object[] parameters = 
            {
                new SqlParameter("@MaNhanVien", nhanvien.MaNhanVien),
                new SqlParameter("@Ten", nhanvien.Ten),
                new SqlParameter("@SDT", nhanvien.SDT),
                new SqlParameter("@DiaChi", nhanvien.DiaChi),
                 new SqlParameter("@Email", nhanvien.Email),
                new SqlParameter("@MaCoCauToChuc",nhanvien.MaCoCauToChuc)
            };
                _Context.Database.ExecuteSqlCommand("NHANVIEN_Upd @MaNhanVien,@Ten, @SDT, @DiaChi,@Email, @MaCoCauToChuc", parameters);
            }
        }
    }
}
