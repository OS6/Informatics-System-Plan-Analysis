namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KETQUAXOSO")]
    public partial class KETQUAXOSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KETQUAXOSO()
        {
            CT_KETQUAXOSO = new HashSet<CT_KETQUAXOSO>();
        }

        [Required]
        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [Key]
        [StringLength(10)]
        public string MaKetQuaXoSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KETQUAXOSO> CT_KETQUAXOSO { get; set; }
    }
}
