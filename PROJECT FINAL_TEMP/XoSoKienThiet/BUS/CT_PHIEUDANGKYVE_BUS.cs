using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class CT_PHIEUDANGKYVE_BUS
    {
        CT_PHIEUDANGKYVE_DAO _CT_PHIEUDANGKYVE_DAO = null;
        CheckError _CheckError = null;
        public CT_PHIEUDANGKYVE_BUS()
        {
            _CT_PHIEUDANGKYVE_DAO = new CT_PHIEUDANGKYVE_DAO();
        }

        public List<CT_PHIEUDANGKYVE> Select(string maphieudangkyve)
        {
            return _CT_PHIEUDANGKYVE_DAO.Select(maphieudangkyve);
        }
        public List<CT_PHIEUDANGKYVE_VIEW> SelectView(string maphieudangkyve)
        {
            return _CT_PHIEUDANGKYVE_DAO.SelectView(maphieudangkyve);
        }
        public List<CT_PHIEUDANGKYVE_VIEW> SelectViewNotReCeive(string maphieudangkyve)
        {
            return _CT_PHIEUDANGKYVE_DAO.SelectViewNotReCeive(maphieudangkyve);
        }
        public void UpdateDaNhan(string maphieudangky, string congty, string madotphathanh, string maloaive)
        {
            _CT_PHIEUDANGKYVE_DAO.UpdateDaNhan(maphieudangky, congty, madotphathanh, maloaive);
        }
        public int GetAmountOfRegisterTicket(string madoitac, string macongty, string madotphathanh, string maloaive)
        {
            return _CT_PHIEUDANGKYVE_DAO.GetAmountOfRegisterTicket(madoitac, macongty, madotphathanh, maloaive);
        }
        public int GetAmountOfMaxRegisterTicket(string madoitac, string macongty, string madotphathanh, string maloaive)
        {
            return _CT_PHIEUDANGKYVE_DAO.GetAmountOfMaxRegisterTicket(madoitac, macongty, madotphathanh, maloaive);
        }
        public bool CheckRegister(string madoitac, string macongty, string madotphathanh, string maloaive)
        {
            return _CT_PHIEUDANGKYVE_DAO.CheckRegister(madoitac, macongty, madotphathanh, maloaive);
        }
        public int CaculateAmountofTickRegister(string macongty, string madotphathanh, string maloaive)
        {
            return _CT_PHIEUDANGKYVE_DAO.CaculateAmountofTickRegister(macongty, madotphathanh, maloaive);
        }

        public string Insert(string maphieudangkyve, string macongtyphathanh, string madotphathanh, string maloaive, string sovedktoida, string sovedangky)
        {
            _CheckError = new CheckError();
            int _SoVeDangKyToiDa = 0, _SoVeDangKy = 0;

            if (sovedangky == "")
            {
                _CheckError.CheckErrorAvailable("Số vé đăng ký");
            }
            else
            {
                try
                {
                    _SoVeDangKy = int.Parse(sovedangky);
                    _SoVeDangKyToiDa = int.Parse(sovedktoida);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số vé đăng ký");
                }
            }

            if (_SoVeDangKy > _SoVeDangKyToiDa)
            {
                _CheckError.CheckErrorConstraint("Số vé đăng ký không lớn hơn số vé đăng ký tối đa");
            }
            if (_CheckError.IsError())
            {
                return _CheckError.GetError();
            }
            else
            {
                CT_PHIEUDANGKYVE _CT_PHIEUDANGKYVE = new CT_PHIEUDANGKYVE(maphieudangkyve, macongtyphathanh, madotphathanh, maloaive, _SoVeDangKyToiDa, _SoVeDangKy);
                _CT_PHIEUDANGKYVE_DAO.Insert(_CT_PHIEUDANGKYVE);
                return "";
            }

        }
    }
}
