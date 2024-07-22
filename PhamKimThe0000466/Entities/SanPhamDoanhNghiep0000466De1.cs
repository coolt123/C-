using System.ComponentModel.DataAnnotations;

namespace PhamKimThe0000466.Entities
{
    public class SanPhamDoanhNghiep0000466De1
    {
        public int DoanhNghiepId { get; set; }
        public DoanhNghiep0000466De1 DoanhNghiep { get; set; }
        public int SanPhamId { get; set; }
        public SanPham0000466De1 SanPham { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int SoLuong { get; set; }
    }
}
