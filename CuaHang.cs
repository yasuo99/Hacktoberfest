using System.Data.Entity;
namespace CuaHangSuaXe
{
    
    public class CuaHang : DbContext
    {
        public CuaHang():base("CuaHangSuaXe")
        {
            Database.SetInitializer<CuaHang>(new KhoiTaoCuaHang());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ThoConfigurations());

            modelBuilder.Entity<QuanLy>().ToTable("QuanLyInfo");

            modelBuilder.Entity<QuanLy>().MapToStoredProcedures();
            modelBuilder.Entity<ThoCongViecs>().HasKey(c => new { c.ThoId, c.CongViecId });
            modelBuilder.Entity<Tho>().HasMany(c => c.ThoCongViecs).WithRequired().HasForeignKey(fr => fr.ThoId);
            modelBuilder.Entity<CongViec>().HasMany(c => c.ThoCongViecs).WithRequired().HasForeignKey(fr => fr.CongViecId);
            modelBuilder.Entity<HopDongCongViecs>().HasKey(c => new { c.HopDongId, c.CongViecId });            
            modelBuilder.Entity<CongViec>().HasMany(c => c.HopDongCongViecs).WithRequired().HasForeignKey(fr => fr.CongViecId);
            modelBuilder.Entity<HopDong>().HasMany(c => c.HopDongCongViecs).WithRequired().HasForeignKey(fr => fr.HopDongId);
        }
       
        public DbSet<Tho> Thos { get; set; }
        public DbSet<NhomTho> NhomThos { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Xe> Xes { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<CongViec> CongViecs { get; set; }
        public DbSet<PhieuThu> PhieuThus { get; set; }
        public DbSet<ThoCongViecs> ThoCongViecs { get; set; }
    }
}
