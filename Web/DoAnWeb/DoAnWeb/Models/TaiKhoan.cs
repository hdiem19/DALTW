using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class TaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên đăng nhập là bắt buộc.")]
        [MaxLength(100)]
        public string TenDN { get; set; }
        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        [MaxLength(20)]
        public string MatKhau { get; set; }
        [Required(ErrorMessage = "Họ tên là bắt buộc.")]
        [MaxLength(100)]
        public string HoTen { get; set; }
        [Required(ErrorMessage = "Email là bắt buộc.")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại phải 10 số.")]
        public string SDT { get; set; }

        [Required(ErrorMessage = "Địa chỉ là bắt buộc.")]
        [MaxLength(100)]
        public string DiaChi { get; set; }
  
        public int IdLoaiTK { get; set; }
        [ForeignKey("IdLoaiTK")]
        public virtual LoaiTaiKhoan LoaiTaiKhoan { get; set; }
        public ICollection<DonHang> DonHangs { get; set; }
        public ICollection<DanhGia> DanhGias { get; set; }
    }
}
