using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnWeb.Migrations
{
    /// <inheritdoc />
    public partial class Web : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    IdDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TGLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiGiaoHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThaiDon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCTDH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.IdDH);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    IdSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhLon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhNho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soluong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDG = table.Column<int>(type: "int", nullable: false),
                    IdLoaiSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.IdSP);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinCaNhans",
                columns: table => new
                {
                    IdTT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinCaNhans", x => x.IdTT);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSPs",
                columns: table => new
                {
                    IdLoaiSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSP = table.Column<int>(type: "int", nullable: false),
                    SanPhamsIdSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSPs", x => x.IdLoaiSP);
                    table.ForeignKey(
                        name: "FK_LoaiSPs_SanPhams_SanPhamsIdSP",
                        column: x => x.SanPhamsIdSP,
                        principalTable: "SanPhams",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDG = table.Column<int>(type: "int", nullable: false),
                    IdGH = table.Column<int>(type: "int", nullable: false),
                    IdTT = table.Column<int>(type: "int", nullable: false),
                    IdKM = table.Column<int>(type: "int", nullable: false),
                    ThongTinCaNhansIdTT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_ThongTinCaNhans_ThongTinCaNhansIdTT",
                        column: x => x.ThongTinCaNhansIdTT,
                        principalTable: "ThongTinCaNhans",
                        principalColumn: "IdTT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGiaSPs",
                columns: table => new
                {
                    IdDG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DanhGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BinhLuan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    TaiKhoansId = table.Column<int>(type: "int", nullable: false),
                    SanPhamIdSP = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGiaSPs", x => x.IdDG);
                    table.ForeignKey(
                        name: "FK_DanhGiaSPs_SanPhams_SanPhamIdSP",
                        column: x => x.SanPhamIdSP,
                        principalTable: "SanPhams",
                        principalColumn: "IdSP");
                    table.ForeignKey(
                        name: "FK_DanhGiaSPs_TaiKhoans_TaiKhoansId",
                        column: x => x.TaiKhoansId,
                        principalTable: "TaiKhoans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    IdGH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThanhTien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongTien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCTDH = table.Column<int>(type: "int", nullable: false),
                    IdCTGH = table.Column<int>(type: "int", nullable: false),
                    TaiKhoanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.IdGH);
                    table.ForeignKey(
                        name: "FK_GioHangs_TaiKhoans_TaiKhoanId",
                        column: x => x.TaiKhoanId,
                        principalTable: "TaiKhoans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMais",
                columns: table => new
                {
                    IdKM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TGKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhanTramGiam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    TaiKhoansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMais", x => x.IdKM);
                    table.ForeignKey(
                        name: "FK_KhuyenMais_TaiKhoans_TaiKhoansId",
                        column: x => x.TaiKhoansId,
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
                    IdGH = table.Column<int>(type: "int", nullable: false),
                    DonHangsIdDH = table.Column<int>(type: "int", nullable: false),
                    GioHangsIdGH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTDonHangs", x => x.IdCTDH);
                    table.ForeignKey(
                        name: "FK_CTDonHangs_DonHangs_DonHangsIdDH",
                        column: x => x.DonHangsIdDH,
                        principalTable: "DonHangs",
                        principalColumn: "IdDH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTDonHangs_GioHangs_GioHangsIdGH",
                        column: x => x.GioHangsIdGH,
                        principalTable: "GioHangs",
                        principalColumn: "IdGH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTGioHangs",
                columns: table => new
                {
                    IdCTGH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGH = table.Column<int>(type: "int", nullable: false),
                    IdSP = table.Column<int>(type: "int", nullable: false),
                    GioHangsIdGH = table.Column<int>(type: "int", nullable: false),
                    SanPhamsIdSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTGioHangs", x => x.IdCTGH);
                    table.ForeignKey(
                        name: "FK_CTGioHangs_GioHangs_GioHangsIdGH",
                        column: x => x.GioHangsIdGH,
                        principalTable: "GioHangs",
                        principalColumn: "IdGH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTGioHangs_SanPhams_SanPhamsIdSP",
                        column: x => x.SanPhamsIdSP,
                        principalTable: "SanPhams",
                        principalColumn: "IdSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTDonHangs_DonHangsIdDH",
                table: "CTDonHangs",
                column: "DonHangsIdDH");

            migrationBuilder.CreateIndex(
                name: "IX_CTDonHangs_GioHangsIdGH",
                table: "CTDonHangs",
                column: "GioHangsIdGH");

            migrationBuilder.CreateIndex(
                name: "IX_CTGioHangs_GioHangsIdGH",
                table: "CTGioHangs",
                column: "GioHangsIdGH");

            migrationBuilder.CreateIndex(
                name: "IX_CTGioHangs_SanPhamsIdSP",
                table: "CTGioHangs",
                column: "SanPhamsIdSP");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaSPs_SanPhamIdSP",
                table: "DanhGiaSPs",
                column: "SanPhamIdSP");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaSPs_TaiKhoansId",
                table: "DanhGiaSPs",
                column: "TaiKhoansId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_TaiKhoanId",
                table: "GioHangs",
                column: "TaiKhoanId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuyenMais_TaiKhoansId",
                table: "KhuyenMais",
                column: "TaiKhoansId");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiSPs_SanPhamsIdSP",
                table: "LoaiSPs",
                column: "SanPhamsIdSP");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_ThongTinCaNhansIdTT",
                table: "TaiKhoans",
                column: "ThongTinCaNhansIdTT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTDonHangs");

            migrationBuilder.DropTable(
                name: "CTGioHangs");

            migrationBuilder.DropTable(
                name: "DanhGiaSPs");

            migrationBuilder.DropTable(
                name: "KhuyenMais");

            migrationBuilder.DropTable(
                name: "LoaiSPs");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "ThongTinCaNhans");
        }
    }
}
