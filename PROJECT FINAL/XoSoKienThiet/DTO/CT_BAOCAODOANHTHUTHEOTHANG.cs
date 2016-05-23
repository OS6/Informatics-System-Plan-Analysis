namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_BAOCAODOANHTHUTHEOTHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaChiTiet { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaBaoCaoDoanhThu { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        public double? TongThu { get; set; }

        public double? TongChi { get; set; }

        public double? LoiNhuan { get; set; }

        public double? TiLe { get; set; }

        public virtual BAOCAODOANHTHUTHEOTHANG BAOCAODOANHTHUTHEOTHANG { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }
    }
}
