using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class PHIEUNHANVE_BUS
    {
        PHIEUNHANVE_DAO _PHIEUNHANVE_DAO = null;
        CheckError _CheckError = null;
        public PHIEUNHANVE_BUS()
        {
            _PHIEUNHANVE_DAO = new PHIEUNHANVE_DAO();
            _CheckError = new CheckError();
        }

        public PHIEUNHANVE Select(string maphieunhanve)
        {
            return _PHIEUNHANVE_DAO.Select(maphieunhanve).SingleOrDefault();
        }
        public string Insert(string madoitac, string tongsove, string ngaylap, string manhanvienlap, string tongtien)
        {
            DateTime _NgayLap;
            int _TongSoVe;
            float _TongTien;
            _NgayLap = Convert.ToDateTime(ngaylap);
            _TongSoVe = int.Parse(tongsove);
            _TongTien = float.Parse(tongtien);

            PHIEUNHANVE _PHIEUNHANVE = new PHIEUNHANVE(madoitac, _TongSoVe, _NgayLap, manhanvienlap, _TongTien);
            return _PHIEUNHANVE_DAO.Insert(_PHIEUNHANVE);
        }
        public string CheckErrorBeforeInsert(string madoitac, string manhanvienlap, string ngaylap)
        {
            _CheckError = new CheckError();

            if (madoitac == "")
            {
                _CheckError.CheckErrorAvailable("Đối tác");
            }

            if (manhanvienlap == "<Null>") // do debug = "" no khong nhay vao if
            {
                _CheckError.CheckErrorAvailable("Nhân viên lập");
            }

            if (ngaylap == "")
            {
                _CheckError.CheckErrorAvailable("Ngày lập");
            }
            if (_CheckError.IsError())
            {
                return _CheckError.GetError();
            }
            else
            {
                return "";
            }
        }
    }
}
