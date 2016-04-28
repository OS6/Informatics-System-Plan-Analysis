namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CODEMASTERS")]
    public partial class CODEMASTER
    {
        [Key]
        [StringLength(10)]
        public string Prefix { get; set; }

        public int? CurValue { get; set; }
    }
}
