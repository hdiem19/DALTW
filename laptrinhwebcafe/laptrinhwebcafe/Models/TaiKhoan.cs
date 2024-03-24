using System.ComponentModel.DataAnnotations;

namespace laptrinhwebcafe.Models
{
    public class TaiKhoan
    {
        [Key]
        public int MaTK {  get; set; }
        public string TenDN {  get; set; }
        public string MatKhau { get; set; }
        public string NgayDangKy { get; set; }
        public string TrangThai {  get; set; }
        public string MaLoaiTK { get; set; }
        public LoaiTK LoaiTKs { get; set; }
    }
}
