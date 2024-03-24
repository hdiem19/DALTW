using System.ComponentModel.DataAnnotations;

namespace laptrinhwebcafe.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int MaCTDH {  get; set; }
        public int MaDH {  get; set; }
        public int MaSP {  get; set; }
        public string SoLuong { get; set; }
        public DonHang DonHangs { get; set; }
        public SanPham SanPhams { get; set; }
     
    }
}
