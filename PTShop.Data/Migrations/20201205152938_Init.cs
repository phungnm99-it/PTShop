using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTShop.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHangs",
                columns: table => new
                {
                    DonHangId = table.Column<int>(type: "int", nullable: false),
                    DienThoaiId = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHangs", x => new { x.DonHangId, x.DienThoaiId });
                });

            migrationBuilder.CreateTable(
                name: "ChiTietThongSoKyThuats",
                columns: table => new
                {
                    DienThoaiId = table.Column<int>(type: "int", nullable: false),
                    ManHinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeDieuHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CameraSau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CameraTruoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoNhoTrong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TheSim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DungLuongPin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayRaMat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietThongSoKyThuats", x => x.DienThoaiId);
                });

            migrationBuilder.CreateTable(
                name: "DienThoais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "DangKinhDoanh"),
                    Gia = table.Column<float>(type: "real", nullable: false),
                    GiaGoc = table.Column<float>(type: "real", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ThuongHieuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienThoais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDatHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HinhThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "ThanhToanTrucTiep"),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "ChuaGiaoHang")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sdt = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is homepage of PTShop" },
                    { "HomeDescription", "This is description of PTShop" }
                });

            migrationBuilder.InsertData(
                table: "DienThoais",
                columns: new[] { "Id", "Gia", "GiaGoc", "HinhAnh", "Name", "SoLuong", "ThuongHieuId", "TinhTrang" },
                values: new object[,]
                {
                    { 1, 5000000f, 4000000f, "https://cdn.tgdd.vn/Products/Images/42/227731/realme-7-043120-113149-400x460.png", "Xiaomi Note 9", 1, 1, "Dang kinh doanh" },
                    { 2, 5000000f, 4000000f, "https://cdn.tgdd.vn/Products/Images/42/227731/realme-7-043120-113149-400x460.png", "Xiaomi Note 10", 1, 1, "Dang kinh doanh" },
                    { 3, 5000000f, 4000000f, "https://cdn.tgdd.vn/Products/Images/42/227731/realme-7-043120-113149-400x460.png", "Xiaomi Note 11", 1, 1, "Dang kinh doanh" }
                });

            migrationBuilder.InsertData(
                table: "ThuongHieus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Xiaomi" },
                    { 2, "Samsung" },
                    { 3, "Nokia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "ChiTietDonHangs");

            migrationBuilder.DropTable(
                name: "ChiTietThongSoKyThuats");

            migrationBuilder.DropTable(
                name: "DienThoais");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ThuongHieus");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
