namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KETQUAXOSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_KETQUAXOSO()
        {
           
        }

        public CT_KETQUAXOSO(string maketquaxoso, string magiaithuong, int soluongvetrung, decimal tongtien, string machitietketqua = "")
        {
            this.MaKetQuaXoSo = maketquaxoso;
            this.MaGiaiThuong = magiaithuong;
            this.SoLuongVeTrung = soluongvetrung;
            this.TongTien = tongtien;
            this.MaChiTietKQXS = machitietketqua;
        }

        [Key]
        [StringLength(10)]
        public string MaChiTietKQXS { get; set; }

        [StringLength(10)]
        public string MaKetQuaXoSo { get; set; }

        [StringLength(10)]
        public string MaGiaiThuong { get; set; }

        public int SoLuongVeTrung { get; set; }
        public decimal? TongTien { get; set; }

        public virtual KETQUAXOSO KETQUAXOSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHSOTRUNG> DANHSACHVETRUNGs { get; set; }
    }
}
