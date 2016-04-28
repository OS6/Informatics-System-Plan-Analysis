namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDANGKYVE")]
    public partial class PHIEUDANGKYVE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDANGKYVE()
        {
            CT_PHIEUDANGKYVE = new HashSet<CT_PHIEUDANGKYVE>();
        }

        [Key]
        [StringLength(10)]
        public string MaPhieuDangKy { get; set; }

        [StringLength(10)]
        public string MaDaiLy { get; set; }

        [StringLength(10)]
        public string MaNhanVienLap { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        public int? TongSoVeDangKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUDANGKYVE> CT_PHIEUDANGKYVE { get; set; }

        public virtual DOITAC DOITAC { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
