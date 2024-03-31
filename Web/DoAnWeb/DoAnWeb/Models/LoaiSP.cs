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
        [MaxLength(100)]
        public string TenLoaiSP { get; set; }
        public  ICollection<SanPham> SanPhams { get; set; }
    }
}
