using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class CT_PHIEUNHANVE_BUS
    {
        CT_PHIEUNHANVE_DAO _CT_PHIEUNHANVE_DAO = null;
        CheckError _CheckError = null;
        public CT_PHIEUNHANVE_BUS()
        {
            _CT_PHIEUNHANVE_DAO = new CT_PHIEUNHANVE_DAO();
        }
        public void UpdateDaTra(string maphieunhanve, string macongty, string madotphathanh, string maloaive)
        {
            _CT_PHIEUNHANVE_DAO.UpdateDaTra(maphieunhanve, macongty, madotphathanh, maloaive);
        }
        public List<CT_PHIEUNHANVE> Select(string maphieunhanve)
        {
            return _CT_PHIEUNHANVE_DAO.Select(maphieunhanve);
        }
        public List<CT_PHIEUNHANVE_VIEW> SelectReCeiveView(string maphieunhanve)
        {
            return _CT_PHIEUNHANVE_DAO.SelectReCeiveView(maphieunhanve);
        }
        public List<CT_PHIEUNHANVE_VIEW> SelectNotPayView(string maphieunhanve)
        {
            return _CT_PHIEUNHANVE_DAO.SelectNotPayView(maphieunhanve);
        }
        public string Insert(string maphieunhanve, string macongty, string madotphathanh, string maloaive, string soluongdk, string soluongnhan, string thanhtien)
        {
            _CheckError = new CheckError();
            int _SoLuongDangKy, _SoLuongNhan;
            decimal _ThanhTien = 0;
            _SoLuongDangKy = int.Parse(soluongdk);
            _SoLuongNhan = int.Parse(soluongnhan);
            if (thanhtien == "")
            {
                _CheckError.CheckErrorAvailable("Thành tiền");
            }
            else
            {
                try
                {
                    _ThanhTien = decimal.Parse(thanhtien);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Thành tiền");
                }
            }
            if (soluongnhan == "")
            {
                _CheckError.CheckErrorAvailable("Số lượng nhận");
            }
            else
            {
                try
                {
                    _ThanhTien = decimal.Parse(thanhtien);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số lượng nhận");
                }
            }
            if (!_CheckError.IsError())
            {
                CT_PHIEUNHANVE _CT_PHIEUNHANVE = new CT_PHIEUNHANVE(maphieunhanve, macongty, madotphathanh, maloaive, _SoLuongDangKy, _SoLuongNhan, _ThanhTien);
                 _CT_PHIEUNHANVE_DAO.Insert(_CT_PHIEUNHANVE);
                return "";
            }
            else
                return _CheckError.GetError();
        }
        public void Delete(string machitietnhan,string maphieunhanve, string maphieudangky,string macongty, string madotphathanh, string maloaive, string soluongdk,  string soluongnhan, string thanhtien)
        {
              _CheckError = new CheckError();
            int _SoLuongDangKy, _SoLuongNhan;
            decimal _ThanhTien = 0;
            _SoLuongDangKy = int.Parse(soluongdk);
            _SoLuongNhan = int.Parse(soluongnhan);
            if (thanhtien == "")
            {
                _CheckError.CheckErrorAvailable("Số tiền trúng");
            }
            else
            {
                try
                {
                    _ThanhTien = decimal.Parse(thanhtien);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số tiền trúng");
                }
            }
            if (!_CheckError.IsError())
            {
                CT_PHIEUNHANVE _CT_PHIEUNHANVE = new CT_PHIEUNHANVE(maphieunhanve, macongty, madotphathanh, maloaive, _SoLuongDangKy, _SoLuongNhan, _ThanhTien, machitietnhan);
                _CT_PHIEUNHANVE_DAO.Delete(_CT_PHIEUNHANVE, maphieudangky);
            }
        }
        public float PercentageAmountofTicketReceive(string macongtyphathanh, string madotphathanh, string maloaive)
        {
            return _CT_PHIEUNHANVE_DAO.PercentageAmountofTicketReceive(macongtyphathanh, madotphathanh, maloaive);
        }
    }
}
