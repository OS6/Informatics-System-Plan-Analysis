namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUTRAVE
    {
        public CT_PHIEUTRAVE()
        {

        }

        public CT_PHIEUTRAVE(string maphieutrave, string macongtyphathanh, string madotphathanh, string maloaive, int sovenhan, int sovetra, int sotienphaitra)
        {
            this.MaPhieuTraVe = maphieutrave;
            this.MaCongTyPhatHanh = macongtyphathanh;
            this.MaDotPhatHanh = madotphathanh;
            this.MaLoaiVe = maloaive;
            this.SoVeNhan = sovenhan;
            this.SoVeTra = sovetra;
            this.SoTienPhaiTra = sotienphaitra;
        }
        [Key]
        [StringLength(10)]
        public string MaChiTietPhieuTra { get; set; }

        [StringLength(10)]
        public string MaPhieuTraVe { get; set; }

        [StringLength(10)]
        public string MaCongTyPhatHanh { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        public int? SoVeNhan { get; set; }

        public int? SoVeTra { get; set; }

        public double? SoTienPhaiTra { get; set; }
    }
}
