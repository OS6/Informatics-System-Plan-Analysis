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

        public int? SoTienTrungThuong { get; set; }

        public double? SoTienDongThue { get; set; }

        public double? SoTienNhanDuoc { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(10)]
        public string CMND { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }

        public virtual LOAIVE LOAIVE { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
