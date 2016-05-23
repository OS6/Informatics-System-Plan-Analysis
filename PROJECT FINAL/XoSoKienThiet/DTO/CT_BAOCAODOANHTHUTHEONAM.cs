namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_BAOCAODOANHTHUTHEONAM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaChiTiet { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaBaoCaoDoanhThu { get; set; }

        public int? Thang { get; set; }

        public double? TiLe { get; set; }

        public virtual BAOCAODOANHTHUTHEONAM BAOCAODOANHTHUTHEONAM { get; set; }
    }
}
