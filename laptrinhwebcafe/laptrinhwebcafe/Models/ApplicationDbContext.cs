using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace laptrinhwebcafe.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<ChiTietKM> ChiTietKMs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiTK> LoaiTKs { get; set;}
        public DbSet<TaiKhoan> TaiKhoans { get;set; }

    }
}
