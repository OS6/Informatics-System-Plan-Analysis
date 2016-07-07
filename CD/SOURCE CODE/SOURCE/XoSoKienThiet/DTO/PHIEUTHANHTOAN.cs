namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHANHTOAN")]
    public partial class PHIEUTHANHTOAN
    {
        public PHIEUTHANHTOAN() 
        {

        }

        public PHIEUTHANHTOAN(string madoitac, string madotphathanh, double sotienno, double sotienthu, double sotienconlai, DateTime ngaylap, string manhanvienlap, string tennguoinop, string sdt, string diachi, string email)
        {
            this.MaDoiTac = madoitac;
            this.MaDotPhatHanh = madotphathanh;
            this.SoTienNo = sotienno;
            this.SoTienThu = sotienthu;
            this.SoTienConLai = sotienconlai;
            this.NgayLap = ngaylap;
            this.MaNhanVienLap = manhanvienlap;
            this.TenNguoiNop = tennguoinop;
            this.SDT = sdt;
            this.DiaChi = diachi;
            this.Email = email;
        }

        [Key]
        [StringLength(10)]
        public string MaPhieuThanhToan { get; set; }

        [StringLength(10)]
        public string MaDoiTac { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        public double? SoTienNo { get; set; }

        public double? SoTienThu { get; set; }

        public double? SoTienConLai { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        [StringLength(10)]
        public string MaNhanVienLap { get; set; }

        [StringLength(50)]
        public string TenNguoiNop { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
