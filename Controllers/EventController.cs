using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EventApi.Models;

namespace EventApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EventContext _context;
        public EventController(EventContext context)
        {
            _context = context;
            if (_context.Events.Count() == 0)
            {
                _context.Events.Add(new Event { Name = "Item1" }); _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Event>> GetAll()
        {
            return _context.Events.ToList();
        }
    }
}