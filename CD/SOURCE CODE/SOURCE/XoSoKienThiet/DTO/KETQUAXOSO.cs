namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KETQUAXOSO")]
    public partial class KETQUAXOSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KETQUAXOSO()
        {
           
        }
        public KETQUAXOSO(string madotphathanh, string maloaive, string maketquaxoso = "")
        {
            this.MaDotPhatHanh = madotphathanh;
            this.MaLoaiVe = maloaive;
            this.MaKetQuaXoSo = maketquaxoso;
        }

        [Required]
        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [Key]
        [StringLength(10)]
        public string MaKetQuaXoSo { get; set; }
    }
}
