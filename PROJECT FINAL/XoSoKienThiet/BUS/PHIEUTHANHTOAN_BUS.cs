using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class PHIEUTHANHTOAN_BUS
    {
        PHIEUTHANHTOAN_DAO _PHIEUTHANHTOAN_DAO = null;
        CheckError _CheckError = null;
        public PHIEUTHANHTOAN_BUS()
        {
            _PHIEUTHANHTOAN_DAO = new PHIEUTHANHTOAN_DAO();
            _CheckError = new CheckError();
        }

        public string Insert(string madoitac, string madotphathanh, string sotienno, string sotienthu, string sotienconlai, string ngaylap, string manhanvienlap, string tennguoinop, string sdt, string diachi, string email)
        {
            _CheckError = new CheckError();
            if (tennguoinop == "")
            {
                _CheckError.CheckErrorAvailable("Tên đối tác");
            }
            else
            {
                if (CheckSpecialString.KT_ChuoiKiTuDacBiet(tennguoinop) == false)
                    _CheckError.CheckErrorCharacter("Tên đối tác");
            }
            if (sdt == "")
            {
                _CheckError.CheckErrorAvailable("Số điện thoại");
            }
            else
            {
                try
                {
                    int.Parse(sdt);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số điện thoại");
                }
            }
            if (!_CheckError.IsError())
            {
                PHIEUTHANHTOAN PHIEUTHANHTOAN = new PHIEUTHANHTOAN(
                                                                madoitac,
                                                                madotphathanh, 
                                                                Convert.ToDouble(sotienno), 
                                                                Convert.ToDouble(sotienthu), 
                                                                Convert.ToDouble(sotienconlai), 
                                                                Convert.ToDateTime(ngaylap), 
                                                                manhanvienlap, 
                                                                tennguoinop,
                                                                sotienno,
                                                                sdt,
                                                                email);
                _PHIEUTHANHTOAN_DAO.Insert(PHIEUTHANHTOAN);
                return "";
            }
            else
                return _CheckError.GetError();
        }
    }
}
