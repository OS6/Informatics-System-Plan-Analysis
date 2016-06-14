namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KEHOACHPHATHANH_VIEW
    {
        [Key]
        [StringLength(10)]
        [DisplayName("Mã loại vé")]
        public string MaLoaiVe { get; set; }
        [DisplayName("Mệnh giá")]
        public int? MenhGia { get; set; }
        [DisplayName("Số vé phát hành dự kiến")]
        public int? SoVePhatHanhDuKien { get; set; }
        [DisplayName("Số vé phát hành thực tế")]
        public int? SoVePhatHanhThucTe { get; set; }
    }
}
