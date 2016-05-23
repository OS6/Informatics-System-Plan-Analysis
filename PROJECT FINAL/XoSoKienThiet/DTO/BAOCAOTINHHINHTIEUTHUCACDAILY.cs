namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAOCAOTINHHINHTIEUTHUCACDAILY")]
    public partial class BAOCAOTINHHINHTIEUTHUCACDAILY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAOCAOTINHHINHTIEUTHUCACDAILY()
        {
            CT_BAOCAOTINHHINHTIEUTHU = new HashSet<CT_BAOCAOTINHHINHTIEUTHU>();
        }

        [Key]
        [StringLength(10)]
        public string MaBaoCao { get; set; }

        public int? SoDotPhatHanhGanDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BAOCAOTINHHINHTIEUTHU> CT_BAOCAOTINHHINHTIEUTHU { get; set; }
    }
}
