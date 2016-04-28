namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOCAODOANHTHUTHEOTHANG")]
    public partial class BAOCAODOANHTHUTHEOTHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAOCAODOANHTHUTHEOTHANG()
        {
            CT_BAOCAODOANHTHUTHEOTHANG = new HashSet<CT_BAOCAODOANHTHUTHEOTHANG>();
        }

        [Key]
        [StringLength(10)]
        public string MaBaoCao { get; set; }

        public int? Thang { get; set; }

        public int? Nam { get; set; }

        public double? TongLoiNhuan { get; set; }

        public double? CongQuy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BAOCAODOANHTHUTHEOTHANG> CT_BAOCAODOANHTHUTHEOTHANG { get; set; }
    }
}
