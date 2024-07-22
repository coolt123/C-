using Microsoft.EntityFrameworkCore;
using PhamKimThe0000466.Entities;

namespace PhamKimThe0000466.DbContexts
{
    public class MyDbContext0000466De1 : DbContext
    {

        public MyDbContext0000466De1(DbContextOptions options) : base(options) { }

        public DbSet<DoanhNghiep0000466De1> DoanhNghieps { get; set; }
        public DbSet<SanPham0000466De1> SanPhams { get; set; }
        public DbSet<SanPhamDoanhNghiep0000466De1> SanPhamDoanhNghieps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DoanhNghiep0000466De1>()
                .HasIndex(d => d.MaSoThue)
                .IsUnique();

            modelBuilder.Entity<SanPham0000466De1>()
                .HasIndex(s => s.MaSanPham)
                .IsUnique();

            modelBuilder.Entity<SanPhamDoanhNghiep0000466De1>()
                .HasKey(sp => new { sp.DoanhNghiepId, sp.SanPhamId });

            modelBuilder.Entity<SanPhamDoanhNghiep0000466De1>()
                .HasOne(sp => sp.DoanhNghiep)
                .WithMany(d => d.SanPhamDoanhNghieps)
                .HasForeignKey(sp => sp.DoanhNghiepId);

            modelBuilder.Entity<SanPhamDoanhNghiep0000466De1>()
                .HasOne(sp => sp.SanPham)
                .WithMany(s => s.SanPhamDoanhNghieps)
                .HasForeignKey(sp => sp.SanPhamId);


        }
    }
}
