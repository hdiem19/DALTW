using System.ComponentModel.DataAnnotations;

namespace laptrinhwebcafe.Models
{
    public class KhuyenMai
    {
        [Key]
        public int MaKM { get; set; }
        public int MaCTKM { get; set; }
        public string TenKM { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public ICollection<ChiTietKM> ChiTietKMs { get; set; }
    }
}
