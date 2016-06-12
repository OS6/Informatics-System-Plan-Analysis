namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHANGIAI")]
    public partial class PHIEUNHANGIAI
    {
        public PHIEUNHANGIAI()
        {
        }

        public PHIEUNHANGIAI(string madotphathanh, string maloaive, string magiaithuong, decimal sotientrungthuong, decimal sotiendongthue, decimal sotiennhanduoc, string manhanvienlap, DateTime ngaylap, string hoten, string sdt, string cmnd)
        {
            this.MaDotPhatHanh = madotphathanh;
            this.MaLoaiVe = maloaive;
            this.MaGiaiThuong = magiaithuong;
            this.MaNhanVienLap = manhanvienlap;
            this.SoTienTrungThuong = sotientrungthuong;
            this.SoTienDongThue = sotiendongthue;
            this.SoTienNhanDuoc = sotiennhanduoc;
            this.NgayLap = ngaylap;
            this.HoTen = hoten;
            this.SDT = sdt;
            this.CMND = cmnd;
        }

        [Key]
        [StringLength(10)]
        public string MaPhieuNhanGiai { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [StringLength(10)]
        public string MaGiaiThuong { get; set; }

        [StringLength(10)]
        public string MaNhanVienLap { get; set; }

        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? SoTienTrungThuong { get; set; }

        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? SoTienDongThue { get; set; }

        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? SoTienNhanDuoc { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(10)]
        public string CMND { get; set; }

    }
}
