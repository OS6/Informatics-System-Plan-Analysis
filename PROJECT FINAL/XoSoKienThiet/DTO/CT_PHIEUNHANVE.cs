namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUNHANVE
    {
        public CT_PHIEUNHANVE()
        {

        }
        public CT_PHIEUNHANVE(string maphieunhanve, string macongtyphathanh, string madotphathanh, string maloaive, int soluongdk, int soluongnhan, float thanhtien)
        {
            this.MaPhieuNhanVe = maphieunhanve;
            this.MaCongTyPhatHanh = macongtyphathanh;
            this.MaDotPhatHanh = madotphathanh;
            this.MaLoaiVe = maloaive;
            this.SoLuongDangKy = soluongdk;
            this.SoLuongNhan = soluongnhan;
            this.ThanhTien = thanhtien;
        }
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaChiTietPhieuNhan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaPhieuNhanVe { get; set; }

        [StringLength(10)]
        public string MaCongTyPhatHanh { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        public int? SoLuongDangKy { get; set; }

        public int? SoLuongNhan { get; set; }

        public double? ThanhTien { get; set; }
    }
}
