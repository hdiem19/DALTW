using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class ThongTinCaNhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTT { get; set; }
        [Required(ErrorMessage = "Email là bắt buộc.")]
        public string HoTen { get; set; }
        [Required(ErrorMessage = "Email là bắt buộc.")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại phải 10 số.")]
        public string SDT { get; set; }

        [Required(ErrorMessage = "Địa chỉ là bắt buộc.")]
        public string DiaChi { get; set; }
        public int Id {  get; set; }
        public List<TaiKhoan> TaiKhoans { get; set; }
    }
}
