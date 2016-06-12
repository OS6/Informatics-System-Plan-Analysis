namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIVE")]
    public partial class LOAIVE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIVE()
        {
        }
        public LOAIVE(string macongty, int menhgia, string maloaive = "")
        {
            this.MaCongTy = macongty;
            this.MenhGia = menhgia;
            this.MaLoaiVe = maloaive;
        }
        [Key]
        [StringLength(10)]
        [DisplayName("Mã loại vé")]
        public string MaLoaiVe { get; set; }

        [DisplayName("Mã công ty")]
        public string MaCongTy { get; set; }
        [DisplayName("Mệnh giá")]
        public int? MenhGia { get; set; }
    }
}
