namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COCAUTOCHUC")]
    public partial class COCAUTOCHUC
    {
        [Key]
        [StringLength(10)]
        public string MaCoCauToChuc { get; set; }

        [StringLength(10)]
        public string MaBoPhan { get; set; }

        [StringLength(10)]
        public string MaChucVu { get; set; }

        public virtual BOPHAN BOPHAN { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }
    }
}
