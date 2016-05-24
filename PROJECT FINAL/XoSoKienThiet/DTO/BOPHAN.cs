namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOPHAN")]
    public partial class BOPHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPHAN()
        {
           
        }

        [Key]
        [StringLength(10)]
        public string MaBoPhan { get; set; }

        [StringLength(10)]
        public string MaQuanLy { get; set; }

        [StringLength(10)]
        [DisplayName("Tên bộ phận")]
        public string TenBoPhan { get; set; }

       
    }
}
