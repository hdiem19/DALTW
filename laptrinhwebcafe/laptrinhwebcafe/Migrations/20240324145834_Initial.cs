using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace laptrinhwebcafe.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhuyenMais",
                columns: table => new
                {
                    MaKM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCTKM = table.Column<int>(type: "int", nullable: false),
                    TenKM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMais", x => x.MaKM);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSPs",
                columns: table => new
                {
                    MaLoaiSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiSP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSPs", x => x.MaLoaiSP);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTKs",
                columns: table => new
                {
                    MaLoaiTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiTK = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTKs", x => x.MaLoaiTK);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhLon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhNho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaCTKM = table.Column<int>(type: "int", nullable: false),
                    DanhGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soluong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLoaiSP = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaCTDH = table.Column<int>(type: "int", nullable: false),
                    LoaiSPsMaLoaiSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_SanPhams_LoaiSPs_LoaiSPsMaLoaiSP",
                        column: x => x.LoaiSPsMaLoaiSP,
                        principalTable: "LoaiSPs",
                        principalColumn: "MaLoaiSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    MaTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayDangKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLoaiTK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiTKsMaLoaiTK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.MaTK);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_LoaiTKs_LoaiTKsMaLoaiTK",
                        column: x => x.LoaiTKsMaLoaiTK,
                        principalTable: "LoaiTKs",
                        principalColumn: "MaLoaiTK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietKMs",
                columns: table => new
                {
                    MaCTKM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKM = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    PhanTramKM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhuyenMaisMaKM = table.Column<int>(type: "int", nullable: false),
                    SanPhamsMaSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietKMs", x => x.MaCTKM);
                    table.ForeignKey(
                        name: "FK_ChiTietKMs_KhuyenMais_KhuyenMaisMaKM",
                        column: x => x.KhuyenMaisMaKM,
                        principalTable: "KhuyenMais",
                        principalColumn: "MaKM",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietKMs_SanPhams_SanPhamsMaSP",
                        column: x => x.SanPhamsMaSP,
                        principalTable: "SanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTK = table.Column<int>(type: "int", nullable: false),
                    TenTK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaiKhoansMaTK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKH);
                    table.ForeignKey(
                        name: "FK_KhachHangs_TaiKhoans_TaiKhoansMaTK",
                        column: x => x.TaiKhoansMaTK,
                        principalTable: "TaiKhoans",
                        principalColumn: "MaTK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    MaDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKM = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiGiao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TGDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TGGiao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongTien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaCTDH = table.Column<int>(type: "int", nullable: false),
                    KhuyenMaisMaKM = table.Column<int>(type: "int", nullable: false),
                    KhachHangsMaKH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.MaDH);
                    table.ForeignKey(
                        name: "FK_DonHangs_KhachHangs_KhachHangsMaKH",
                        column: x => x.KhachHangsMaKH,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHangs_KhuyenMais_KhuyenMaisMaKM",
                        column: x => x.KhuyenMaisMaKM,
                        principalTable: "KhuyenMais",
                        principalColumn: "MaKM",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHangs",
                columns: table => new
                {
                    MaCTDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDH = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonHangsMaDH = table.Column<int>(type: "int", nullable: false),
                    SanPhamsMaSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHangs", x => x.MaCTDH);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHangs_DonHangs_DonHangsMaDH",
                        column: x => x.DonHangsMaDH,
                        principalTable: "DonHangs",
                        principalColumn: "MaDH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHangs_SanPhams_SanPhamsMaSP",
                        column: x => x.SanPhamsMaSP,
                        principalTable: "SanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHangs_DonHangsMaDH",
                table: "ChiTietDonHangs",
                column: "DonHangsMaDH");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHangs_SanPhamsMaSP",
                table: "ChiTietDonHangs",
                column: "SanPhamsMaSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKMs_KhuyenMaisMaKM",
                table: "ChiTietKMs",
                column: "KhuyenMaisMaKM");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKMs_SanPhamsMaSP",
                table: "ChiTietKMs",
                column: "SanPhamsMaSP");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_KhachHangsMaKH",
                table: "DonHangs",
                column: "KhachHangsMaKH");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_KhuyenMaisMaKM",
                table: "DonHangs",
                column: "KhuyenMaisMaKM");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangs_TaiKhoansMaTK",
                table: "KhachHangs",
                column: "TaiKhoansMaTK");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_LoaiSPsMaLoaiSP",
                table: "SanPhams",
                column: "LoaiSPsMaLoaiSP");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_LoaiTKsMaLoaiTK",
                table: "TaiKhoans",
                column: "LoaiTKsMaLoaiTK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonHangs");

            migrationBuilder.DropTable(
                name: "ChiTietKMs");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "KhuyenMais");

            migrationBuilder.DropTable(
                name: "LoaiSPs");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "LoaiTKs");
        }
    }
}
