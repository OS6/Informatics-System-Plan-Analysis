namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KEHOACHPHATHANH")]
    public partial class KEHOACHPHATHANH
    {
        [Key]
        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        public int? TongSoVePhatHanh { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH1 { get; set; }
    }
}
