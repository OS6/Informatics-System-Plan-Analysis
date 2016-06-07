namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEUDANGKYVE_DOITAC_VIEW
    {
        [Key]
        [StringLength(10)]
        public string MaPhieuDangKy { get; set; }

        [StringLength(100)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string MaDoiTac { get; set; }
    }
}
