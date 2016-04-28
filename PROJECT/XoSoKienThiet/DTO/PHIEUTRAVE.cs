namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTRAVE")]
    public partial class PHIEUTRAVE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTRAVE()
        {
            CT_PHIEUTRARVE = new HashSet<CT_PHIEUTRARVE>();
            CT_PHIEUTRARVE1 = new HashSet<CT_PHIEUTRARVE>();
        }

        [Key]
        [StringLength(10)]
        public string SoPhieu { get; set; }

        [StringLength(10)]
        public string MaPhieuNhanVe { get; set; }

        [StringLength(10)]
        public string MaDotPhatHanh { get; set; }

        [StringLength(10)]
        public string MaNhanVienLap { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        [StringLength(10)]
        public string TongSoVeTra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUTRARVE> CT_PHIEUTRARVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUTRARVE> CT_PHIEUTRARVE1 { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHIEUNHANVE PHIEUNHANVE { get; set; }
    }
}
