using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentRelationController : ControllerBase
    {
        private readonly IInvestmentRelationService _ınvestmentRelationService;

        public InvestmentRelationController(IInvestmentRelationService ınvestmentRelationService)
        {
            _ınvestmentRelationService = ınvestmentRelationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ınvestmentRelationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
