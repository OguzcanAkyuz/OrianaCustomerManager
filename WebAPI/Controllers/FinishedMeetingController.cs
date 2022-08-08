using Business.Abstract;
using Business.Abstract.MeetingsService;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinishedMeetingController : ControllerBase
    {
        private readonly IFinishedMeetingService _finishedMeetingService;

        public FinishedMeetingController(IFinishedMeetingService finishedMeetingService)
        {
            _finishedMeetingService = finishedMeetingService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
{
            var result = _finishedMeetingService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
