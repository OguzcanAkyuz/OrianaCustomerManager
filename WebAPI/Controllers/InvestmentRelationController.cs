using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentRelationController : ControllerBase
    {
        private readonly IInvestmentRelationService _investmentRelationService;

        public InvestmentRelationController(IInvestmentRelationService investmentRelationService)
        {
            _investmentRelationService = investmentRelationService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(string investmentRelationId)
        {
            var result = _investmentRelationService.GetByInvestmentRelationId(investmentRelationId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _investmentRelationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(InvestmentRelation investmentRelation)
        {
            var result = _investmentRelationService.Add(investmentRelation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult Delete(string investmentRelationId)
        {
            var result = _investmentRelationService.Delete(investmentRelationId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(InvestmentRelation investmentRelation)
        {
            var result = _investmentRelationService.Update(investmentRelation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
