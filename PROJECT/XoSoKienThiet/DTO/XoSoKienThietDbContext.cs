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
        public virtual DbSet<CODEMASTER> CODEMASTERS { get; set; }
        public virtual DbSet<CT_BAOCAODOANHTHUTHEONAM> CT_BAOCAODOANHTHUTHEONAM { get; set; }
        public virtual DbSet<CT_BAOCAODOANHTHUTHEOTHANG> CT_BAOCAODOANHTHUTHEOTHANG { get; set; }
        public virtual DbSet<CT_BAOCAOTINHHINHTIEUTHU> CT_BAOCAOTINHHINHTIEUTHU { get; set; }
        public virtual DbSet<CT_KEHOACHPHATHANH> CT_KEHOACHPHATHANH { get; set; }
        public virtual DbSet<CT_KETQUAXOSO> CT_KETQUAXOSO { get; set; }
        public virtual DbSet<CT_PHIEUDANGKYVE> CT_PHIEUDANGKYVE { get; set; }
        public virtual DbSet<CT_PHIEUNHANVE> CT_PHIEUNHANVE { get; set; }
        public virtual DbSet<CT_PHIEUTRARVE> CT_PHIEUTRARVE { get; set; }
        public virtual DbSet<DOITAC> DOITACs { get; set; }
        public virtual DbSet<DOTPHATHANH> DOTPHATHANHs { get; set; }
        public virtual DbSet<GIAITHUONG> GIAITHUONGs { get; set; }
        public virtual DbSet<KEHOACHPHATHANH> KEHOACHPHATHANHs { get; set; }
        public virtual DbSet<KETQUAXOSO> KETQUAXOSOes { get; set; }
        public virtual DbSet<LOAIDOITAC> LOAIDOITACs { get; set; }
        public virtual DbSet<LOAIVE> LOAIVEs { get; set; }
        public virtual DbSet<NGUOINOP> NGUOINOPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUCHI> PHIEUCHIs { get; set; }
        public virtual DbSet<PHIEUDANGKYVE> PHIEUDANGKYVEs { get; set; }
        public virtual DbSet<PHIEUNHANGIAI> PHIEUNHANGIAIs { get; set; }
        public virtual DbSet<PHIEUNHANVE> PHIEUNHANVEs { get; set; }
        public virtual DbSet<PHIEUTHANHTOAN> PHIEUTHANHTOANs { get; set; }
        public virtual DbSet<PHIEUTRAVE> PHIEUTRAVEs { get; set; }
        public virtual DbSet<PREFIX> PREFIXes { get; set; }
        public virtual DbSet<VE> VEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAOCAODOANHTHUTHEODOT>()
                .Property(e => e.MaBaoCao)
                .IsFixedLength();

            modelBuilder.Entity<BAOCAODOANHTHUTHEODOT>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<BAOCAODOANHTHUTHEONAM>()
                .Property(e => e.MaBaoCao)
                .IsFixedLength();

            modelBuilder.Entity<BAOCAODOANHTHUTHEONAM>()
                .HasMany(e => e.CT_BAOCAODOANHTHUTHEONAM)
                .WithRequired(e => e.BAOCAODOANHTHUTHEONAM)
                .HasForeignKey(e => e.MaBaoCaoDoanhThu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BAOCAODOANHTHUTHEOTHANG>()
                .Property(e => e.MaBaoCao)
                .IsFixedLength();

            modelBuilder.Entity<BAOCAODOANHTHUTHEOTHANG>()
                .HasMany(e => e.CT_BAOCAODOANHTHUTHEOTHANG)
                .WithRequired(e => e.BAOCAODOANHTHUTHEOTHANG)
                .HasForeignKey(e => e.MaBaoCaoDoanhThu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BAOCAOTINHHINHCONGNOVOIDOITAC>()
                .Property(e => e.MaBaoCao)
                .IsFixedLength();

            modelBuilder.Entity<BAOCAOTINHHINHCONGNOVOIDOITAC>()
                .Property(e => e.MaDoiTac)
                .IsFixedLength();

            modelBuilder.Entity<BAOCAOTINHHINHTIEUTHUCACDAILY>()
                .Property(e => e.MaBaoCao)
                .IsFixedLength();

            modelBuilder.Entity<BAOCAOTINHHINHTIEUTHUCACDAILY>()
                .HasMany(e => e.CT_BAOCAOTINHHINHTIEUTHU)
                .WithRequired(e => e.BAOCAOTINHHINHTIEUTHUCACDAILY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPHAN>()
                .Property(e => e.MaBoPhan)
                .IsFixedLength();

            modelBuilder.Entity<BOPHAN>()
                .Property(e => e.MaQuanLy)
                .IsFixedLength();

            modelBuilder.Entity<BOPHAN>()
                .Property(e => e.Ten)
                .IsFixedLength();

            modelBuilder.Entity<BOPHAN>()
                .HasMany(e => e.NHANVIENs)
                .WithOptional(e => e.BOPHAN)
                .HasForeignKey(e => e.MaBoPhan);

            modelBuilder.Entity<BOPHAN>()
                .HasMany(e => e.PHIEUCHIs)
                .WithOptional(e => e.BOPHAN)
                .HasForeignKey(e => e.MaDonVi);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MaChucVu)
                .IsFixedLength();

            modelBuilder.Entity<COCAUTOCHUC>()
                .Property(e => e.MaCoCauToChuc)
                .IsFixedLength();

            modelBuilder.Entity<COCAUTOCHUC>()
                .Property(e => e.MaBoPhan)
                .IsFixedLength();

            modelBuilder.Entity<COCAUTOCHUC>()
                .Property(e => e.MaChucVu)
                .IsFixedLength();

            modelBuilder.Entity<CT_BAOCAODOANHTHUTHEONAM>()
                .Property(e => e.MaChiTiet)
                .IsFixedLength();

            modelBuilder.Entity<CT_BAOCAODOANHTHUTHEONAM>()
                .Property(e => e.MaBaoCaoDoanhThu)
                .IsFixedLength();

            modelBuilder.Entity<CT_BAOCAODOANHTHUTHEOTHANG>()
                .Property(e => e.MaChiTiet)
                .IsFixedLength();

            modelBuilder.Entity<CT_BAOCAODOANHTHUTHEOTHANG>()
                .Property(e => e.MaBaoCaoDoanhThu)
                .IsFixedLength();

            modelBuilder.Entity<CT_BAOCAODOANHTHUTHEOTHANG>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<CT_BAOCAOTINHHINHTIEUTHU>()
                .Property(e => e.MaChiTiet)
                .IsFixedLength();

            modelBuilder.Entity<CT_BAOCAOTINHHINHTIEUTHU>()
                .Property(e => e.MaBaoCao)
                .IsFixedLength();

            modelBuilder.Entity<CT_BAOCAOTINHHINHTIEUTHU>()
                .Property(e => e.MaDaiLy)
                .IsFixedLength();

            modelBuilder.Entity<CT_BAOCAOTINHHINHTIEUTHU>()
                .Property(e => e.TiLeTieuThuTrungBinh)
                .IsFixedLength();

            modelBuilder.Entity<CT_KEHOACHPHATHANH>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<CT_KEHOACHPHATHANH>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength();

            modelBuilder.Entity<CT_KETQUAXOSO>()
                .Property(e => e.MaChiTietKetQua)
                .IsFixedLength();

            modelBuilder.Entity<CT_KETQUAXOSO>()
                .Property(e => e.MaKetQua)
                .IsFixedLength();

            modelBuilder.Entity<CT_KETQUAXOSO>()
                .Property(e => e.MaVeTrung)
                .IsFixedLength();

            modelBuilder.Entity<CT_KETQUAXOSO>()
                .Property(e => e.MaGiaiThuong)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUDANGKYVE>()
                .Property(e => e.MaChiTietPhieuDangKy)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUDANGKYVE>()
                .Property(e => e.MaPhieuDangKy)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUDANGKYVE>()
                .Property(e => e.MaCongTy)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUDANGKYVE>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUDANGKYVE>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUNHANVE>()
                .Property(e => e.MaChiTietPhieuNhan)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUNHANVE>()
                .Property(e => e.MaPhieuNhanVe)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUNHANVE>()
                .Property(e => e.MaDoiTac)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUNHANVE>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUNHANVE>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUTRARVE>()
                .Property(e => e.MaChiTietPhieuTra)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUTRARVE>()
                .Property(e => e.MaPhieuTraVe)
                .IsFixedLength();

            modelBuilder.Entity<CT_PHIEUTRARVE>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength();

            modelBuilder.Entity<DOITAC>()
                .Property(e => e.MaDoiTac)
                .IsFixedLength();

            modelBuilder.Entity<DOITAC>()
                .Property(e => e.MaLoaiDoiTac)
                .IsFixedLength();

            modelBuilder.Entity<DOITAC>()
                .Property(e => e.SDT)
                .IsFixedLength();

           
            modelBuilder.Entity<DOTPHATHANH>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<DOTPHATHANH>()
                .Property(e => e.MaCongTy)
                .IsFixedLength();

            modelBuilder.Entity<DOTPHATHANH>()
                .HasMany(e => e.CT_KEHOACHPHATHANH)
                .WithRequired(e => e.DOTPHATHANH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOTPHATHANH>()
                .HasMany(e => e.CT_PHIEUNHANVE)
                .WithOptional(e => e.DOTPHATHANH)
                .HasForeignKey(e => e.MaDotPhatHanh);

            modelBuilder.Entity<DOTPHATHANH>()
                .HasMany(e => e.CT_PHIEUNHANVE1)
                .WithOptional(e => e.DOTPHATHANH1)
                .HasForeignKey(e => e.MaDotPhatHanh);

            modelBuilder.Entity<DOTPHATHANH>()
                .HasOptional(e => e.KEHOACHPHATHANH1)
                .WithRequired(e => e.DOTPHATHANH1);

            modelBuilder.Entity<GIAITHUONG>()
                .Property(e => e.MaGiaiThuong)
                .IsFixedLength();

            modelBuilder.Entity<GIAITHUONG>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength();

            modelBuilder.Entity<KEHOACHPHATHANH>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<KEHOACHPHATHANH>()
                .HasOptional(e => e.DOTPHATHANH)
                .WithRequired(e => e.KEHOACHPHATHANH);

            modelBuilder.Entity<KETQUAXOSO>()
                .Property(e => e.MaKetQua)
                .IsFixedLength();

            modelBuilder.Entity<KETQUAXOSO>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<KETQUAXOSO>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength();

            modelBuilder.Entity<KETQUAXOSO>()
                .HasMany(e => e.CT_KETQUAXOSO)
                .WithRequired(e => e.KETQUAXOSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIDOITAC>()
                .Property(e => e.MaLoaiDoiTac)
                .IsFixedLength();

            modelBuilder.Entity<LOAIDOITAC>()
                .HasMany(e => e.CT_BAOCAOTINHHINHTIEUTHU)
                .WithOptional(e => e.LOAIDOITAC)
                .HasForeignKey(e => e.MaDaiLy);

            modelBuilder.Entity<LOAIVE>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength();

            modelBuilder.Entity<LOAIVE>()
                .Property(e => e.Ten)
                .IsFixedLength();

            modelBuilder.Entity<LOAIVE>()
                .HasMany(e => e.CT_KEHOACHPHATHANH)
                .WithRequired(e => e.LOAIVE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIVE>()
                .HasMany(e => e.CT_PHIEUNHANVE)
                .WithOptional(e => e.LOAIVE)
                .HasForeignKey(e => e.MaDoiTac);

            modelBuilder.Entity<NGUOINOP>()
                .Property(e => e.MaNguoiNop)
                .IsFixedLength();

            modelBuilder.Entity<NGUOINOP>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaBoPhan)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaChucVu)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.BOPHANs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.MaQuanLy);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUCHIs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.MaNhanVienLap);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUDANGKYVEs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.MaNhanVienLap);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUNHANGIAIs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.MaNhanVienLap);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUNHANVEs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.MaNhanVienLap);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTHANHTOANs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.MaNhanVienLap);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTRAVEs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.MaNhanVienLap);

            modelBuilder.Entity<PHIEUCHI>()
                .Property(e => e.MaPhieuChi)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUCHI>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUCHI>()
                .Property(e => e.MaDonVi)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUCHI>()
                .Property(e => e.MaNhanVienLap)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUDANGKYVE>()
                .Property(e => e.MaPhieuDangKy)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUDANGKYVE>()
                .Property(e => e.MaDaiLy)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUDANGKYVE>()
                .Property(e => e.MaNhanVienLap)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANGIAI>()
                .Property(e => e.MaPhieuNhanGiai)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANGIAI>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANGIAI>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANGIAI>()
                .Property(e => e.MaGiaiThuong)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANGIAI>()
                .Property(e => e.MaNhanVienLap)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANGIAI>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANGIAI>()
                .Property(e => e.CMND)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANVE>()
                .Property(e => e.MaPhieuNhanVe)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANVE>()
                .Property(e => e.MaDoiTac)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANVE>()
                .Property(e => e.MaNhanVienLap)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUNHANVE>()
                .HasMany(e => e.CT_PHIEUNHANVE)
                .WithRequired(e => e.PHIEUNHANVE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUTHANHTOAN>()
                .Property(e => e.MaPhieuThanhToan)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTHANHTOAN>()
                .Property(e => e.MaDaiLy)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTHANHTOAN>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTHANHTOAN>()
                .Property(e => e.MaNhanVienLap)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTHANHTOAN>()
                .Property(e => e.MaNguoiNop)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTRAVE>()
                .Property(e => e.SoPhieu)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTRAVE>()
                .Property(e => e.MaPhieuNhanVe)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTRAVE>()
                .Property(e => e.MaDotPhatHanh)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTRAVE>()
                .Property(e => e.MaNhanVienLap)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTRAVE>()
                .Property(e => e.TongSoVeTra)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTRAVE>()
                .HasMany(e => e.CT_PHIEUTRARVE)
                .WithOptional(e => e.PHIEUTRAVE)
                .HasForeignKey(e => e.MaPhieuTraVe);

            modelBuilder.Entity<PHIEUTRAVE>()
                .HasMany(e => e.CT_PHIEUTRARVE1)
                .WithOptional(e => e.PHIEUTRAVE1)
                .HasForeignKey(e => e.MaPhieuTraVe);

            modelBuilder.Entity<VE>()
                .Property(e => e.MaVe)
                .IsFixedLength();

            modelBuilder.Entity<VE>()
                .Property(e => e.MaLoaiVe)
                .IsFixedLength();

            modelBuilder.Entity<VE>()
                .Property(e => e.SoVe)
                .IsFixedLength();

            modelBuilder.Entity<VE>()
                .HasMany(e => e.CT_KETQUAXOSO)
                .WithOptional(e => e.VE)
                .HasForeignKey(e => e.MaVeTrung);
        }
    }
}
