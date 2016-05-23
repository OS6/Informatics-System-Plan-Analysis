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
            _CheckError = new CheckError();
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
        public void Insert(string macongty, string menhgia)
        {
            int _MenhGia;
            _MenhGia = int.Parse(menhgia);
            _LOAIVE = new LOAIVE(macongty, _MenhGia);
            _LOAIVE_DAO.Insert(_LOAIVE);

        }

        public string GetID(string menhgia)
        {
            return _LOAIVE_DAO.GetID(int.Parse(menhgia));
        }

        public int GetPrice(string macongty, string maloaive)
        {
            int _MenhGia = int.Parse(_LOAIVE_DAO.GetPrice(macongty, maloaive).SingleOrDefault().ToString());
            return _MenhGia;
        }

        public string CheckBeforeInsert(string menhgia)
        {
            int _MenhGia = 0;
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
            return "";
        }
    }
}
