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
        public string TenDN { get; set; }
        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        public string MatKhau { get; set; }
        public int IdDG { get; set; }
        public int IdGH { get; set; }
        public int IdTT { get; set; }
        public int IdKM { get; set; }
        public List<GioHang> GioHangs { get; set; }
        public List<DanhGiaSP> DanhGiaSPs { get; set; }
        public List<KhuyenMai> KhuyenMais { get; set; }
        public ThongTinCaNhan ThongTinCaNhans { get; set; }
    }
}
