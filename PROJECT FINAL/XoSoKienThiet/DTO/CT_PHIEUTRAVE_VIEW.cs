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
        [StringLength(10)]
        public string MaPhieuDangKy { get; set; }

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

        [StringLength(100)]
        public string Ten { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayPhatHanh { get; set; }

        public int? MenhGia { get; set; }

        public int? SoVeDangKy { get; set; }
    }
}
