using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XoSoKienThiet.DAO;
using XoSoKienThiet.DTO;

namespace XoSoKienThiet.BUS
{
    class THAMSO_BUS
    {
        CheckError _CheckError = null;
        THAMSO_DAO _THAMSO_DAO = null;
        public THAMSO_BUS()
        {
            _THAMSO_DAO = new THAMSO_DAO();
        }
        public THAMSO Select()
        {
            return _THAMSO_DAO.Select().SingleOrDefault();
        }
        public string Update(string tiletieuthudat, string tiletienitnhattra, string tilehoahonglandau,
                     string tilehoahongtang, string tilehoahonggiam, string hantrave,
                     string songaynhangiai, string sodotganday, string chietkhaugiatrigiatang)
        {
            _CheckError = new CheckError();
            float TiLeTieuThuDat = 0, TiLeTienItNhatTra = 0, TiLeHoaHongLanDau = 0, TiLeHoaHongTang = 0, TiLeHoaHongGiam = 0, ChietKhau = 0;
            int HanTraVe = 0, SoNgayNhanGiai = 0, SoDotGanDay = 0;
            // tỉ lệ tiêu thụ đạt
            if (tiletieuthudat == "")
            {
                _CheckError.CheckErrorAvailable("Tỉ lệ tiêu thụ đạt");
            }
            else
            {
                try
                {
                    TiLeTieuThuDat = (float)Math.Round(Convert.ToDouble(tiletieuthudat),2);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Tỉ lệ tiêu thụ đạt");
                }
            }
            // Tỉ lệ tiền ít nhất trả
            if (tiletienitnhattra == "")
            {
                _CheckError.CheckErrorAvailable("Tỉ lệ tiêu thụ đạt");
            }
            else
            {
                try
                {
                    TiLeTienItNhatTra = float.Parse(tiletienitnhattra);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Tỉ lệ tiêu thụ đạt");
                }
            }
            // Tỉ lệ hoa hồng lần đầu
            if (tilehoahonglandau == "")
            {
                _CheckError.CheckErrorAvailable("Tỉ lệ hoa hồng lần đầu");
            }
            else
            {
                try
                {
                    TiLeHoaHongLanDau = float.Parse(tiletienitnhattra);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Tỉ lệ hoa hồng lần đầu");
                }
            }
            // Tỉ lệ hoa hồng tăng
            if (tilehoahonglandau == "")
            {
                _CheckError.CheckErrorAvailable("Tỉ lệ hoa hồng tăng");
            }
            else
            {
                try
                {
                    TiLeHoaHongTang = float.Parse(tiletienitnhattra);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Tỉ lệ hoa hồng tăng");
                }
            }
            // Tỉ lệ hoa hồng giảm
            if (tilehoahonglandau == "")
            {
                _CheckError.CheckErrorAvailable("Tỉ lệ hoa hồng giảm");
            }
            else
            {
                try
                {
                    TiLeHoaHongGiam = float.Parse(tiletienitnhattra);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Tỉ lệ hoa hồng giảm");
                }
            }
            // Hạn trả vé
            if (hantrave == "")
            {
                _CheckError.CheckErrorAvailable("Hạn trả vé");
            }
            else
            {
                try
                {
                    HanTraVe = int.Parse(hantrave);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Hạn trả vé");
                }
            }
            // Số ngày nhận giải
            if (sodotganday == "")
            {
                _CheckError.CheckErrorAvailable("Số ngày nhận giải");
            }
            else
            {
                try
                {
                    SoNgayNhanGiai = int.Parse(songaynhangiai);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Số ngày nhận giải");
                }
            }
            // Số đợt gần đây
            if (sodotganday == "")
            {
                _CheckError.CheckErrorAvailable("Số đợt gần đây");
            }
            else
            {
                try
                {
                    SoDotGanDay = int.Parse(sodotganday);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Số đợt gần đây");
                }
            }
            // Chiết khấu
            if (sodotganday == "")
            {
                _CheckError.CheckErrorAvailable("Chiết khấu giá trị gia tăng");
            }
            else
            {
                try
                {
                    ChietKhau = float.Parse(sodotganday);
                }
                catch (Exception)
                {
                    _CheckError.CheckErrorNumber("Chiết khấu giá trị gia tăng");
                }
            }
            if (!_CheckError.IsError())
            {
                THAMSO thamso = new THAMSO(TiLeTieuThuDat,
                                           TiLeTienItNhatTra,
                                            TiLeHoaHongLanDau,
                                             TiLeHoaHongTang,
                                           TiLeHoaHongGiam,
                                            HanTraVe,
                                             SoNgayNhanGiai,
                                             SoDotGanDay,
                                            ChietKhau);
                _THAMSO_DAO.Update(thamso);
                return "";
            }
            else
            {
                return _CheckError.GetError();
            }
        }
    }
}
