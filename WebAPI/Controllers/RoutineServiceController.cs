using Business.Abstract;
using Business.Abstract.MeetingsService;
using Entities.Concrete;
using Entities.Concrete.Meetings;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutineServiceController : ControllerBase
    {
        private readonly IRoutineServiceService _routineServiceService;


        public RoutineServiceController(IRoutineServiceService routineServiceService)
        {
            _routineServiceService = routineServiceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _routineServiceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(RoutineService routineService)
        {
            var result = _routineServiceService.Update(routineService);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
