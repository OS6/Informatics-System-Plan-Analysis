namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KEHOACHPHATHANH")]
    public partial class KEHOACHPHATHANH
    {
        public KEHOACHPHATHANH()
        {

        }
        public KEHOACHPHATHANH(string madotphathanh, int tongve)
        {
            this.MaDotPhatHanh = madotphathanh;
            this.TongSoVePhatHanh = tongve;
        }
        [Key]
        [StringLength(10)]
        [DisplayName("Mã đợt phát hành")]
        public string MaDotPhatHanh { get; set; }
        [DisplayName("Tổng số vé phát hành")]
        public int? TongSoVePhatHanh { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH1 { get; set; }
    }
}
