namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUCHI")]
    public partial class PHIEUCHI
    {
        [Key]
        [StringLength(10)]
        public string MaPhieuChi { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [StringLength(10)]
        public string MaDonVi { get; set; }

        [StringLength(10)]
        public string MaNhanVienLap { get; set; }

        [StringLength(1000)]
        public string NoiDungChi { get; set; }

        public int? SoTienChi { get; set; }

        public virtual BOPHAN BOPHAN { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
