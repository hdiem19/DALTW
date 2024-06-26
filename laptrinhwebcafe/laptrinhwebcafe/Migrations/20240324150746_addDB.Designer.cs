﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using laptrinhwebcafe.Models;

#nullable disable

namespace laptrinhwebcafe.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240324150746_addDB")]
    partial class addDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("laptrinhwebcafe.Models.ChiTietDonHang", b =>
                {
                    b.Property<int>("MaCTDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCTDH"));

                    b.Property<int>("DonHangsMaDH")
                        .HasColumnType("int");

                    b.Property<int>("MaDH")
                        .HasColumnType("int");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamsMaSP")
                        .HasColumnType("int");

                    b.Property<string>("SoLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaCTDH");

                    b.HasIndex("DonHangsMaDH");

                    b.HasIndex("SanPhamsMaSP");

                    b.ToTable("ChiTietDonHangs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.ChiTietKM", b =>
                {
                    b.Property<int>("MaCTKM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCTKM"));

                    b.Property<int>("KhuyenMaisMaKM")
                        .HasColumnType("int");

                    b.Property<int>("MaKM")
                        .HasColumnType("int");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<string>("PhanTramKM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SanPhamsMaSP")
                        .HasColumnType("int");

                    b.HasKey("MaCTKM");

                    b.HasIndex("KhuyenMaisMaKM");

                    b.HasIndex("SanPhamsMaSP");

                    b.ToTable("ChiTietKMs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.DonHang", b =>
                {
                    b.Property<int>("MaDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDH"));

                    b.Property<string>("DiaChiGiao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KhachHangsMaKH")
                        .HasColumnType("int");

                    b.Property<int>("KhuyenMaisMaKM")
                        .HasColumnType("int");

                    b.Property<int>("MaCTDH")
                        .HasColumnType("int");

                    b.Property<int>("MaKM")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TGDat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TGGiao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TongTien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDH");

                    b.HasIndex("KhachHangsMaKH");

                    b.HasIndex("KhuyenMaisMaKM");

                    b.ToTable("DonHangs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.KhachHang", b =>
                {
                    b.Property<int>("MaKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKH"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaTK")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaiKhoansMaTK")
                        .HasColumnType("int");

                    b.Property<string>("TenTK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKH");

                    b.HasIndex("TaiKhoansMaTK");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.KhuyenMai", b =>
                {
                    b.Property<int>("MaKM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKM"));

                    b.Property<int>("MaCTKM")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKT")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenKM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKM");

                    b.ToTable("KhuyenMais");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.LoaiSP", b =>
                {
                    b.Property<int>("MaLoaiSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoaiSP"));

                    b.Property<string>("TenLoaiSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiSP");

                    b.ToTable("LoaiSPs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.LoaiTK", b =>
                {
                    b.Property<int>("MaLoaiTK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoaiTK"));

                    b.Property<string>("TenLoaiTK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiTK");

                    b.ToTable("LoaiTKs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.SanPham", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSP"));

                    b.Property<string>("DanhGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhLon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhNho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoaiSPsMaLoaiSP")
                        .HasColumnType("int");

                    b.Property<int>("MaCTDH")
                        .HasColumnType("int");

                    b.Property<int>("MaCTKM")
                        .HasColumnType("int");

                    b.Property<int>("MaLoaiSP")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soluong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP");

                    b.HasIndex("LoaiSPsMaLoaiSP");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.TaiKhoan", b =>
                {
                    b.Property<int>("MaTK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTK"));

                    b.Property<int>("LoaiTKsMaLoaiTK")
                        .HasColumnType("int");

                    b.Property<string>("MaLoaiTK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NgayDangKy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTK");

                    b.HasIndex("LoaiTKsMaLoaiTK");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("laptrinhwebcafe.Models.DonHang", "DonHangs")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("DonHangsMaDH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("laptrinhwebcafe.Models.SanPham", "SanPhams")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("SanPhamsMaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHangs");

                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.ChiTietKM", b =>
                {
                    b.HasOne("laptrinhwebcafe.Models.KhuyenMai", "KhuyenMais")
                        .WithMany("ChiTietKMs")
                        .HasForeignKey("KhuyenMaisMaKM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("laptrinhwebcafe.Models.SanPham", "SanPhams")
                        .WithMany("ChiTietKMs")
                        .HasForeignKey("SanPhamsMaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhuyenMais");

                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.DonHang", b =>
                {
                    b.HasOne("laptrinhwebcafe.Models.KhachHang", "KhachHangs")
                        .WithMany()
                        .HasForeignKey("KhachHangsMaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("laptrinhwebcafe.Models.KhuyenMai", "KhuyenMais")
                        .WithMany()
                        .HasForeignKey("KhuyenMaisMaKM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHangs");

                    b.Navigation("KhuyenMais");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.KhachHang", b =>
                {
                    b.HasOne("laptrinhwebcafe.Models.TaiKhoan", "TaiKhoans")
                        .WithMany()
                        .HasForeignKey("TaiKhoansMaTK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.SanPham", b =>
                {
                    b.HasOne("laptrinhwebcafe.Models.LoaiSP", "LoaiSPs")
                        .WithMany()
                        .HasForeignKey("LoaiSPsMaLoaiSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiSPs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.TaiKhoan", b =>
                {
                    b.HasOne("laptrinhwebcafe.Models.LoaiTK", "LoaiTKs")
                        .WithMany()
                        .HasForeignKey("LoaiTKsMaLoaiTK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiTKs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.DonHang", b =>
                {
                    b.Navigation("ChiTietDonHangs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.KhuyenMai", b =>
                {
                    b.Navigation("ChiTietKMs");
                });

            modelBuilder.Entity("laptrinhwebcafe.Models.SanPham", b =>
                {
                    b.Navigation("ChiTietDonHangs");

                    b.Navigation("ChiTietKMs");
                });
#pragma warning restore 612, 618
        }
    }
}
