using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class PHIEUNHANGIAI_BUS
    {
        PHIEUNHANGIAI_DAO _PHIEUNHANGIAI_DAO = null;

        public PHIEUNHANGIAI_BUS()
        {
            _PHIEUNHANGIAI_DAO = new PHIEUNHANGIAI_DAO();
        }

        public string Insert(string madotphathanh, string maloaive, string magiaithuong,
             string sotientrungthuong, string sotiendongthue,
            string sotiennhanduoc,string manhanvienlap, string ngaylap, string hoten, string sdt, string cmnd)
        {
            if (madotphathanh == "" || maloaive == "" || magiaithuong == "" || manhanvienlap == "" || sotientrungthuong == "" || sotiendongthue == "" || sotiennhanduoc == "" || ngaylap == "" || hoten == "" || sdt == "" || cmnd == "")
            {
                return "Kiểm tra lại thông tin nhập.";
            }
            else
            {
                PHIEUNHANGIAI PHIEUNHANGIAI = new PHIEUNHANGIAI(madotphathanh, maloaive, magiaithuong,
                     Convert.ToDecimal(sotientrungthuong), Convert.ToDecimal(sotiendongthue),
                    Convert.ToDecimal(sotiennhanduoc), manhanvienlap, Convert.ToDateTime(ngaylap), hoten, sdt, cmnd);
                _PHIEUNHANGIAI_DAO.Insert(PHIEUNHANGIAI);
                return "";
            }
        }
    }
}
