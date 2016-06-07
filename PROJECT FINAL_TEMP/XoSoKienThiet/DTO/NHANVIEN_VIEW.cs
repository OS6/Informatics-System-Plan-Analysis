namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHANVIEN_VIEW
    {
        [Key]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [StringLength(50)]
        public string TenBoPhan { get; set; }

        [StringLength(50)]
        public string TenChucVu { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }
    }
}
