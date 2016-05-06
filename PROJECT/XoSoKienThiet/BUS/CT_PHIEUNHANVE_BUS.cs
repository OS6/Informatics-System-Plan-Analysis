﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class CT_PHIEUNHANVE_BUS
    {
        CT_PHIEUNHANVE_DAO _CT_PHIEUNHANVE_DAO = null;
        public CT_PHIEUNHANVE_BUS()
        {
            _CT_PHIEUNHANVE_DAO = new CT_PHIEUNHANVE_DAO();
        }
        public int Insert(string maphieunhanve, string madoitac, string madotphathanh, string maloaive, string soluongdk, string soluongnhan, string thanhtien)
        {
            int _SoLuongDangKy, _SoLuongNhan;
            float _ThanhTien;
            _SoLuongDangKy = int.Parse(soluongdk);
            _SoLuongNhan = int.Parse(soluongnhan);
            _ThanhTien = float.Parse(thanhtien);
            CT_PHIEUNHANVE _CT_PHIEUNHANVE = new CT_PHIEUNHANVE(maphieunhanve, madoitac, madotphathanh, maloaive,_SoLuongDangKy, _SoLuongNhan, _ThanhTien);
           return  _CT_PHIEUNHANVE_DAO.Insert(_CT_PHIEUNHANVE);
        }
    }
}
