
using DoAnWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace DoAnWeb.Models
{
    public class Applicationcs : DbContext
    {
        public Applicationcs(DbContextOptions<Applicationcs> options) : base(options)
        {
        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }

        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<CTDonHang> CTDonHangs { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        public DbSet<ThongTinCaNhan> ThongTinCaNhans { get; set; }
        public DbSet<CTGioHang> CTGioHangs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<DanhGiaSP> DanhGiaSPs { get; set; }
    }
}
