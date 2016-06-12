namespace XoSoKienThiet.DTO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class XoSoKienThietDbContext : DbContext
    {
        public XoSoKienThietDbContext()
            : base("name=XoSoKienThietDbContext")
        {
        }

        public virtual DbSet<BAOCAODOANHTHUTHEODOT> BAOCAODOANHTHUTHEODOTs { get; set; }
        public virtual DbSet<BAOCAODOANHTHUTHEONAM> BAOCAODOANHTHUTHEONAMs { get; set; }
        public virtual DbSet<BAOCAODOANHTHUTHEOTHANG> BAOCAODOANHTHUTHEOTHANGs { get; set; }
        public virtual DbSet<BAOCAOTINHHINHCONGNOVOIDOITAC> BAOCAOTINHHINHCONGNOVOIDOITACs { get; set; }
        public virtual DbSet<BAOCAOTINHHINHTIEUTHUCACDAILY> BAOCAOTINHHINHTIEUTHUCACDAILies { get; set; }
        public virtual DbSet<BOPHAN> BOPHANs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<COCAUTOCHUC> COCAUTOCHUCs { get; set; }
        public virtual DbSet<CT_BAOCAODOANHTHUTHEONAM> CT_BAOCAODOANHTHUTHEONAM { get; set; }
        public virtual DbSet<CT_BAOCAODOANHTHUTHEOTHANG> CT_BAOCAODOANHTHUTHEOTHANG { get; set; }
        public virtual DbSet<CT_BAOCAOTINHHINHTIEUTHU> CT_BAOCAOTINHHINHTIEUTHU { get; set; }
        public virtual DbSet<CT_KEHOACHPHATHANH> CT_KEHOACHPHATHANH { get; set; }
        public virtual DbSet<CT_KEHOACHPHATHANH_VIEW> CT_KEHOACHPHATHANH_VIEW { get; set; }
        public virtual DbSet<CT_PHIEUDANGKYVE> CT_PHIEUDANGKYVE { get; set; }
        public virtual DbSet<CT_KETQUAXOSO_VIEW> CT_KETQUAXOSO_VIEW { get; set; }
        public virtual DbSet<CT_KQXS_GIAITHUONG_VIEW> CT_KQXS_GIAITHUONG_VIEW { get; set; }
        public virtual DbSet<CT_PHIEUDANGKYVE_VIEW> CT_PHIEUDANGKYVE_VIEW { get; set; }
        public virtual DbSet<CT_PHIEUTRAVE_VIEW> CT_PHIEUTRAVE_VIEW { get; set; }
        public virtual DbSet<CT_PHIEUNHANVE> CT_PHIEUNHANVE { get; set; }
        public virtual DbSet<CT_PHIEUTRAVE> CT_PHIEUTRAVE { get; set; }
        public virtual DbSet<DOITAC> DOITACs { get; set; }
        public virtual DbSet<DOTPHATHANH> DOTPHATHANHs { get; set; }
        public virtual DbSet<GIAITHUONG> GIAITHUONGs { get; set; }
        public virtual DbSet<KEHOACHPHATHANH> KEHOACHPHATHANHs { get; set; }  public virtual DbSet<CT_KETQUAXOSO> CT_KETQUAXOSO { get; set; }
        public virtual DbSet<DANHSACHSOTRUNG> DANHSACHVETRUNGs { get; set; }
        public virtual DbSet<KETQUAXOSO> KETQUAXOSOes { get; set; }
        public virtual DbSet<LOAIDOITAC> LOAIDOITACs { get; set; }
        public virtual DbSet<LOAIVE> LOAIVEs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHANVIEN_VIEW> NHANVIEN_VIEW { get; set; }
        public virtual DbSet<PHIEUCHI> PHIEUCHIs { get; set; }
        public virtual DbSet<PHIEUDANGKYVE> PHIEUDANGKYVEs { get; set; }
        public virtual DbSet<PHIEUDANGKYVE_DOITAC_VIEW> PHIEUDANGKYVE_DOITAC_VIEWs { get; set; }
        public virtual DbSet<PHIEUNHANVE_DOITAC_VIEW> PHIEUNHANVE_DOITAC_VIEWs { get; set; }
        public virtual DbSet<PHIEUNHANGIAI> PHIEUNHANGIAIs { get; set; }
        public virtual DbSet<PHIEUNHANVE> PHIEUNHANVEs { get; set; }
        public virtual DbSet<PHIEUTHANHTOAN> PHIEUTHANHTOANs { get; set; }
        public virtual DbSet<PHIEUTRAVE> PHIEUTRAVEs { get; set; }
        public virtual DbSet<VE> VEs { get; set; }
        public virtual DbSet<CT_PHIEUNHANVE_VIEW> CT_PHIEUNHANVE_VIEW { get; set; }
    }
}
