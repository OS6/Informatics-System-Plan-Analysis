namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHSACHVETRUNG")]
    public partial class DANHSACHVETRUNG
    {
        [Key]
        [StringLength(10)]
        public string MaDanhSachVeTrung { get; set; }

        [Required]
        [StringLength(10)]
        public string MaChiTietKQXS { get; set; }

        [StringLength(6)]
        public string SoTrung { get; set; }

        public virtual CT_KETQUAXOSO CT_KETQUAXOSO { get; set; }
    }
}
