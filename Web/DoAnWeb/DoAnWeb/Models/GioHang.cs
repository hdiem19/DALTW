using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class GioHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGH { get; set; }
        public string ThanhTien { get; set; }
        public string TongTien { get; set; }
        public int IdCTDH { get; set; }
        public int IdCTGH { get; set; }
        public List<CTDonHang> CTDonHangs { get; set; }
        public List<CTGioHang> CTGioHangs { get; set; }
    }
}
