namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KQXS_GIAITHUONG_VIEW
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        [System.ComponentModel.Browsable(false)]
        [DisplayName("Mã chi tiết KQXS")]
        public string MaChiTietKQXS { get; set; }

        [StringLength(25)]
        [DisplayName("Giải thưởng")]
        public string Ten { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Số trúng")]
        public int SoTrung { get; set; }

        [DisplayName("Số tiền trúng")]
        [Column(TypeName = "money")]
        public decimal? SoTienTrung { get; set; }
    }
}
