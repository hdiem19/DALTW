using System.ComponentModel.DataAnnotations;

namespace laptrinhwebcafe.Models
{
    public class LoaiSP
    {
        [Key]
        public int MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }

        
    }
}
