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
        public PHIEUCHI() { }
        public PHIEUCHI( string madotphathanh, string madonvi, string manhanvienlap, DateTime ngaylap, string noidungchi, int sotienchi)
        {
            this.MaDotPhatHanh = madotphathanh;
            this.MaDonVi = madonvi;
            this.NoiDungChi = noidungchi;
            this.MaNhanVienLap = manhanvienlap;
            this.SoTienChi = sotienchi;
            this.NgayLap = ngaylap;
        }
        [Key]
        [StringLength(10)]
        public string MaPhieuChi { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [StringLength(10)]
        public string MaDonVi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }
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
