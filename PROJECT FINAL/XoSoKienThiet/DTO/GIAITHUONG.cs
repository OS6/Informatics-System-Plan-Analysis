namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAITHUONG")]
    public partial class GIAITHUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAITHUONG()
        {
        }

        public GIAITHUONG(string maloaive, string ten, int sotientrung, int sogiai)
        {
            this.MaLoaiVe = maloaive;
            this.Ten = ten;
            this.SoTienTrung = sotientrung;
            this.SoGiai = sogiai;
        }

        [Key]
        [StringLength(10)]
        public string MaGiaiThuong { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [StringLength(25)]
        [DisplayName("Tên giải thưởng")]
        public string Ten { get; set; }

        [DisplayName("Số tiền trúng")]
        public int? SoTienTrung { get; set; }

        [DisplayName("Số giải")]
        public int? SoGiai { get; set; }

        [DisplayName("Tổng tiền trúng")]
        public int? TongTienTrung { get; set; }
    }
}
