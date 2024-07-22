using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhamKimThe0000466.Entities
{
    public class SanPham0000466De1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SanPhamId { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenSanPham { get; set; }
        [Required]
        [MaxLength(50)]
        public string MaSanPham { get; set; }
        public DateTime NgayNhap { get; set; }

        public ICollection<SanPhamDoanhNghiep0000466De1> SanPhamDoanhNghieps { get; set; }
    }
}
