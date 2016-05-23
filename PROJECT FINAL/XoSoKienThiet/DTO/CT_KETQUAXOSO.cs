namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KETQUAXOSO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaChiTietKetQua { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaKetQua { get; set; }

        [StringLength(10)]
        public string MaVeTrung { get; set; }

        [StringLength(10)]
        public string MaGiaiThuong { get; set; }

        public int? SoLuongVeTrung { get; set; }

        public double? TongTien { get; set; }

        public virtual GIAITHUONG GIAITHUONG { get; set; }

        public virtual KETQUAXOSO KETQUAXOSO { get; set; }

        public virtual VE VE { get; set; }
    }
}
