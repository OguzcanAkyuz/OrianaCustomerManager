using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotentialCustomerController : ControllerBase
    {
        private readonly IPotentialCustomerService _potentialCustomerService;

        public PotentialCustomerController(IPotentialCustomerService potentialCustomerService)
        {
            _potentialCustomerService = potentialCustomerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _potentialCustomerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
