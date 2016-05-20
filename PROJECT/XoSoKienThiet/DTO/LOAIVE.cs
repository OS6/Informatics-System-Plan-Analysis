namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
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
        public string MaLoaiVe { get; set; }

        public string MaCongty { get; set; }
        public int? MenhGia { get; set; }
    }
}
