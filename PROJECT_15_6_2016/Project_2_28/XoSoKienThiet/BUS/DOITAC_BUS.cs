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

        public List<DOITAC> Select(string madoitac = "")
        {
            return _DOITAC_DAO.Select(madoitac);
        }

        public List<DOITAC> SelectAgency()
        {
            return _DOITAC_DAO.SelectAgency();
        }

        public List<DOITAC> SelectCompany()
        {
            return _DOITAC_DAO.SelectCompany();
        }
        public List<DOITAC> SelectYourCompany()
        {
            return _DOITAC_DAO.SelectYourCompany();
        }
        public List<DOITAC> SelectNotYourCompany()
        {
            return _DOITAC_DAO.SelectNotYourCompany();
        }
        public bool IsYourCompany(string madoitac)
        {
            return _DOITAC_DAO.IsYourCompany(madoitac);
        }
        public string Insert_Update(string maloaidoitac, string ten, string diachi, string sdt, string email, string madoitac = "")
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
                                        email, madoitac);
                _DOITAC_DAO.Insert_UpDate(_DOITAC);
                return "";
            }
            else
                return _CheckError.GetError();
        }
        public string GetTenDoiTac(string madoitac)
        {
            return _DOITAC_DAO.GetTenDoiTac(madoitac);
        }
        // Tỉ lệ hoa hồng
        public float GetPercentage(string madoitac)
        {
            return _DOITAC_DAO.GetPercentage(madoitac);
        }
        //Công nợ
        public float GetDebt(string madoitac)
        {
            return _DOITAC_DAO.GetDebt(madoitac);
        }
        // Tỉ lệ tiêu thụ
        public float GetPercentageConsume(string madoitac)
        {
            return _DOITAC_DAO.GetPercentageConsume(madoitac);
        }
        // tỉ lệ tiêu thụ trung bình theo n đợt phát hành
        public float GetPercentagenDot(string madoitac, int sodot)
        {
            return _DOITAC_DAO.GetPercentagenDot(madoitac,sodot);
        }
        public void Update_Debt(string macongty, string congno)
        {
            int _CongNo = 0;
            try
            {
                _CongNo = int.Parse(congno);
            }
            catch
            {

            }
            _DOITAC_DAO.Update_Debt(macongty, _CongNo);
        }
    }
}
