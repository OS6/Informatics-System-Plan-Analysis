using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class DOITAC_BUS
    {
        DOITAC_DAO _DOITAC_DAO = null;
        CheckError _CheckError = null;
        public DOITAC_BUS()
        {
            _DOITAC_DAO = new DOITAC_DAO();
        }

        public List<DOITAC> SelectAgency()
        {
            return _DOITAC_DAO.SelectAgency();
        }

        public List<DOITAC> SelectCompany()
        {
            return _DOITAC_DAO.SelectCompany();
        }

        public string Insert(string maloaidoitac, string ten, string diachi, string sdt, string email)
        {
            _CheckError = new CheckError();
            if (ten == "")
            {
                _CheckError.CheckErrorAvailable("Tên đối tác");
            }
            else
            {
                if (CheckSpecialString.KT_ChuoiKiTuDacBiet(ten) == false)
                    _CheckError.CheckErrorCharacter("Tên đối tác");
            }

            if (diachi == "")
            {
                _CheckError.CheckErrorAvailable("Địa chỉ");
            }
            else
            {
                if (CheckSpecialString.KT_ChuoiKiTuDacBiet(diachi) == false)
                    _CheckError.CheckErrorCharacter("Địa chỉ");
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

            if (email == "")
            {
                _CheckError.CheckErrorAvailable("Email");
            }
            if (!_CheckError.IsError())
            {
                DOITAC _DOITAC = new DOITAC(maloaidoitac,
                                       ten,
                                        diachi,
                                        sdt,
                                        email);
                _DOITAC_DAO.Insert(_DOITAC);
                return "";
            }
            else
                return _CheckError.GetError();
        }
        public string GetMaDoiTac(string tendoitac)
        {
            return _DOITAC_DAO.GetMaDoiTac(tendoitac);
        }
    }
}
