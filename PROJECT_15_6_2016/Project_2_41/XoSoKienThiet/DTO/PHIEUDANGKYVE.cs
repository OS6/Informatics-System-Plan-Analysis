namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        [DisplayName("Mã phiếu đăng ký")]
        public string MaPhieuDangKy { get; set; }

        [StringLength(10)]
        [DisplayName("Mã đối tác")]
        public string MaDoiTac { get; set; }

        [StringLength(10)]
        [DisplayName("Mã nhân viên lập")]
        public string MaNhanVienLap { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DisplayName("Ngày lập")]
        public DateTime? NgayLap { get; set; }
        [DisplayName("Tổng số vé đăng ký")]
        public int? TongSoVeDangKy { get; set; }
    }
}
