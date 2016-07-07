using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class PHIEUTRAVE_BUS
    {
        PHIEUTRAVE_DAO _PHIEUTRAVE_DAO = null;
        CheckError _CheckError = null;
        public PHIEUTRAVE_BUS() 
        {
            _PHIEUTRAVE_DAO = new PHIEUTRAVE_DAO();
        }

        public string CheckBeforeInsert(string maphieunhanve, string manhanvienlap, string ngaylap, string tongsovetra, string tongtienphaitra)
        {
            DateTime _NgayLap = DateTime.Now;
            int TongSoVeTra = 0;
            decimal TongTienTra = 0;

            TongSoVeTra = int.Parse(tongsovetra);
            _CheckError = new CheckError();

            if (maphieunhanve == "")
            {
                _CheckError.CheckErrorAvailable("Mã phiếu nhận vé");
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
            if (tongtienphaitra == "")
            {
                _CheckError.CheckErrorAvailable("Tổng tiền phải trả");
            }
            else
            {
                try
                {
                    TongTienTra = decimal.Parse(tongtienphaitra);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Tổng tiền phải trả");
                }
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
        public string Insert(string maphieunhanve, string manhanvienlap, string ngaylap, string tongsovetra, string tongtienphaitra)
        {
            DateTime _NgayLap = DateTime.Now;
            int TongSoVeTra = 0;
            decimal TongTienTra = 0;

            TongSoVeTra = int.Parse(tongsovetra);
            _CheckError = new CheckError();

            if (maphieunhanve == "")
            {
                _CheckError.CheckErrorAvailable("Mã phiếu nhận vé");
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
            if (tongtienphaitra == "")
            {
                _CheckError.CheckErrorAvailable("Tổng tiền phải trả");
            }
            else
            {
                try
                {
                    TongTienTra = decimal.Parse(tongtienphaitra);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Tổng tiền phải trả");
                }
            }
            if (_CheckError.IsError())
            {
                return _CheckError.GetError();
            }
            else
            {
                PHIEUTRAVE PHIEUTRAVE = new PHIEUTRAVE(maphieunhanve, manhanvienlap, _NgayLap, TongSoVeTra, TongTienTra);
                return _PHIEUTRAVE_DAO.Insert(PHIEUTRAVE);
            }
        }
    }
}
