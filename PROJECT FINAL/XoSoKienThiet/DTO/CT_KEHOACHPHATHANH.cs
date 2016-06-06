namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KEHOACHPHATHANH
    {
        public CT_KEHOACHPHATHANH() { }
        public CT_KEHOACHPHATHANH(string makehoach, string maloaive, int sovedukien, int sovethucte)
        {
            this.MaKeHoachPhatHanh = makehoach;
            this.MaLoaiVe = maloaive;
            this.SoVePhatHanhDuKien = sovedukien;
            this.SoVePhatHanhThucTe = sovethucte;
        }
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaKeHoachPhatHanh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        public int? SoVePhatHanhDuKien { get; set; }

        public int? SoVePhatHanhThucTe { get; set; }

        public virtual DOTPHATHANH DOTPHATHANH { get; set; }

        public virtual LOAIVE LOAIVE { get; set; }
    }
}
