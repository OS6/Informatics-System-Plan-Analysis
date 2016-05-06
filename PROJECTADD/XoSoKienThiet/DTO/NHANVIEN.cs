namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
        }

        [Key]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [StringLength(10)]
        public string MaCoCauToChuc { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

    }
}
