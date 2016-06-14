namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOTPHATHANH")]
    public partial class DOTPHATHANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOTPHATHANH()
        {
            
        }

        public DOTPHATHANH(DateTime ngayphathanh, DateTime ngayxoso, int gioxoso, string macongty)
        {
            this.NgayPhatHanh = ngayphathanh;
            this.NgayXoSo = ngayxoso;
            this.GioXoSo = gioxoso;
            this.MaCongTy = macongty;
        }

        [Key]
        [StringLength(10)]
        [DisplayName("Mã đợt phát hành")]
        public string MaDotPhatHanh { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DisplayName("Ngày phát hành")]
        public DateTime? NgayPhatHanh { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DisplayName("Ngày xổ số")]
        public DateTime? NgayXoSo { get; set; }
        [DisplayName("Giờ xổ số")]
        public int? GioXoSo { get; set; }

        [StringLength(10)]
        [DisplayName("Mã công ty")]
        public string MaCongTy { get; set; }
    }
}
