using System.ComponentModel.DataAnnotations;

namespace PhamKimThe0000466.Dtos
{
    public class DoanhNghiepDto0000466De1
    {
        public int DoanhNghiepId { get; set; }
        private string _name;
        [Required(AllowEmptyStrings = false, ErrorMessage = "ten doanh nghiep khong duoc bo trong")]
        [MaxLength(128, ErrorMessage = "ten khong duoc qua 128 ki tu ")]
        public string TenDoanhNghiep { get=>_name; set=>_name=value?.Trim(); }
        private string _maso;
        [Required(AllowEmptyStrings = false, ErrorMessage = "ma so thue khong duoc bo trong")]
        [MaxLength(128, ErrorMessage = "ten khong duoc qua 128 ki tu ")]

        public string MaSoThue { get=>_maso; set=>_maso=value?.Trim(); }
        private string _diachi;
        [Required(AllowEmptyStrings = false, ErrorMessage = "dia chi khong duoc bo trong")]
        [MaxLength(128, ErrorMessage = "ten khong duoc qua 128 ki tu ")]
        public string DiaChi { get=>_diachi; set=>_diachi=value?.Trim(); }
    }
}
