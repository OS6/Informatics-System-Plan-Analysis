using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class LOAIVE_BUS
    {
        LOAIVE_DAO _LOAIVE_DAO = null;
        LOAIVE _LOAIVE = null;
        CheckError _CheckError = null;
        public LOAIVE_BUS()
        {
            _LOAIVE_DAO = new LOAIVE_DAO();
        }

        public List<LOAIVE> Select()
        {
            return _LOAIVE_DAO.Select();
        }

        public List<LOAIVE> SelectYourCompany()
        {
            return _LOAIVE_DAO.SelectYourCompany();
        }
        public List<LOAIVE> Select_Con_Company(string macongty)
        {
            return _LOAIVE_DAO.Select_Con_Company(macongty);
        }
        public string Insert_Update(string macongty, string menhgia, string maloaive = "")
        {
            _CheckError = new CheckError();
            int _MenhGia = 0;
            if(macongty == "")
            {
                _CheckError.CheckErrorAvailable("Công ty");
            }
            if (menhgia == "")
            {
                _CheckError.CheckErrorAvailable("Mệnh giá");
            }
            else
            {
                try
                {
                    _MenhGia = int.Parse(menhgia);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Mệnh giá");
                }
            }

            if (_CheckError.IsError())
            {
                return _CheckError.GetError();
            }
            else
            {
                _LOAIVE = new LOAIVE(macongty, _MenhGia, maloaive);
                _LOAIVE_DAO.Insert_Update(_LOAIVE);
                return "";
            }
        }

        public string GetID(string menhgia)
        {
            return _LOAIVE_DAO.GetID(int.Parse(menhgia));
        }

        public int GetPrice(string maloaive)
        {
            int _MenhGia = int.Parse(_LOAIVE_DAO.GetPrice(maloaive).SingleOrDefault().ToString());
            return _MenhGia;
        }

    }
}
