namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOINOP")]
    public partial class NGUOINOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOINOP()
        {
            PHIEUTHANHTOANs = new HashSet<PHIEUTHANHTOAN>();
        }

        [Key]
        [StringLength(10)]
        public string MaNguoiNop { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHANHTOAN> PHIEUTHANHTOANs { get; set; }
    }
}
