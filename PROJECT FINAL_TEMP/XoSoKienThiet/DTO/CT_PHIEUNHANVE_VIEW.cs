namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CT_PHIEUNHANVE_VIEW")]
    public partial class CT_PHIEUNHANVE_VIEW
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaChiTietPhieuNhan { get; set; }
        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string MaPhieuNhanVe { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaDoiTac { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [StringLength(100)]
        [DisplayName("Công ty phát hành")]
        public string Ten { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DisplayName("Ngày phát hành")]
        public DateTime? NgayPhatHanh { get; set; }
        [DisplayName("Mệnh giá")]
        public int? MenhGia { get; set; }
        [DisplayName("Số lượng đăng ký")]
        public int? SoLuongDangKy { get; set; }
        [DisplayName("Số lượng nhận")]
        public int? SoLuongNhan { get; set; }
        [DisplayName("Thành tiền")]
        public double? ThanhTien { get; set; }
        public bool? DaTra { get; set; }
    }
}
