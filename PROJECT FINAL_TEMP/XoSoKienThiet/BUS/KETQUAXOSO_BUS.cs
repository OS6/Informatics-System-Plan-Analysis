using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class KETQUAXOSO_BUS
    {
        KETQUAXOSO_DAO _KETQUAXOSO_DAO = null;
        CheckError _CheckError = null;
        public KETQUAXOSO_BUS()
        {
            _KETQUAXOSO_DAO = new KETQUAXOSO_DAO();
        }
        public string CheckBeforeSelect(string madotphathanh, string maloaive, string sotrung)
        {
            _CheckError = new CheckError();
            if (madotphathanh == "")
            {
                _CheckError.CheckErrorAvailable("Đợt phát hành");
            }
            if (maloaive == "")
            {
                _CheckError.CheckErrorAvailable("Đợt phát hành");
            }

            if (sotrung == "")
            {
                _CheckError.CheckErrorAvailable("Số dò");
            }
            if (_CheckError.IsError())
            {
                return _CheckError.GetError();
            }
            else
                return "";
        }
        public List<CT_KQXS_GIAITHUONG_VIEW> Select(string madotphathanh, string maloaive, string sotrung)
        {
            return _KETQUAXOSO_DAO.Select(madotphathanh, maloaive, Convert.ToInt32(sotrung));
        }
        public string Insert(string madotphathanh, string maloaive, string maketqua = "")
        {
            KETQUAXOSO ketquasoxo = new KETQUAXOSO(madotphathanh, maloaive, maketqua);
            return _KETQUAXOSO_DAO.Insert(ketquasoxo);

        }

    }
}
