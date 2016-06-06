namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEUNHANVE_DOITAC_VIEW
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        [System.ComponentModel.Browsable(false)] //code first ẩn cột trong lookup
        [DisplayName("Mã phiếu đăng ký")]
        public string MaPhieuDangKy { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        [DisplayName("Mã phiếu nhận vé")]
        public string MaPhieuNhanVe { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        [Display(AutoGenerateField = true)]
        [DisplayName("Mã đối tác")]
        public string MaDoiTac { get; set; }

        [StringLength(100)]
        [DisplayName("Đối tác")]
        public string Ten { get; set; }
    }
}
