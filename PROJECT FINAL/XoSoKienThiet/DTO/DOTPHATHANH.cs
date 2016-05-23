namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOTPHATHANH")]
    public partial class DOTPHATHANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOTPHATHANH()
        {
            BAOCAODOANHTHUTHEODOTs = new HashSet<BAOCAODOANHTHUTHEODOT>();
            CT_BAOCAODOANHTHUTHEOTHANG = new HashSet<CT_BAOCAODOANHTHUTHEOTHANG>();
            CT_KEHOACHPHATHANH = new HashSet<CT_KEHOACHPHATHANH>();
            CT_PHIEUDANGKYVE = new HashSet<CT_PHIEUDANGKYVE>();
            CT_PHIEUNHANVE = new HashSet<CT_PHIEUNHANVE>();
            CT_PHIEUNHANVE1 = new HashSet<CT_PHIEUNHANVE>();
            KETQUAXOSOes = new HashSet<KETQUAXOSO>();
            PHIEUCHIs = new HashSet<PHIEUCHI>();
            PHIEUNHANGIAIs = new HashSet<PHIEUNHANGIAI>();
            PHIEUTHANHTOANs = new HashSet<PHIEUTHANHTOAN>();
            PHIEUTRAVEs = new HashSet<PHIEUTRAVE>();
        }

        [Key]
        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayPhatHanh { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayXoSo { get; set; }

        [StringLength(10)]
        public string MaCongTy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOCAODOANHTHUTHEODOT> BAOCAODOANHTHUTHEODOTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BAOCAODOANHTHUTHEOTHANG> CT_BAOCAODOANHTHUTHEOTHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KEHOACHPHATHANH> CT_KEHOACHPHATHANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUDANGKYVE> CT_PHIEUDANGKYVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUNHANVE> CT_PHIEUNHANVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUNHANVE> CT_PHIEUNHANVE1 { get; set; }

        public virtual DOITAC DOITAC { get; set; }

        public virtual KEHOACHPHATHANH KEHOACHPHATHANH { get; set; }

        public virtual KEHOACHPHATHANH KEHOACHPHATHANH1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUAXOSO> KETQUAXOSOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHI> PHIEUCHIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHANGIAI> PHIEUNHANGIAIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHANHTOAN> PHIEUTHANHTOANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTRAVE> PHIEUTRAVEs { get; set; }
    }
}
