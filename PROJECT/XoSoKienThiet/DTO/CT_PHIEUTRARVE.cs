namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUTRARVE
    {
        [Key]
        [StringLength(10)]
        public string MaChiTietPhieuTra { get; set; }

        [StringLength(10)]
        public string MaPhieuTraVe { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        public int? SoVeNhan { get; set; }

        public int? SoVeTra { get; set; }

        public double? SoTienPhaiTra { get; set; }

        public virtual LOAIVE LOAIVE { get; set; }

        public virtual PHIEUTRAVE PHIEUTRAVE { get; set; }

        public virtual PHIEUTRAVE PHIEUTRAVE1 { get; set; }
    }
}
