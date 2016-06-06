namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOITAC")]
    public partial class DOITAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOITAC()
        {

        }

        public DOITAC(string maloaidoitac, string ten, string diachi, string sdt, string email, string madoitac = "")
        {
            this.MaDoiTac = madoitac;
            this.MaLoaiDoiTac = maloaidoitac;
            this.Ten = ten;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.Email = email;
        }

        [Key]
        [StringLength(10)]
        [DisplayName("Mã đối tác")]
        public string MaDoiTac { get; set; }

        [StringLength(10)]
        [DisplayName("Mã loại tác")]
        public string MaLoaiDoiTac { get; set; }

        [StringLength(100)]
        [DisplayName("Tên")]
        public string Ten { get; set; }

        [StringLength(250)]
        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [StringLength(13)]
        [DisplayName("Số điện thoại")]
        public string SDT { get; set; }

        [StringLength(30)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Tỉ lệ hoa hồng")]
        public double? TiLeHoaHong { get; set; }

        [DisplayName("Tỉ lệ tiêu thụ")]
        public double? TiLeTieuThu { get; set; }

        [DisplayName("Công nợ")]
        public int? CongNo { get; set; }
    }
}
