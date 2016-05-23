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
        }

        public PHIEUDANGKYVE(string madaily, string manhanvienlap, DateTime ngaylap, int tongsovedk)
        {
            this.MaDoiTac = madaily;
            this.MaNhanVienLap = manhanvienlap;
            this.NgayLap = ngaylap;
            this.TongSoVeDangKy = tongsovedk;
        }
        [Key]
        [StringLength(10)]
        public string MaPhieuDangKy { get; set; }

        [StringLength(10)]
        public string MaDoiTac { get; set; }

        [StringLength(10)]
        public string MaNhanVienLap { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        public int? TongSoVeDangKy { get; set; }
    }
}
