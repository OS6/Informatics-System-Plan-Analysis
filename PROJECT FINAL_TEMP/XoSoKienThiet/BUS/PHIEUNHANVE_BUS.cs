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
        public string Insert(string maphieudangky, string tongsove, string ngaylap, string manhanvienlap, string tongtien)
        {
            DateTime _NgayLap = DateTime.Now;
            int _TongSoVe;
            decimal _TongTien = 0;

            _TongSoVe = int.Parse(tongsove);
            _CheckError = new CheckError();

            if (maphieudangky == "")
            {
                _CheckError.CheckErrorAvailable("Mã phiếu đăng ký");
            }

            if (manhanvienlap == "")
            {
                _CheckError.CheckErrorAvailable("Nhân viên lập");
            }

            if (ngaylap == "")
            {
                _CheckError.CheckErrorAvailable("Ngày lập");
            }
            else
            {
                try
                {
                    _NgayLap = Convert.ToDateTime(ngaylap);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorConstraint("Ngày lập nhập chưa đúng");
                }
            }
            if (tongtien == "")
            {
                _CheckError.CheckErrorAvailable("Số tiền trúng");
            }
            else
            {
                try
                {
                    _TongTien = decimal.Parse(tongtien);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số tiền trúng");
                }
            }
            if (_CheckError.IsError())
            {
                return _CheckError.GetError();
            }
            else
            {
                PHIEUNHANVE _PHIEUNHANVE = new PHIEUNHANVE(maphieudangky, _TongSoVe, _NgayLap, manhanvienlap, _TongTien);
                return _PHIEUNHANVE_DAO.Insert(_PHIEUNHANVE);
            }
        }
        public string CheckBeforeInsert(string maphieudangky, string tongsove, string ngaylap, string manhanvienlap, string tongtien)
        {
            DateTime _NgayLap = DateTime.Now;
            int _TongSoVe;
            decimal _TongTien = 0;

            _TongSoVe = int.Parse(tongsove);
            _CheckError = new CheckError();

            if (maphieudangky == "")
            {
                _CheckError.CheckErrorAvailable("Mã phiếu đăng ký");
            }

            if (manhanvienlap == "")
            {
                _CheckError.CheckErrorAvailable("Nhân viên lập");
            }

            if (ngaylap == "")
            {
                _CheckError.CheckErrorAvailable("Ngày lập");
            }
            else
            {
                try
                {
                    _NgayLap = Convert.ToDateTime(ngaylap);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorConstraint("Ngày lập nhập chưa đúng");
                }
            }
            if (tongtien == "")
            {
                _CheckError.CheckErrorAvailable("Số tiền trúng");
            }
            else
            {
                try
                {
                    _TongTien = decimal.Parse(tongtien);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số tiền trúng");
                }
            }
            if (_CheckError.IsError())
            {
                return _CheckError.GetError();
            }
            else
            {
                PHIEUNHANVE _PHIEUNHANVE = new PHIEUNHANVE(maphieudangky, _TongSoVe, _NgayLap, manhanvienlap, _TongTien);
                return "";
            }
        }
    }
}
