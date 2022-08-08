using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuriousCustomerController : ControllerBase
    {
        private readonly ICuriousCustomerService _curiousCustomerService;

        public CuriousCustomerController(ICuriousCustomerService curiousCustomerService)
        {
            _curiousCustomerService = curiousCustomerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _curiousCustomerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
