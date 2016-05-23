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
            
        }

        public PHIEUTRAVE(string maphieunhanve, string manhanvienlap, DateTime ngaylap, int tongsovetra)
        {
            this.MaPhieuNhanVe = maphieunhanve;
            this.MaNhanVienLap = manhanvienlap;
            this.NgayLap = ngaylap;
            this.TongSoVeTra = tongsovetra;
        }

        [Key]
        [StringLength(10)]
        public string MaPhieuTraVe { get; set; }

        [StringLength(10)]
        public string MaPhieuNhanVe { get; set; }

        [StringLength(10)]
        public string MaNhanVienLap { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        public int TongSoVeTra { get; set; }

       
    }
}
