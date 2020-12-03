using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols;
using PTShop.Data.Configurations;
using PTShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.EF
{
    public class PTShopDbContext : DbContext
    {
        public PTShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DienThoaiConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietDonHangConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietThongSoKyThuatConfiguration());
            modelBuilder.ApplyConfiguration(new DonHangConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiThongSoKyThuatConfiguration());
            modelBuilder.ApplyConfiguration(new ThongSoKyThuatConfiguration());
            modelBuilder.ApplyConfiguration(new ThuongHieuConfiguration());
        }

        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public DbSet<ChiTietThongSoKyThuat> chiTietThongSoKyThuats { get; set; }

        public DbSet<AppConfig> AppConfigs { get; set; }


        public DbSet<DienThoai> DienThoais { get; set; }

        public DbSet<DonHang> DonHangs { get; set; }

        public DbSet<LoaiThongSoKyThuat> LoaiThongSoKyThuats { get; set; }

        public DbSet<ThongSoKyThuat> ThongSoKyThuats { get; set; }

        public DbSet<ThuongHieu> ThuongHieus { get; set; }
    }
}
