using Business.Abstract;
using Entities.Concrete;
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

        [HttpPost("Add")]
        public IActionResult Add(PotentialCustomer potentialCustomer)
        {
            var result = _potentialCustomerService.Add(potentialCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(string potentialCustomerId)
        {
            var result = _potentialCustomerService.GetByPotentialCustomerId(potentialCustomerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(string potentialCustomerId)
        {
            var result = _potentialCustomerService.Update(potentialCustomerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
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
        [HttpPost("delete")]
        public IActionResult Delete(string potentialCustomerId)
        {
            var result = _potentialCustomerService.Delete(potentialCustomerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
