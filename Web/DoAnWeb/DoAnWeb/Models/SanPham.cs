using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class SanPham
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSP { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc.")]
        public string TenSP { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc.")]
        public string HinhLon { get; set; }
        [Required(ErrorMessage = "Hình lớn là bắt buộc.")]
        public string HinhNho { get; set; }
        [Required(ErrorMessage = "Hình nhỏ là bắt buộc.")]
        public string MoTa { get; set; }
        [Required(ErrorMessage = "Số lượng là bắt buộc.")]
        public string Soluong { get; set; }
        [Required(ErrorMessage = "Giá là bắt buộc.")]
        public int IdDG { get; set; }
        public int IdLoaiSP { get; set; }
        public List<DanhGiaSP> DanhGiaSPs { get; set; }
        public List<LoaiSP> LoaiSPs { get; set; }
    }
}
