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
        public string Insert(string menhgia)
        {
            int _MenhGia = 0;
            if(menhgia == "")
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
            
            if(!_CheckError.IsError())
            {
                _LOAIVE = new LOAIVE(_MenhGia);
                _LOAIVE_DAO.Insert(_LOAIVE);
            }
            return _CheckError.GetError();
        }

        public string GetID(string menhgia)
        {
            return _LOAIVE_DAO.GetID(int.Parse(menhgia));
        }
    }
}
