using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class DonHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDH { get; set; }
        public DateTime TGLap { get; set; }
        public DateTime TGGiao { get; set; }
        public string TongTien { get; set; }
        public string ThanhTien { get; set; }
        [Required(ErrorMessage = "Địa chỉ giao hàng là bắt buộc.")]
        public string DiaChiGiaoHang { get; set; }
        [Required]
        public bool TrangThaiDon { get; set; }
        public int Id {  get; set; }
        [ForeignKey("Id")]
        public virtual TaiKhoan TaiKhoan { get; set; }
        public  ICollection<CTDonHang> CTDonHangs { get; set; }
    }
}
