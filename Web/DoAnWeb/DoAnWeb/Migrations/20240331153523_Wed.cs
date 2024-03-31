using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnWeb.Migrations
{
    /// <inheritdoc />
    public partial class Wed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhuyenMais",
                columns: table => new
                {
                    IdKM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TGBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TGKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhanTramGiam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMais", x => x.IdKM);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSPs",
                columns: table => new
                {
                    IdLoaiSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSPs", x => x.IdLoaiSP);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTaiKhoans",
                columns: table => new
                {
                    IdLoaiTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiTK = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTaiKhoans", x => x.IdLoaiTK);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    IdSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKM = table.Column<int>(type: "int", nullable: false),
                    KhuyenMaiIdKM = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TenSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HinhLon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhNho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soluong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdLoaiSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.IdSP);
                    table.ForeignKey(
                        name: "FK_SanPhams_KhuyenMais_KhuyenMaiIdKM",
                        column: x => x.KhuyenMaiIdKM,
                        principalTable: "KhuyenMais",
                        principalColumn: "IdKM");
                    table.ForeignKey(
                        name: "FK_SanPhams_LoaiSPs_IdLoaiSP",
                        column: x => x.IdLoaiSP,
                        principalTable: "LoaiSPs",
                        principalColumn: "IdLoaiSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdLoaiTK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_LoaiTaiKhoans_IdLoaiTK",
                        column: x => x.IdLoaiTK,
                        principalTable: "LoaiTaiKhoans",
                        principalColumn: "IdLoaiTK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGias",
                columns: table => new
                {
                    IdDG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinhLuan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGias", x => x.IdDG);
                    table.ForeignKey(
                        name: "FK_DanhGias_SanPhams_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPhams",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhGias_TaiKhoans_Id",
                        column: x => x.Id,
                        principalTable: "TaiKhoans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    IdDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TGLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TGGiao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThanhTien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiGiaoHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThaiDon = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.IdDH);
                    table.ForeignKey(
                        name: "FK_DonHangs_TaiKhoans_Id",
                        column: x => x.Id,
                        principalTable: "TaiKhoans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTDonHangs",
                columns: table => new
                {
                    IdCTDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDH = table.Column<int>(type: "int", nullable: false),
                    IdSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTDonHangs", x => x.IdCTDH);
                    table.ForeignKey(
                        name: "FK_CTDonHangs_DonHangs_IdDH",
                        column: x => x.IdDH,
                        principalTable: "DonHangs",
                        principalColumn: "IdDH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTDonHangs_SanPhams_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPhams",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTDonHangs_IdDH",
                table: "CTDonHangs",
                column: "IdDH");

            migrationBuilder.CreateIndex(
                name: "IX_CTDonHangs_IdSP",
                table: "CTDonHangs",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGias_Id",
                table: "DanhGias",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGias_IdSP",
                table: "DanhGias",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_Id",
                table: "DonHangs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_IdLoaiSP",
                table: "SanPhams",
                column: "IdLoaiSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_KhuyenMaiIdKM",
                table: "SanPhams",
                column: "KhuyenMaiIdKM");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_IdLoaiTK",
                table: "TaiKhoans",
                column: "IdLoaiTK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTDonHangs");

            migrationBuilder.DropTable(
                name: "DanhGias");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "KhuyenMais");

            migrationBuilder.DropTable(
                name: "LoaiSPs");

            migrationBuilder.DropTable(
                name: "LoaiTaiKhoans");
        }
    }
}
