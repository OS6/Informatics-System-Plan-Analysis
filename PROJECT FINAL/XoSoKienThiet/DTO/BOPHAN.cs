namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOPHAN")]
    public partial class BOPHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPHAN()
        {
            COCAUTOCHUCs = new HashSet<COCAUTOCHUC>();
            NHANVIENs = new HashSet<NHANVIEN>();
            PHIEUCHIs = new HashSet<PHIEUCHI>();
        }

        [Key]
        [StringLength(10)]
        public string MaBoPhan { get; set; }

        [StringLength(10)]
        public string MaQuanLy { get; set; }

        [StringLength(10)]
        public string Ten { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COCAUTOCHUC> COCAUTOCHUCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHI> PHIEUCHIs { get; set; }
    }
}
