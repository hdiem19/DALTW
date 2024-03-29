using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class DonHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDH { get; set; }
        public DateTime TGLap { get; set; }
        public string TongTien { get; set; }
        [Required(ErrorMessage = "Địa chỉ giao hàng là bắt buộc.")]
        public string DiaChiGiaoHang { get; set; }
        public string TrangThaiDon { get; set; }
        public int IdCTDH { get; set; }
        public List<CTDonHang> CTDonHangs { get; set; }
    }
}
