using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class CT_PHIEUTRAVE_BUS
    {
        CT_PHIEUTRAVE_DAO _CT_PHIEUTRAVE_DAO = null;
        CheckError _CheckError = null;
        public CT_PHIEUTRAVE_BUS()
        {
            _CT_PHIEUTRAVE_DAO = new CT_PHIEUTRAVE_DAO();
        }
        public List<CT_PHIEUTRAVE_VIEW> SelectView(string maphieutrave)
        {
            return _CT_PHIEUTRAVE_DAO.SelectView(maphieutrave);
        }
        public string CheckBeforeInsert(string maphieutrave, string macongtyphathanh, string madotphathanh, string maloaive, string sovenhan, string sovetra, string sotienphaitra)
        {
            _CheckError = new CheckError();
            int SoLuongTra = 0, SoLuongNhan;
            decimal ThanhTien = 0;
            SoLuongNhan = int.Parse(sovenhan);
            if (sotienphaitra == "")
            {
                _CheckError.CheckErrorAvailable("Số vé trả");
            }
            else
            {
                try
                {
                    SoLuongTra = int.Parse(sovetra);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số vé trả");
                }
            }
            if (sotienphaitra == "")
            {
                _CheckError.CheckErrorAvailable("Số tiền phải trả");
            }
            else
            {
                try
                {
                    ThanhTien = decimal.Parse(sotienphaitra);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số tiền phải trả");
                }
            }
            if (!_CheckError.IsError())
            {
                return "";
            }
            else
                return _CheckError.GetError();
        }
        public void Insert(string maphieutrave, string macongtyphathanh, string madotphathanh, string maloaive, string sovenhan, string sovetra, string sotienphaitra)
        {

            int SoLuongTra = 0, SoLuongNhan;
            decimal ThanhTien = 0;
            SoLuongNhan = int.Parse(sovenhan);
            SoLuongTra = int.Parse(sovetra);
            ThanhTien = decimal.Parse(sotienphaitra);
            CT_PHIEUTRAVE _CT_PHIEUTRAVE = new CT_PHIEUTRAVE(maphieutrave, macongtyphathanh, madotphathanh, maloaive, SoLuongNhan, SoLuongTra, ThanhTien);
            _CT_PHIEUTRAVE_DAO.Insert(_CT_PHIEUTRAVE);
        }
    }
}
