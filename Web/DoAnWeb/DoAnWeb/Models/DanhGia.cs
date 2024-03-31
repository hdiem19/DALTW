using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class DanhGia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDG { get; set; }
        public string BinhLuan { get; set; }
        public string HinhAnh { get; set; }
        public int Id {  get; set; }
        [ForeignKey("Id")]
        public virtual TaiKhoan TaiKhoan { get; set; }
        public int IdSP { get; set; }
        [ForeignKey("IdSP")]
        public virtual SanPham SanPham { get; set; }
    }
}
