namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHANVE")]
    public partial class PHIEUNHANVE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHANVE()
        {
        }

        public PHIEUNHANVE(string maphieudangky, int tongsove, DateTime ngaylap, string manhanvienlap, decimal tongtien)
        {
            this.MaPhieuDangKy = maphieudangky;
            this.TongSoVe = tongsove;
            this.NgayLap = ngaylap;
            this.MaNhanVienLap = manhanvienlap;
            this.TongTien = tongtien;
        }

        [Key]
        [StringLength(10)]
        public string MaPhieuNhanVe { get; set; }

        [StringLength(10)]
        public string MaPhieuDangKy { get; set; }

        public int? TongSoVe { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        [StringLength(10)]
        public string MaNhanVienLap { get; set; }

        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? TongTien { get; set; }

    }
}
