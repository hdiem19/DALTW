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
        [MaxLength(100)]
        public string TenKM { get; set; }
        [Required]
        public DateTime TGBatDau { get; set; }
        [Required]
        public DateTime TGKetThuc { get; set; }
        [Required(ErrorMessage = "Phần trăm giảm là bắt buộc.")]
        public string PhanTramGiam { get; set; }
        public  ICollection<SanPham> SanPhams { get; set; }
    }
}
