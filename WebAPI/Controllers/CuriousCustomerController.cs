using Business.Abstract;
using Entities.Concrete;
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
        [HttpGet("getbyid")]
        public IActionResult GetById(string curiousCustomerId)
        {
            var result = _curiousCustomerService.GetByCuriousCustomerId(curiousCustomerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(CuriousCustomer curiousCustomer)
        {
            var result = _curiousCustomerService.Add(curiousCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(string curiousCustomerId)
        {
            var result = _curiousCustomerService.Delete(curiousCustomerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(string curiousCustomerId)
        {
            var result = _curiousCustomerService.Update(curiousCustomerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
    }
