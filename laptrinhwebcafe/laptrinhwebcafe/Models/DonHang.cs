using System.ComponentModel.DataAnnotations;

namespace laptrinhwebcafe.Models
{
    public class DonHang
    {
        [Key]
        public int MaDH { get; set; }
        public int MaKM { get; set; }
        public string TrangThai { get; set; }
        public string DiaChiGiao { get; set; }
        public string SDT { get; set; }
        public DateTime TGDat { get; set; }
        public DateTime TGGiao { get; set; }
        public string MoTa { get; set; }
        public string TongTien { get; set; }
        public int MaCTDH { get; set; }
        public KhuyenMai KhuyenMais { get; set; }
        public KhachHang KhachHangs { get; set; }
        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
