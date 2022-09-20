using Business.Abstract;
using Business.Abstract.MeetingsService;
using Entities.Concrete;
using Entities.Concrete.Meetings;
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

        [HttpPost("Add")]
        public IActionResult Add(FinishedMeeting finishedMeeting)
        {
            var result = _finishedMeetingService.Add(finishedMeeting);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(string finishedMeetingId)
        {
            var result = _finishedMeetingService.GetByFinishedMeetingId(finishedMeetingId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(string finishedMeetingId)
        {
            var result = _finishedMeetingService.Delete(finishedMeetingId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(string finishedMeetingId)
        {
            var result = _finishedMeetingService.Update(finishedMeetingId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
    }
