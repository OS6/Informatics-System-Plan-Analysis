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

        public PHIEUNHANVE(string maphieudangky, int tongsove, DateTime ngaylap, string manhanvienlap, float tongtien)
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

        public double? TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUNHANVE> CT_PHIEUNHANVE { get; set; }

        public virtual DOITAC DOITAC { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTRAVE> PHIEUTRAVEs { get; set; }
    }
}
