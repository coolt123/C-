using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamKimThe0000466.Migrations
{
    /// <inheritdoc />
    public partial class DbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoanhNghieps",
                columns: table => new
                {
                    DoanhNghiepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDoanhNghiep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaSoThue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoanhNghieps", x => x.DoanhNghiepId);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    SanPhamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.SanPhamId);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamDoanhNghieps",
                columns: table => new
                {
                    DoanhNghiepId = table.Column<int>(type: "int", nullable: false),
                    SanPhamId = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamDoanhNghieps", x => new { x.DoanhNghiepId, x.SanPhamId });
                    table.ForeignKey(
                        name: "FK_SanPhamDoanhNghieps_DoanhNghieps_DoanhNghiepId",
                        column: x => x.DoanhNghiepId,
                        principalTable: "DoanhNghieps",
                        principalColumn: "DoanhNghiepId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamDoanhNghieps_SanPhams_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPhams",
                        principalColumn: "SanPhamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoanhNghieps_MaSoThue",
                table: "DoanhNghieps",
                column: "MaSoThue",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamDoanhNghieps_SanPhamId",
                table: "SanPhamDoanhNghieps",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_MaSanPham",
                table: "SanPhams",
                column: "MaSanPham",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPhamDoanhNghieps");

            migrationBuilder.DropTable(
                name: "DoanhNghieps");

            migrationBuilder.DropTable(
                name: "SanPhams");
        }
    }
}
