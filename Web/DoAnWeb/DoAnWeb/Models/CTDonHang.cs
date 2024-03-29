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
        public int IdGH { get; set; }
        public DonHang DonHangs { get; set; }
        public GioHang GioHangs { get; set; }
    }
}
