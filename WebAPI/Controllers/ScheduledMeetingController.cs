using Business.Abstract;
using Business.Abstract.MeetingsService;
using Entities.Concrete.Meetings;
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
        [HttpPost("update")]
        public IActionResult Update(ScheduledMeeting scheduledMeeting)
        {
            var result = _scheduledMeetingService.Update(scheduledMeeting);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
