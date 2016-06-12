namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHSACHVETRUNG")]
    public partial class DANHSACHSOTRUNG
    {
        public DANHSACHSOTRUNG() { }
        public DANHSACHSOTRUNG(string mact_ketqua, int sotrung)
        {
            this.MaChiTietKQXS = mact_ketqua;
            this.SoTrung = sotrung;
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaChiTietKQXS { get; set; }

        [Key]
        [Column(Order = 1)]
        public int? SoTrung { get; set; }
    }
}
