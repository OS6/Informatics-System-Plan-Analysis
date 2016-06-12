namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        public NHANVIEN(string macocautochuc, string ten, string sdt, string diachi,string email, string manhanvien = "")
        {
            this.MaCoCauToChuc = macocautochuc;
            this.Ten = ten;
            this.SDT = sdt;
            this.DiaChi = diachi;
            this.Email = email;
            this.MaNhanVien = manhanvien;
        }

        [Key]
        [StringLength(10)]
        [DisplayName("Mã nhân viên")]
        public string MaNhanVien { get; set; }

        [StringLength(10)]
        public string MaCoCauToChuc { get; set; }

        [StringLength(50)]
        [DisplayName("Tên nhân viên")]
        public string Ten { get; set; }

        [StringLength(15)]
        [DisplayName("SĐT")]
        public string SDT { get; set; }

        [StringLength(250)]
        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [StringLength(30)]
        [DisplayName("Email")]
        public string Email { get; set; }

    }
}
