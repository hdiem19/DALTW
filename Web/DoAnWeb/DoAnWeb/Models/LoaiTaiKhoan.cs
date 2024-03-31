using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class LoaiTaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLoaiTK {  get; set; }
        [Required(ErrorMessage = "Tên loại tài khoản là bắt buộc.")]
        [MaxLength(100)]
        public string LoaiTK { get; set;}
        public  ICollection<TaiKhoan> TaiKhoans { get; set;}
    }
}
