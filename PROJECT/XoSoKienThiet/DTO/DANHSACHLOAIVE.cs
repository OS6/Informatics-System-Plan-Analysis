namespace XoSoKienThiet.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHSACHLOAIVE")]
    public partial class DANHSACHLOAIVE
    {
        public DANHSACHLOAIVE()
        {

        }
        public DANHSACHLOAIVE(string macongty, string maloaive)
        {
            this.MaCongTy = macongty;
            this.MaLoaiVe = maloaive;
        }
        [Key]
        [StringLength(10)]
        public string MaDanhSach { get; set; }

        [StringLength(10)]
        public string MaCongTy { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }
    }
}
