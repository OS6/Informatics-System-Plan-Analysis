namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAITHUONG")]
    public partial class GIAITHUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAITHUONG()
        {
            CT_KETQUAXOSO = new HashSet<CT_KETQUAXOSO>();
        }

        [Key]
        [StringLength(10)]
        public string MaGiaiThuong { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [StringLength(25)]
        public string Ten { get; set; }

        public int? SoTienTrung { get; set; }

        public int? SoGiai { get; set; }

        public int? TongTienTrung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KETQUAXOSO> CT_KETQUAXOSO { get; set; }

        public virtual LOAIVE LOAIVE { get; set; }
    }
}
