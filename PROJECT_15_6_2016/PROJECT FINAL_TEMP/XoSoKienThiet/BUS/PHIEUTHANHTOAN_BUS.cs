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
        public List<PHIEUTHANHTOAN> Select(string madoitac = "")
        {
            return _PHIEUTHANHTOAN_DAO.Select(madoitac);
        }
        public string Insert(string madoitac, string madotphathanh, string sotienno, string sotienthu,
                            string sotienconlai, string ngaylap, string manhanvienlap, string tennguoinop, 
                            string sdt, string diachi, string email)
        {
            _CheckError = new CheckError();
            decimal SoTienNo = 0, SoTienThu = 0, SoTienConLai = 0;
            DateTime NgayLap;
            if (madoitac == "")
            {
                _CheckError.CheckErrorAvailable("Mã đối tác");
            }
            if (madotphathanh == "")
            {
                _CheckError.CheckErrorAvailable("Đợt phát hành");
            }
         
            if (sotienno == "")
            {
                _CheckError.CheckErrorAvailable("Số tiền nợ");
            }
            else
            {
                try
                {
                    SoTienNo = Convert.ToDecimal(sotienno);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Số tiền nợ");
                }
            }
            if (sotienthu == "")
            {
                _CheckError.CheckErrorAvailable("Số tiền thu");
            }
            else
            {
                try
                {
                    SoTienThu = Convert.ToDecimal(sotienthu);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Số tiền thu");
                }
            }
            if (sotienconlai == "")
            {
                _CheckError.CheckErrorAvailable("Số tiền còn lại");
            }
            else
            {
                try
                {
                    SoTienConLai = Convert.ToDecimal(sotienconlai);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Số tiền còn lại");
                }
            }
            if(ngaylap == "")
            {
                _CheckError.CheckErrorAvailable("Ngày lập");
            }
            else
            {
                try
                {
                    NgayLap = Convert.ToDateTime(ngaylap);
                }
                catch (Exception)
                {
                }
            }
            if (manhanvienlap == "")
            {
                _CheckError.CheckErrorAvailable("Nhân viên lập");
            }
            if (tennguoinop == "")
            {
                _CheckError.CheckErrorAvailable("Tên người nộp");
            }
            else
            {
                if (CheckSpecialString.KT_ChuoiKiTuDacBiet(tennguoinop) == false)
                    _CheckError.CheckErrorCharacter("Tên người nộp");
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
            if (diachi == "")
            {
                _CheckError.CheckErrorAvailable("Địa chỉ");
            }
            if (email == "")
            {
                _CheckError.CheckErrorAvailable("Email");
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
