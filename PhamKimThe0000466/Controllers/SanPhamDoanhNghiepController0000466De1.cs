using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhamKimThe0000466.Services.Interfaces;

namespace PhamKimThe0000466.Controllers
{
    [Route("api/SanPhamDoanhNghiep")]
    [ApiController]
    public class SanPhamDoanhNghiepController0000466De1 : ControllerBase
    {
        private readonly ISanPhamDoanhNghiepService0000466De1 _service;
        public SanPhamDoanhNghiepController0000466De1(ISanPhamDoanhNghiepService0000466De1 service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get(int doanhNghiepId)
        {
            return Ok(_service.GetSpOfDoanhNghiep(doanhNghiepId));
        }
    }
}
