namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIDOITAC")]
    public partial class LOAIDOITAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIDOITAC()
        {
            CT_BAOCAOTINHHINHTIEUTHU = new HashSet<CT_BAOCAOTINHHINHTIEUTHU>();
            DOITACs = new HashSet<DOITAC>();
        }

        [Key]
        [StringLength(10)]
        public string MaLoaiDoiTac { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BAOCAOTINHHINHTIEUTHU> CT_BAOCAOTINHHINHTIEUTHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOITAC> DOITACs { get; set; }
    }
}
