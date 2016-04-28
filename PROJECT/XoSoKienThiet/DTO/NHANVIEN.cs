namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            BOPHANs = new HashSet<BOPHAN>();
            PHIEUCHIs = new HashSet<PHIEUCHI>();
            PHIEUDANGKYVEs = new HashSet<PHIEUDANGKYVE>();
            PHIEUNHANGIAIs = new HashSet<PHIEUNHANGIAI>();
            PHIEUNHANVEs = new HashSet<PHIEUNHANVE>();
            PHIEUTHANHTOANs = new HashSet<PHIEUTHANHTOAN>();
            PHIEUTRAVEs = new HashSet<PHIEUTRAVE>();
        }

        [Key]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [StringLength(10)]
        public string MaBoPhan { get; set; }

        [StringLength(10)]
        public string MaChucVu { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPHAN> BOPHANs { get; set; }

        public virtual BOPHAN BOPHAN { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHI> PHIEUCHIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDANGKYVE> PHIEUDANGKYVEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHANGIAI> PHIEUNHANGIAIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHANVE> PHIEUNHANVEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHANHTOAN> PHIEUTHANHTOANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTRAVE> PHIEUTRAVEs { get; set; }
    }
}
