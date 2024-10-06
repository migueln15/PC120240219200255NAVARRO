using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC120240219200255NAVARRO.DOMAIN.Core.Entities;
using PC120240219200255NAVARRO.DOMAIN.Core.Interfaces;
using PC120240219200255NAVARRO.DOMAIN.Infrastructure.Data;

namespace PC120240219200255NAVARRO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendesController : ControllerBase
    {
        private readonly IAttendeesRepository _attendeesRepository;

        public AttendesController(IAttendeesRepository attendeesRepository)
        {
            _attendeesRepository = attendeesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attendees>>> GetAttendees()
        {
            var Attendees = await _attendeesRepository.GetAttendees();
            return Ok(Attendees);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAttende(Attendees attende)
        {
            var result = await _attendeesRepository.CreateAttende(attende);
            return Ok(result);

        }
    }
}
