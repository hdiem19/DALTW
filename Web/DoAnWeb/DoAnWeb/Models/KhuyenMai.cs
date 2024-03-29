using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class KhuyenMai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdKM { get; set; }
        [Required(ErrorMessage = "Tên khuyến mãi là bắt buộc.")]
        public string TenKM { get; set; }
        public DateTime TGBatDau { get; set; }
        public DateTime TGKetThuc { get; set; }
        [Required(ErrorMessage = "Phần trăm giảm là bắt buộc.")]
        public string PhanTramGiam { get; set; }
        public int Id {  get; set; }
        public TaiKhoan TaiKhoans { get; set; }
    }
}
