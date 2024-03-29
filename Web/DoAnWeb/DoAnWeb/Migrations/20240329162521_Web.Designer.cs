﻿// <auto-generated />
using System;
using DoAnWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoAnWeb.Migrations
{
    [DbContext(typeof(Applicationcs))]
    [Migration("20240329162521_Web")]
    partial class Web
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoAnWeb.Models.CTDonHang", b =>
                {
                    b.Property<int>("IdCTDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCTDH"));

                    b.Property<int>("DonHangsIdDH")
                        .HasColumnType("int");

                    b.Property<int>("GioHangsIdGH")
                        .HasColumnType("int");

                    b.Property<int>("IdDH")
                        .HasColumnType("int");

                    b.Property<int>("IdGH")
                        .HasColumnType("int");

                    b.HasKey("IdCTDH");

                    b.HasIndex("DonHangsIdDH");

                    b.HasIndex("GioHangsIdGH");

                    b.ToTable("CTDonHangs");
                });

            modelBuilder.Entity("DoAnWeb.Models.CTGioHang", b =>
                {
                    b.Property<int>("IdCTGH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCTGH"));

                    b.Property<int>("GioHangsIdGH")
                        .HasColumnType("int");

                    b.Property<int>("IdGH")
                        .HasColumnType("int");

                    b.Property<int>("IdSP")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamsIdSP")
                        .HasColumnType("int");

                    b.HasKey("IdCTGH");

                    b.HasIndex("GioHangsIdGH");

                    b.HasIndex("SanPhamsIdSP");

                    b.ToTable("CTGioHangs");
                });

            modelBuilder.Entity("DoAnWeb.Models.DanhGiaSP", b =>
                {
                    b.Property<int>("IdDG")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDG"));

                    b.Property<string>("BinhLuan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DanhGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("SanPhamIdSP")
                        .HasColumnType("int");

                    b.Property<int>("TaiKhoansId")
                        .HasColumnType("int");

                    b.HasKey("IdDG");

                    b.HasIndex("SanPhamIdSP");

                    b.HasIndex("TaiKhoansId");

                    b.ToTable("DanhGiaSPs");
                });

            modelBuilder.Entity("DoAnWeb.Models.DonHang", b =>
                {
                    b.Property<int>("IdDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDH"));

                    b.Property<string>("DiaChiGiaoHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCTDH")
                        .HasColumnType("int");

                    b.Property<DateTime>("TGLap")
                        .HasColumnType("datetime2");

                    b.Property<string>("TongTien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThaiDon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDH");

                    b.ToTable("DonHangs");
                });

            modelBuilder.Entity("DoAnWeb.Models.GioHang", b =>
                {
                    b.Property<int>("IdGH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGH"));

                    b.Property<int>("IdCTDH")
                        .HasColumnType("int");

                    b.Property<int>("IdCTGH")
                        .HasColumnType("int");

                    b.Property<int?>("TaiKhoanId")
                        .HasColumnType("int");

                    b.Property<string>("ThanhTien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TongTien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGH");

                    b.HasIndex("TaiKhoanId");

                    b.ToTable("GioHangs");
                });

            modelBuilder.Entity("DoAnWeb.Models.KhuyenMai", b =>
                {
                    b.Property<string>("IdKM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("PhanTramGiam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TGBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TGKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaiKhoansId")
                        .HasColumnType("int");

                    b.Property<string>("TenKM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdKM");

                    b.HasIndex("TaiKhoansId");

                    b.ToTable("KhuyenMais");
                });

            modelBuilder.Entity("DoAnWeb.Models.LoaiSP", b =>
                {
                    b.Property<int>("IdLoaiSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLoaiSP"));

                    b.Property<int>("IdSP")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamsIdSP")
                        .HasColumnType("int");

                    b.Property<string>("TenLoaiSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoaiSP");

                    b.HasIndex("SanPhamsIdSP");

                    b.ToTable("LoaiSPs");
                });

            modelBuilder.Entity("DoAnWeb.Models.SanPham", b =>
                {
                    b.Property<int>("IdSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSP"));

                    b.Property<string>("HinhLon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhNho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDG")
                        .HasColumnType("int");

                    b.Property<int>("IdLoaiSP")
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

                    b.HasKey("IdSP");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("DoAnWeb.Models.TaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdDG")
                        .HasColumnType("int");

                    b.Property<int>("IdGH")
                        .HasColumnType("int");

                    b.Property<int>("IdKM")
                        .HasColumnType("int");

                    b.Property<int>("IdTT")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThongTinCaNhansIdTT")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ThongTinCaNhansIdTT");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("DoAnWeb.Models.ThongTinCaNhan", b =>
                {
                    b.Property<int>("IdTT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTT"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdTT");

                    b.ToTable("ThongTinCaNhans");
                });

            modelBuilder.Entity("DoAnWeb.Models.CTDonHang", b =>
                {
                    b.HasOne("DoAnWeb.Models.DonHang", "DonHangs")
                        .WithMany("CTDonHangs")
                        .HasForeignKey("DonHangsIdDH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnWeb.Models.GioHang", "GioHangs")
                        .WithMany("CTDonHangs")
                        .HasForeignKey("GioHangsIdGH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHangs");

                    b.Navigation("GioHangs");
                });

            modelBuilder.Entity("DoAnWeb.Models.CTGioHang", b =>
                {
                    b.HasOne("DoAnWeb.Models.GioHang", "GioHangs")
                        .WithMany("CTGioHangs")
                        .HasForeignKey("GioHangsIdGH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnWeb.Models.SanPham", "SanPhams")
                        .WithMany()
                        .HasForeignKey("SanPhamsIdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHangs");

                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("DoAnWeb.Models.DanhGiaSP", b =>
                {
                    b.HasOne("DoAnWeb.Models.SanPham", null)
                        .WithMany("DanhGiaSPs")
                        .HasForeignKey("SanPhamIdSP");

                    b.HasOne("DoAnWeb.Models.TaiKhoan", "TaiKhoans")
                        .WithMany("DanhGiaSPs")
                        .HasForeignKey("TaiKhoansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("DoAnWeb.Models.GioHang", b =>
                {
                    b.HasOne("DoAnWeb.Models.TaiKhoan", null)
                        .WithMany("GioHangs")
                        .HasForeignKey("TaiKhoanId");
                });

            modelBuilder.Entity("DoAnWeb.Models.KhuyenMai", b =>
                {
                    b.HasOne("DoAnWeb.Models.TaiKhoan", "TaiKhoans")
                        .WithMany("KhuyenMais")
                        .HasForeignKey("TaiKhoansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("DoAnWeb.Models.LoaiSP", b =>
                {
                    b.HasOne("DoAnWeb.Models.SanPham", "SanPhams")
                        .WithMany("LoaiSPs")
                        .HasForeignKey("SanPhamsIdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("DoAnWeb.Models.TaiKhoan", b =>
                {
                    b.HasOne("DoAnWeb.Models.ThongTinCaNhan", "ThongTinCaNhans")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("ThongTinCaNhansIdTT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ThongTinCaNhans");
                });

            modelBuilder.Entity("DoAnWeb.Models.DonHang", b =>
                {
                    b.Navigation("CTDonHangs");
                });

            modelBuilder.Entity("DoAnWeb.Models.GioHang", b =>
                {
                    b.Navigation("CTDonHangs");

                    b.Navigation("CTGioHangs");
                });

            modelBuilder.Entity("DoAnWeb.Models.SanPham", b =>
                {
                    b.Navigation("DanhGiaSPs");

                    b.Navigation("LoaiSPs");
                });

            modelBuilder.Entity("DoAnWeb.Models.TaiKhoan", b =>
                {
                    b.Navigation("DanhGiaSPs");

                    b.Navigation("GioHangs");

                    b.Navigation("KhuyenMais");
                });

            modelBuilder.Entity("DoAnWeb.Models.ThongTinCaNhan", b =>
                {
                    b.Navigation("TaiKhoans");
                });
#pragma warning restore 612, 618
        }
    }
}