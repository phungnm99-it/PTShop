﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PTShop.Data.EF;

namespace PTShop.Data.Migrations
{
    [DbContext(typeof(PTShopDbContext))]
    partial class PTShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ChiTietDonHangDienThoai", b =>
                {
                    b.Property<int>("DienThoaisId")
                        .HasColumnType("int");

                    b.Property<int>("ChiTietDonHangsDonHangId")
                        .HasColumnType("int");

                    b.Property<int>("ChiTietDonHangsDienThoaiId")
                        .HasColumnType("int");

                    b.HasKey("DienThoaisId", "ChiTietDonHangsDonHangId", "ChiTietDonHangsDienThoaiId");

                    b.HasIndex("ChiTietDonHangsDonHangId", "ChiTietDonHangsDienThoaiId");

                    b.ToTable("ChiTietDonHangDienThoai");
                });

            modelBuilder.Entity("PTShop.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");
                });

            modelBuilder.Entity("PTShop.Data.Entities.ChiTietDonHang", b =>
                {
                    b.Property<int>("DonHangId")
                        .HasColumnType("int");

                    b.Property<int>("DienThoaiId")
                        .HasColumnType("int");

                    b.Property<float>("Gia")
                        .HasColumnType("real");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("DonHangId", "DienThoaiId");

                    b.ToTable("ChiTietDonHangs");
                });

            modelBuilder.Entity("PTShop.Data.Entities.ChiTietThongSoKyThuat", b =>
                {
                    b.Property<int>("DienThoaiId")
                        .HasColumnType("int");

                    b.Property<int>("ThongSoKyThuatId")
                        .HasColumnType("int");

                    b.Property<int>("ChiTiet")
                        .HasColumnType("int");

                    b.HasKey("DienThoaiId", "ThongSoKyThuatId");

                    b.ToTable("ChiTietThongSoKyThuats");
                });

            modelBuilder.Entity("PTShop.Data.Entities.DienThoai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Gia")
                        .HasColumnType("real");

                    b.Property<float>("GiaGoc")
                        .HasColumnType("real");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayRaMat")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("ThuongHieuId")
                        .HasColumnType("int");

                    b.Property<int>("TinhTrang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("DienThoais");
                });

            modelBuilder.Entity("PTShop.Data.Entities.DonHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("HinhThucThanhToan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime>("NgayDatHang")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("DonHangs");
                });

            modelBuilder.Entity("PTShop.Data.Entities.LoaiThongSoKyThuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiThongSoKyThuats");
                });

            modelBuilder.Entity("PTShop.Data.Entities.ThongSoKyThuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("LoaiThongSoKyThuatId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThongSoKyThuats");
                });

            modelBuilder.Entity("PTShop.Data.Entities.ThuongHieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThuongHieus");
                });

            modelBuilder.Entity("ChiTietDonHangDienThoai", b =>
                {
                    b.HasOne("PTShop.Data.Entities.DienThoai", null)
                        .WithMany()
                        .HasForeignKey("DienThoaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PTShop.Data.Entities.ChiTietDonHang", null)
                        .WithMany()
                        .HasForeignKey("ChiTietDonHangsDonHangId", "ChiTietDonHangsDienThoaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}