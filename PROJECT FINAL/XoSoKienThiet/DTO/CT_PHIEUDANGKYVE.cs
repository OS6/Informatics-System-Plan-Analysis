namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUDANGKYVE
    {
        public CT_PHIEUDANGKYVE()
        {

        }

        public CT_PHIEUDANGKYVE(string maphieudangkyve, string macongtyphathanh, string madotphathanh, string maloaive, int sovedktoida, int sovedangky)
        {
            this.MaPhieuDangKy = maphieudangkyve;
            this.MaCongTy = macongtyphathanh;
            this.MaDotPhatHanh = madotphathanh;
            this.MaLoaiVe = maloaive;
            this.SoVeDangKyToiDa = sovedktoida;
            this.SoVeDangKy = sovedangky;
        }

        [Key]
        [StringLength(10)]
        public string MaChiTietPhieuDangKy { get; set; }

        [StringLength(10)]
        public string MaPhieuDangKy { get; set; }

        [StringLength(10)]
        [DisplayName("Công ty")]
        public string MaCongTy { get; set; }

        [StringLength(10)]
        [DisplayName("Đợt phát hành")]
        public string MaDotPhatHanh { get; set; }

        [StringLength(10)]
        [DisplayName("Loại vé")]
        public string MaLoaiVe { get; set; }


        [DisplayName("Số vé đăng ký tối đa")]
        public int? SoVeDangKyToiDa { get; set; }

        [DisplayName("Số vé đăng ký")]
        public int? SoVeDangKy { get; set; }
    }
}
