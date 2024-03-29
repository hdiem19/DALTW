using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class DanhGiaSP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDG { get; set; }
        [Required(ErrorMessage = "Dánh giá là bắt buộc.")]
        public string DanhGia { get; set; }
        public string BinhLuan { get; set; }
        public string HinhAnh { get; set; }
        public int Id {  get; set; }
        public TaiKhoan TaiKhoans { get; set; }
    }
}
