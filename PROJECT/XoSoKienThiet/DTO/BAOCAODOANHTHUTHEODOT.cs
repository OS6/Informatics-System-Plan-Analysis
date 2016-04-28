namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOCAODOANHTHUTHEODOT")]
    public partial class BAOCAODOANHTHUTHEODOT
    {
        [Key]
        [StringLength(10)]
        public string MaBaoCao { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        public double? TongThu { get; set; }

        public double? TongChi { get; set; }

        public double? LoiNhuan { get; set; }

        public double? CongQuy { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }
    }
}
