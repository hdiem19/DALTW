using System.ComponentModel.DataAnnotations;

namespace laptrinhwebcafe.Models
{
    public class LoaiTK
    {
        [Key]
        public int MaLoaiTK { get; set; }
        public string TenLoaiTK { get; set; }
    }
}
