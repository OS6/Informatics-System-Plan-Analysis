namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PREFIX")]
    public partial class PREFIX
    {
        [Key]
        [StringLength(20)]
        public string MaPrefix { get; set; }

        [StringLength(10)]
        public string Frefix { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
