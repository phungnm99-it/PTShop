using Microsoft.EntityFrameworkCore;
using PTShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is homepage of PTShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of PTShop" }
                );

            modelBuilder.Entity<DienThoai>().HasData(
                new DienThoai()
                {
                    Id = 1,
                    Name = "Xiaomi Note 9",
                    TinhTrang = Enums.TrangThaiDienThoai.DangKinhDoanh,
                    Gia = 5000000,
                    GiaGoc = 4000000,
                    SoLuong = 1,
                    NgayRaMat = Convert.ToDateTime("10/10/2020"),
                    ThuongHieuId = 1,
                    HinhAnh = "https://cdn.tgdd.vn/Products/Images/42/227731/realme-7-043120-113149-400x460.png"
                },
                new DienThoai()
                {
                    Id = 2,
                    Name = "Xiaomi Note 10",
                    TinhTrang = Enums.TrangThaiDienThoai.DangKinhDoanh,
                    Gia = 5000000,
                    GiaGoc = 4000000,
                    SoLuong = 1,
                    NgayRaMat = Convert.ToDateTime("10/10/2020"),
                    ThuongHieuId = 1,
                    HinhAnh = "https://cdn.tgdd.vn/Products/Images/42/227731/realme-7-043120-113149-400x460.png"
                },
                new DienThoai()
                {
                    Id = 3,
                    Name = "Xiaomi Note 11",
                    TinhTrang = Enums.TrangThaiDienThoai.DangKinhDoanh,
                    Gia = 5000000,
                    GiaGoc = 4000000,
                    SoLuong = 1,
                    NgayRaMat = Convert.ToDateTime("10/10/2019"),
                    ThuongHieuId = 1,
                    HinhAnh = "https://cdn.tgdd.vn/Products/Images/42/227731/realme-7-043120-113149-400x460.png"
                }
                );
            modelBuilder.Entity<ThuongHieu>().HasData(
                new ThuongHieu() { Id = 1, Name = "Xiaomi" },
                new ThuongHieu() { Id = 2, Name = "Samsung" }
                );
        }
    }
}
