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

        public GIAITHUONG(string maloaive, string ten, decimal sotientrung, int sogiai, string magiaithuong = "")
        {
            this.MaLoaiVe = maloaive;
            this.Ten = ten;
            this.SoTienTrung = sotientrung;
            this.SoGiai = sogiai;
            this.MaGiaiThuong = magiaithuong;
        }

        [Key]
        [StringLength(10)]
        public string MaGiaiThuong { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [StringLength(25)]
        [DisplayName("Tên giải thưởng")]
        public string Ten { get; set; }

        [Column(TypeName = "money")]
        [DisplayName("Số tiền trúng")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? SoTienTrung { get; set; }

        [DisplayName("Số giải")]
        public int? SoGiai { get; set; }

        [DisplayName("Tổng tiền trúng")]
        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "N0")]
        public decimal? TongTienTrung { get; set; }
        
    }
}
