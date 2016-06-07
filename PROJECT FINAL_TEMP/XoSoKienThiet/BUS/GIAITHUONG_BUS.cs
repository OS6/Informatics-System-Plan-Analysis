using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    public class GIAITHUONG_BUS
    {
        private GIAITHUONG_DAO _GIAITHUONG_DAO = null;
        private CheckError _CheckError = null;
        public GIAITHUONG_BUS()
        {
            _GIAITHUONG_DAO = new GIAITHUONG_DAO();
        }

        public List<GIAITHUONG> Select(string maloaive)
        {
            return _GIAITHUONG_DAO.Select(maloaive);
        }
        public string CheckErrorBeforeInsert( string ten, string sotientrung, string sogiai)
        {
            _CheckError = new CheckError();
            int _SoTienTrung = 0, _SoGiai = 0;

            if (ten == "")
            {
                _CheckError.CheckErrorAvailable("Tên giải thưởng");
            }

            if (sotientrung == "")
            {
                _CheckError.CheckErrorAvailable("Số tiền trúng");
            }
            else
            {
                try
                {
                    _SoTienTrung = int.Parse(sotientrung);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số tiền trúng");
                }
            }

            if (sogiai == "")
            {
                _CheckError.CheckErrorAvailable("Số giải");
            }
            else
            {
                try
                {
                    _SoGiai = int.Parse(sogiai);
                }
                catch
                {
                    _CheckError.CheckErrorNumber("Số giải");
                }
            }
            if (CheckSpecialString.KT_ChuoiKiTuDacBiet(ten) == false)
                _CheckError.CheckErrorCharacter("Tên giải thưởng");

            if (!_CheckError.IsError())
            {
                return "";
            }

            else
            {
                return _CheckError.GetError();
            }
        }

        public void Insert(string maloaive, string ten, string sotientrung, string sogiai)
        {
            int _SoTienTrung = 0, _SoGiai = 0;
            _SoGiai = int.Parse(sogiai);
            _SoTienTrung = int.Parse(sotientrung);
             GIAITHUONG _GIAITHUONG = new GIAITHUONG(maloaive,
                                       ten,
                                        _SoTienTrung,
                                        _SoGiai);
                _GIAITHUONG_DAO.Insert(_GIAITHUONG);
        }

    }
}
