using Business.Abstract;
using Business.Abstract.MeetingsService;
using Entities.Concrete;
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


        [HttpPost("Add")]
        public IActionResult Add(ScheduledMeeting scheduledMeeting)
        {
            var result = _scheduledMeetingService.Add(scheduledMeeting);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
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
        public IActionResult Update(string scheduledMeetingId)
        {
            var result = _scheduledMeetingService.Update(scheduledMeetingId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(string scheduledMeetingId)
        {
            var result = _scheduledMeetingService.Delete(scheduledMeetingId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
        [HttpGet("getbyid")]
        public IActionResult GetById(string scheduledMeetingId)
        {
            var result = _scheduledMeetingService.GetByScheduledMeetingId(scheduledMeetingId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
