namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KETQUAXOSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_KETQUAXOSO()
        {
            DANHSACHVETRUNGs = new HashSet<DANHSACHVETRUNG>();
        }

        [Key]
        [StringLength(10)]
        public string MaChiTietKQXS { get; set; }

        [StringLength(10)]
        public string MaKetQuaXoSo { get; set; }

        [StringLength(10)]
        public string MaGiaiThuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        public virtual KETQUAXOSO KETQUAXOSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHVETRUNG> DANHSACHVETRUNGs { get; set; }
    }
}
