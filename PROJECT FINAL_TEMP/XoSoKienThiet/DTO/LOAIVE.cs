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

        public LOAIVE(string macongty, int menhgia)
        {
            this.MaCongty = macongty;
            this.MenhGia = menhgia;
        }
        [Key]
        [StringLength(10)]
        [DisplayName("Mã loại vé")]
        public string MaLoaiVe { get; set; }

        [DisplayName("Công ty")]
        public string MaCongty { get; set; }
        [DisplayName("Mệnh giá")]
        public int? MenhGia { get; set; }
    }
}
