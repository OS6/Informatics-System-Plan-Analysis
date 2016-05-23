namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOCAODOANHTHUTHEONAM")]
    public partial class BAOCAODOANHTHUTHEONAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAOCAODOANHTHUTHEONAM()
        {
            CT_BAOCAODOANHTHUTHEONAM = new HashSet<CT_BAOCAODOANHTHUTHEONAM>();
        }

        [Key]
        [StringLength(10)]
        public string MaBaoCao { get; set; }

        public int? Nam { get; set; }

        public double? TongLoiNhuan { get; set; }

        public double? TongCongQuy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BAOCAODOANHTHUTHEONAM> CT_BAOCAODOANHTHUTHEONAM { get; set; }
    }
}
