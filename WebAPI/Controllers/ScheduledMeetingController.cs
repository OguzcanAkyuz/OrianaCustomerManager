using Business.Abstract;
using Business.Abstract.MeetingsService;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduledMeetingController : ControllerBase
    {
        private readonly IScheduledMeetingService _scheduledMeetingService;


        public ScheduledMeetingController(IScheduledMeetingService scheduledService)
        {
            _scheduledMeetingService = scheduledService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _scheduledMeetingService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
