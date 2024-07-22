using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhamKimThe0000466.Dtos;
using PhamKimThe0000466.Services.Interfaces;

namespace PhamKimThe0000466.Controllers
{
    [Route("api/DoanhNghiep")]
    [ApiController]
    public class DoanhNghiepController0000466De1 : ControllerBase
    {
        private readonly IDoanhNghiepService0000466De1 _service;
        public DoanhNghiepController0000466De1(IDoanhNghiepService0000466De1 service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] FilterDto0000466De1 input)
        {
            try
            {
                return Ok(_service.GetAll(input));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPost]
        public IActionResult Add(DoanhNghiepDto0000466De1 input)
        {
            try
            {
                _service.Add(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, DoanhNghiepDto0000466De1 input)
        {
            try
            {
                _service.Update(id, input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }

}
   

