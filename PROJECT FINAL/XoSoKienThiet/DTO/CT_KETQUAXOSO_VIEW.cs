namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KETQUAXOSO_VIEW
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaChiTietKQXS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaGiaiThuong { get; set; }

        [StringLength(10)]
        public string MaKetQuaXoSo { get; set; }

        [StringLength(25)]
        [DisplayName("Giải thưởng")]
        public string Ten { get; set; }

         [DisplayName("Số tiền trúng")]
        public int? SoTienTrung { get; set; }
         [DisplayName("Số giải")]
        public int? SoGiai { get; set; }
         [DisplayName("Số lượng vé trúng")]
        public int? SoLuongVeTrung { get; set; }

        [Column(TypeName = "money")]
        [DisplayName("Tổng tiền")]
        public decimal? TongTien { get; set; }
    }
}
