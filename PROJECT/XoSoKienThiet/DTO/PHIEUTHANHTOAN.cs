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
        [Key]
        [StringLength(10)]
        public string MaPhieuThanhToan { get; set; }

        [StringLength(10)]
        public string MaDaiLy { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        public double? SoTienNo { get; set; }

        public double? SoTienThu { get; set; }

        public double? SoTienConLai { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        [StringLength(10)]
        public string MaNhanVienLap { get; set; }

        [StringLength(10)]
        public string MaNguoiNop { get; set; }

        public virtual DOITAC DOITAC { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }

        public virtual NGUOINOP NGUOINOP { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
