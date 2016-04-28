namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIVE")]
    public partial class LOAIVE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIVE()
        {
            CT_KEHOACHPHATHANH = new HashSet<CT_KEHOACHPHATHANH>();
            CT_PHIEUDANGKYVE = new HashSet<CT_PHIEUDANGKYVE>();
            CT_PHIEUNHANVE = new HashSet<CT_PHIEUNHANVE>();
            CT_PHIEUTRARVE = new HashSet<CT_PHIEUTRARVE>();
            GIAITHUONGs = new HashSet<GIAITHUONG>();
            KETQUAXOSOes = new HashSet<KETQUAXOSO>();
            PHIEUNHANGIAIs = new HashSet<PHIEUNHANGIAI>();
            VEs = new HashSet<VE>();
        }

        [Key]
        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [StringLength(10)]
        public string Ten { get; set; }

        public int? MenhGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KEHOACHPHATHANH> CT_KEHOACHPHATHANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUDANGKYVE> CT_PHIEUDANGKYVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUNHANVE> CT_PHIEUNHANVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUTRARVE> CT_PHIEUTRARVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAITHUONG> GIAITHUONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUAXOSO> KETQUAXOSOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHANGIAI> PHIEUNHANGIAIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}
