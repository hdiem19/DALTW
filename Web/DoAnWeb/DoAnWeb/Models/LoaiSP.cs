using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class LoaiSP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLoaiSP { get; set; }

        [Required(ErrorMessage = "Tên loại sản phẩm là trường bắt buộc.")]
        public string TenLoaiSP { get; set; }
        public int IdSP { get; set; }
        public SanPham SanPhams { get; set; }
    }
}
