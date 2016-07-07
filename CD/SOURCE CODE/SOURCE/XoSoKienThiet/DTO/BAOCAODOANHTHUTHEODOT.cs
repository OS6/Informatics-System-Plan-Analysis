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
        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? TongThu { get; set; }
        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? TongChi { get; set; }
        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? LoiNhuan { get; set; }
        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? CongQuy { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }
    }
}
