using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbroadInvestmentRelationController : ControllerBase
    {
        private readonly IAbroadInvestmentRelationService _abroadInvestmentRelationService;
        public AbroadInvestmentRelationController(IAbroadInvestmentRelationService abroadInvestmentRelationService)
        {
            _abroadInvestmentRelationService = abroadInvestmentRelationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _abroadInvestmentRelationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
