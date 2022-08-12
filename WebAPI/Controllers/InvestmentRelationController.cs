using Business.Abstract;
using Entities.Concrete;
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

        [HttpGet("getbyid")]
        public IActionResult GetById(string ınvestmentRelationıd)
        {
            var result = _ınvestmentRelationService.GetByInvestmentRelationId(ınvestmentRelationıd);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
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
        [HttpPost("Add")]
        public IActionResult Add(InvestmentRelation ınvestmentRelation)
        {
            var result = _ınvestmentRelationService.Add(ınvestmentRelation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(InvestmentRelation ınvestmentRelation)
        {
            var result = _ınvestmentRelationService.Delete(ınvestmentRelation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
