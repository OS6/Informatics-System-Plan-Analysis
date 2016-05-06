using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class DANHSACHLOAIVE_BUS
    {
        DANHSACHLOAIVE_DAO _DANHSACHLOAIVE_DAO = null;
        DOITAC_DAO _DOITAC_DAO = null;
        LOAIVE_DAO _LOAIVE_DAO = null;

        public DANHSACHLOAIVE_BUS()
        {
            _DOITAC_DAO = new DOITAC_DAO();
            _DANHSACHLOAIVE_DAO = new DANHSACHLOAIVE_DAO();
            _LOAIVE_DAO = new LOAIVE_DAO();
        }
        public List<DOITAC> SelectCompany()
        {
            return _DOITAC_DAO.SelectCompany();
        }

        public string GetMaDoiTac(string tendoitac)
        {
            return _DOITAC_DAO.GetMaDoiTac(tendoitac);
        }

        public List<LOAIVE> Select(string madoitac)
        {
            return _DANHSACHLOAIVE_DAO.Select(madoitac);
        }

        public List<LOAIVE> GetTypeofTicketnotInCompany(string macongty)
        {
            return _LOAIVE_DAO.GetTypeofTicketnotInCompany(macongty);
        }

        #region Insert LOAIVE
        //public void Insert(string tenloaive, string menhgia)
        //{
        //    string sError = "Bạn chưa nhập:\n";

        //    if (tenloaive == "")
        //    {
        //        sError += "Tên loại vé\n";
        //    }

        //    if (menhgia == "")
        //    {
        //        sError += "Mệnh giá\n";
        //    }

        //    if (CheckSpecialString.KT_ChuoiKiTuDacBiet(tenloaive) == false)
        //        sError += "Tên loại vé không chứa số hoặc kí tự đặc biệt\n";

        //    int _MenhGia = 0;
        //    try
        //    {
        //        _MenhGia = int.Parse(menhgia);
        //    }
        //    catch
        //    {
        //        sError += "Mệnh giá phải là số nguyên";
        //    }

        //}
        #endregion

        public int Insert(string macongty, string maloaive)
        {
            DANHSACHLOAIVE _DANHSACHLOAIVE = new DANHSACHLOAIVE(macongty, maloaive);
            return _DANHSACHLOAIVE_DAO.Insert(_DANHSACHLOAIVE);
        }
    }
}
