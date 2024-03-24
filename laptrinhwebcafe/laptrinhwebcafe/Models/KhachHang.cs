using System.ComponentModel.DataAnnotations;

namespace laptrinhwebcafe.Models
{
    public class KhachHang
    {
        [Key]
        public int MaKH {  get; set; }
        public int MaTK {  get; set; }
        public string TenTK { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public TaiKhoan TaiKhoans { get; set; }
    }
}
