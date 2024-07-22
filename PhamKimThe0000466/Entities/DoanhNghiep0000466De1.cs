using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PhamKimThe0000466.Entities
{
    public class DoanhNghiep0000466De1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoanhNghiepId { get; set; }
        [Required]
        [MaxLength(50)]
        public string TenDoanhNghiep { get; set; }
        [Required]
        [MaxLength(50)]
        public string MaSoThue { get; set; }
        [Required]
        [MaxLength(50)]
        public string DiaChi { get; set; }

        public ICollection<SanPhamDoanhNghiep0000466De1> SanPhamDoanhNghieps { get; set; }
    }
}
