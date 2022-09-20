using Business.Abstract;
using Entities.Concrete;
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
        [HttpPost("Add")]
        public IActionResult Add(AbroadInvestmentRelation abroadInvestmentRelation)
        {
            var result = _abroadInvestmentRelationService.Add(abroadInvestmentRelation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(string abroadInvestmentId)
        {
            var result = _abroadInvestmentRelationService.GetByAbroadInvestmentRelationsId(abroadInvestmentId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(string abroadInvestmentRelationId)
        {
            var result = _abroadInvestmentRelationService.Update(abroadInvestmentRelationId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(string abroadInvestmentRelationId)
        {
            var result = _abroadInvestmentRelationService.Delete(abroadInvestmentRelationId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
