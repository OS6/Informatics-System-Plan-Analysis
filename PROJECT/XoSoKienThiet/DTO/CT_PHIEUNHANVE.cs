namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUNHANVE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaChiTietPhieuNhan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaPhieuNhanVe { get; set; }

        [StringLength(10)]
        public string MaDoiTac { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        public int? SoLuongDangKy { get; set; }

        public int? SoLuongNhan { get; set; }

        public double? ThanhTien { get; set; }

        public virtual DOITAC DOITAC { get; set; }

        public virtual DOITAC DOITAC1 { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH1 { get; set; }

        public virtual LOAIVE LOAIVE { get; set; }

        public virtual PHIEUNHANVE PHIEUNHANVE { get; set; }
    }
}
