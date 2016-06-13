namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THAMSO")]
    public partial class THAMSO
    {
        public THAMSO() { }
        public THAMSO(float tiletieuthudat, float tiletienitnhattra, float tilehoahonglandau,
                     float tilehoahongtang, float tilehoahonggiam, int hantrave,
                     int songaynhangiai, int sodotganday, float chietkhaugiatrigiatang) 
        {
            this.TiLeTieuThuDat = tiletieuthudat;
            this.TiLeTienItNhatTra = tiletienitnhattra;
            this.TiLeHoaHongLanDau = tilehoahonglandau;
            this.TiLeHoaHongTang = tilehoahongtang;
            this.TiLeHoaHongGiam = tilehoahonggiam;
            this.HanTraVe = hantrave;
            this.SoNgayNhanGiai = songaynhangiai;
            this.SoDotGanDay = sodotganday;
            this.ChietKhauGiaTriGiaTang = chietkhaugiatrigiatang;
        }
        [Key]
        [Column(Order = 0)]
        public double TiLeTieuThuDat { get; set; }

        [Key]
        [Column(Order = 1)]
        public double TiLeTienItNhatTra { get; set; }

        [Key]
        [Column(Order = 2)]
        public double TiLeHoaHongLanDau { get; set; }

        [Key]
        [Column(Order = 3)]
        public double TiLeHoaHongTang { get; set; }

        [Key]
        [Column(Order = 4)]
        public double TiLeHoaHongGiam { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HanTraVe { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoNgayNhanGiai { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoDotGanDay { get; set; }

        [Key]
        [Column(Order = 8)]
        public double ChietKhauGiaTriGiaTang { get; set; }
    }
}
