namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_BAOCAOTINHHINHTIEUTHU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaChiTiet { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaBaoCao { get; set; }

        [StringLength(10)]
        public string MaDaiLy { get; set; }

        [StringLength(10)]
        public string TiLeTieuThuTrungBinh { get; set; }

        public virtual BAOCAOTINHHINHTIEUTHUCACDAILY BAOCAOTINHHINHTIEUTHUCACDAILY { get; set; }

        public virtual LOAIDOITAC LOAIDOITAC { get; set; }
    }
}
