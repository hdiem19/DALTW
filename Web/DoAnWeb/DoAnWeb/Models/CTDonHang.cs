using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class CTDonHang
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCTDH { get; set; }
      
        public int IdDH { get; set; }
        [ForeignKey("IdDH")]
        public virtual DonHang DonHangs { get; set; }
        public int IdSP { get; set; }
        [ForeignKey("IdSP")]
    
        public virtual SanPham SanPham { get; set; }
    }
}
