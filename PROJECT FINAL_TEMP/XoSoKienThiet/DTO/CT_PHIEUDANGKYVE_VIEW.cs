namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUDANGKYVE_VIEW
    {
        [StringLength(10)]
        [DisplayName("Mã phiếu đăng ký")]
        public string MaPhieuDangKy { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        [DisplayName("Mã đối tác")]
        public string MaDoiTac { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        [DisplayName("Mã đợt phát hành")]
        public string MaDotPhatHanh { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        [DisplayName("Mã loại vé")]
        public string MaLoaiVe { get; set; }

        [StringLength(100)]
        [DisplayName("Tên")]
        public string Ten { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DisplayName("Ngày phát hành")]
        public DateTime? NgayPhatHanh { get; set; }
        [DisplayName("Mệnh giá")]
        public int? MenhGia { get; set; }
        [DisplayName("Số vé đăng ký")]
        public int? SoVeDangKy { get; set; }
        [DisplayName("Đã nhận")]
        public bool? DaNhan { get; set; }
    }
}
