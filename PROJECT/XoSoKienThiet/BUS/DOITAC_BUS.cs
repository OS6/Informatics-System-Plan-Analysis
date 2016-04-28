using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class DOITAC_BUS
    {
        DOITAC_DAO _DOITAC_DAO = null;
        public DOITAC_BUS()
        {
            _DOITAC_DAO = new DOITAC_DAO();
        }

        public List<DOITAC> Select()
        {
            return _DOITAC_DAO.Select();
        }
        public string Insert_Update(string maloaidoitac, string ten, string diachi, string sdt, string email, string tilehoahong, string madoitac = null)
        {
            string sError = "Bạn chưa nhập:\n";

            if( ten == "")
            {
                sError += "Tên đối tác\n";
            }

            if (diachi == "")
            {
                sError += "Địa chỉ\n";
            }

            if (sdt == "")
            {
                sError += "SĐT\n ";
            }

            if (email == "")
            {
                sError += "Email\n ";
            }

            if(tilehoahong.ToString() == "")
            {
                sError += "Tỉ lệ hoa hồng\n";
            }
            if (CheckSpecialString.KT_ChuoiKiTuDacBiet(ten) == false)
                sError += "Họ tên không chứa số hoặc kí tự đặc biệt\n";

            if (sError == "Bạn chưa nhập:\n")
            {
                DOITAC _DOITAC = new DOITAC(maloaidoitac,
                                       ten,
                                        diachi,
                                        sdt,
                                        email,
                                        float.Parse(tilehoahong));
                _DOITAC_DAO.Insert_Update(_DOITAC, madoitac);
                return "";
            }

            else
                return sError;
        }

        public int Delete(string madoitac)
        {
           return  _DOITAC_DAO.Delete(madoitac);
        }
    }
}
