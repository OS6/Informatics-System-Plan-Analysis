namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUTRAVE_VIEW
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDoiTac { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string MaChiTietPhieuTra { get; set; }

        [StringLength(100)]
        [DisplayName("Công ty phát hành")]
        public string Ten { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DisplayName("Ngày phát hành")]
        public DateTime? NgayPhatHanh { get; set; }
         [DisplayName("Mệnh giá")]
        public int? MenhGia { get; set; }
        [DisplayName("Số lượng nhận")]
         public int? SoVeNhan { get; set; }
        [DisplayName("Số lượng trả")]
        public int? SoVeTra { get; set; }
        [DisplayName("Số tiền phải trả")]
        public double? SoTienPhaiTra { get; set; }
    }
}
