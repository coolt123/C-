using Microsoft.EntityFrameworkCore;
using PhamKimThe0000466.DbContexts;
using PhamKimThe0000466.Dtos;

namespace PhamKimThe0000466.Services.Implements
{
    
    public class SanPhamDoanhNghiepService0000466De1
    {
        private readonly MyDbContext0000466De1 _dbContext;
        public SanPhamDoanhNghiepService0000466De1(MyDbContext0000466De1 dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<SanPhamDto0000466De1> GetSpOfDoanhNghiep(int doanhNghiepId)
        {
            var spDoanhNghiep = _dbContext.SanPhamDoanhNghieps
                .Where(sp => sp.DoanhNghiepId == doanhNghiepId)
                .Select(sp => new SanPhamDto0000466De1
                {
                    SanPhamId = sp.SanPham.SanPhamId,
                    TenSanPham = sp.SanPham.TenSanPham,
                    MaSanPham = sp.SanPham.MaSanPham,
                    NgayNhap = sp.SanPham.NgayNhap
                }).ToList();
            return spDoanhNghiep;
        }
    }
}
