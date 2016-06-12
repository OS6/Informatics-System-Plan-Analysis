using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class PHIEUCHI_BUS
    {
        PHIEUCHI_DAO _PHIEUCHI_DAO = null;
        CheckError _CheckError = null;
        public PHIEUCHI_BUS()
        {
            _PHIEUCHI_DAO = new PHIEUCHI_DAO();
            _CheckError = new CheckError();
        }
        public string Insert(string madotphathanh, string madonvi,string manhanvienlap, string ngaylap, string noidungchi, string sotienchi)
        {
            _CheckError = new CheckError();
            DateTime NgayLap;
            int SoTienChi = 0;
            if (madotphathanh == "")
            {
                _CheckError.CheckErrorAvailable("Đợt phát hành");
            }
            if (madonvi == "")
            {
                _CheckError.CheckErrorAvailable("Đơn vị");
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
                    NgayLap = Convert.ToDateTime(ngaylap);
                }
                catch (Exception)
                {
                }
            }
            if (noidungchi == "")
            {
                _CheckError.CheckErrorAvailable("Nội dung chi");
            }
            else
            {
                if (CheckSpecialString.KT_ChuoiKiTuDacBiet(noidungchi) == false)
                    _CheckError.CheckErrorCharacter("Nội dung chi");
            }
            if (sotienchi == "")
            {
                _CheckError.CheckErrorAvailable("Số tiền chi");
            }
            else 
            {
                try
                {
                    SoTienChi = int.Parse(sotienchi);
                    if(SoTienChi <= 0)
                    {
                        _CheckError.CheckErrorConstraint("Số tiền chi phải lớn hơn 0");
                    }
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số tiền chi");
                }
            }
            if (!_CheckError.IsError())
            {
                PHIEUCHI PHIEUCHI = new PHIEUCHI(madotphathanh, madonvi, manhanvienlap,Convert.ToDateTime(ngaylap), noidungchi, SoTienChi);
                _PHIEUCHI_DAO.Insert(PHIEUCHI);
                return "";
            }
            else
                return _CheckError.GetError();
        }
    }
}
