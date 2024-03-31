using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class SanPham
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSP { get; set; }
        [ForeignKey("IdKM")]
        public int IdKM { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc.")]
        [MaxLength(100)]
        public string TenSP { get; set; }
        [Required(ErrorMessage = "Hình là bắt buộc.")]
        public string HinhLon { get; set; }
        [Required(ErrorMessage = "Hình là bắt buộc.")]
        public string HinhNho { get; set; }
        [Required(ErrorMessage = "Mô tả là bắt buộc.")]
        public string MoTa { get; set; }
        [Required(ErrorMessage = "Số lượng là bắt buộc.")]
        public string Soluong { get; set; }
        [Required(ErrorMessage = "Giá là bắt buộc.")]
        [Range(1.000, 100000.000, ErrorMessage = "Giá sản phẩm phải nằm trong khoảng từ 1.000 đến 100000.000")]
        public string Gia { get; set; }
        public int IdLoaiSP { get; set; }
        [ForeignKey("IdLoaiSP")]
        public virtual LoaiSP LoaiSP { get; set; }      
        public  ICollection<CTDonHang> CTDonHangs { get; set; }
        public ICollection<DanhGia> DanhGias { get; set; }

    }
}
