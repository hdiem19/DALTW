using System.ComponentModel.DataAnnotations;

namespace laptrinhwebcafe.Models
{
    public class ChiTietKM
    {
        [Key]
        public int MaCTKM { get; set; }
        public int MaKM { get; set; }
        public int MaSP { get; set; }
        public string PhanTramKM { get; set; }
        public KhuyenMai KhuyenMais { get; set; }
        public SanPham SanPhams { get; set; }
    }
}
