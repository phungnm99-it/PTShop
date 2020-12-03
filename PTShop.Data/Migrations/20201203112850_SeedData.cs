using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTShop.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Id", "Gia", "GiaGoc", "HinhAnh", "Name", "NgayRaMat", "SoLuong", "ThuongHieuId" },
                values: new object[,]
                {
                    { 1, 5000000f, 4000000f, "https://cdn.tgdd.vn/Products/Images/42/227731/realme-7-043120-113149-400x460.png", "Xiaomi Note 9", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 5000000f, 4000000f, "https://cdn.tgdd.vn/Products/Images/42/227731/realme-7-043120-113149-400x460.png", "Xiaomi Note 10", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 3, 5000000f, 4000000f, "https://cdn.tgdd.vn/Products/Images/42/227731/realme-7-043120-113149-400x460.png", "Xiaomi Note 11", new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ThuongHieus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Xiaomi" },
                    { 2, "Samsung" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "DienThoais",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DienThoais",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DienThoais",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ThuongHieus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ThuongHieus",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
