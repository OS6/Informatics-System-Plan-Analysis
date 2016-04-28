namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PHIEUDANGKYVE
    {
        [Key]
        [StringLength(10)]
        public string MaChiTietPhieuDangKy { get; set; }

        [StringLength(10)]
        public string MaPhieuDangKy { get; set; }

        [StringLength(10)]
        public string MaCongTy { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        public int? SoVeDangKyToiDa { get; set; }

        public int? SoVeDangKy { get; set; }

        public virtual DOITAC DOITAC { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }

        public virtual LOAIVE LOAIVE { get; set; }

        public virtual PHIEUDANGKYVE PHIEUDANGKYVE { get; set; }
    }
}
