namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOCAOTINHHINHCONGNOVOIDOITAC")]
    public partial class BAOCAOTINHHINHCONGNOVOIDOITAC
    {
        [Key]
        [StringLength(10)]
        public string MaBaoCao { get; set; }

        [StringLength(10)]
        public string MaDoiTac { get; set; }

        public double? CongNo { get; set; }

        public virtual DOITAC DOITAC { get; set; }
    }
}
