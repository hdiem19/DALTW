using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models
{
    public class CTGioHang
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCTGH { get; set; }
        public int IdGH { get; set; }
        public int IdSP { get; set; }
        public GioHang GioHangs { get; set; }
        public SanPham SanPhams { get; set; }
    }
}
