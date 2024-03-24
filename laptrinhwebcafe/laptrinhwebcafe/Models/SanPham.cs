using System.ComponentModel.DataAnnotations;

namespace laptrinhwebcafe.Models
{
    public class SanPham
    {
        [Key]
        public int MaSP {  get; set; }
        public string TenSP { get; set; }
        public string HinhLon { get; set; }
        public string HinhNho { get; set; }
        public string MoTa { get; set; }
        public int MaCTKM { get; set; }
        public string DanhGia { get; set; }
        public string Soluong { get; set; }
        public int MaLoaiSP { get; set; }
        public string DonGia {  get; set; }
        public int MaCTDH { get; set; }
        public LoaiSP LoaiSPs { get; set; }
        public ICollection<ChiTietKM> ChiTietKMs { get; set; }
        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
