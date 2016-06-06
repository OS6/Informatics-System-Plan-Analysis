namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHANVIEN_VIEW
    {
        [Key]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [StringLength(50)]
        [DisplayName("Tên bộ phận")]
        public string TenBoPhan { get; set; }

        [StringLength(50)]
        [DisplayName("Tên chức vụ")]
        public string TenChucVu { get; set; }

        [StringLength(50)]
        [DisplayName("Tên nhân viên")]
        public string Ten { get; set; }

        [StringLength(15)]
        [DisplayName("SĐT")]
        public string SDT { get; set; }

        [StringLength(250)]
        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }
        [StringLength(10)]
        public string MaBoPhan { get; set; }
         [StringLength(10)]
         public string MaChucVu { get; set; }

         [StringLength(30)]
         [DisplayName("Email")]
         public string Email { get; set; }
        
    }
}
