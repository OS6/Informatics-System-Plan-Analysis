using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class NHANVIEN_BUS
    {
        NHANVIEN_DAO _NHANVIEN_DAO = null;
        CheckError _CheckError = null;
        public NHANVIEN_BUS()
        {
            _NHANVIEN_DAO = new NHANVIEN_DAO();
        }

        public List<NHANVIEN> Select()
        {
            return _NHANVIEN_DAO.Select();
        }
        public List<NHANVIEN_VIEW> SelectView()
        {
            return _NHANVIEN_DAO.SelectView();
        }
        public string Insert_Update(string macocautochuc, string ten, string sdt, string diachi, string email, string manhanvien = "")
        {
            _CheckError = new CheckError();
            if (ten == "")
            {
                _CheckError.CheckErrorAvailable("Tên nhân viên");
            }
            else
            {
                if (CheckSpecialString.KT_ChuoiKiTuDacBiet(ten) == false)
                    _CheckError.CheckErrorCharacter("Tên nhân viên");
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

            if (macocautochuc == "")
            {
                _CheckError.CheckErrorAvailable("Cơ cấu tổ chức");
            }
            if (!_CheckError.IsError())
            {
                NHANVIEN _NHANVIEN = new NHANVIEN(macocautochuc,
                                       ten,
                                        sdt,
                                        diachi,
                                        email, manhanvien);
                _NHANVIEN_DAO.Insert_Update(_NHANVIEN);
                return "";
            }
            else
                return _CheckError.GetError();
        }
    }
}
