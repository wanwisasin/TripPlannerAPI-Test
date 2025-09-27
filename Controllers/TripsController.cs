using Microsoft.AspNetCore.Mvc;
using TripPlannerAPI.Data;
using TripPlannerAPI.Models;

namespace TripPlannerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TripsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetTrips([FromQuery] string destination, [FromQuery] bool active, [FromQuery] int limit)
        {
            var trips = _context.Trips
                .Where(t => t.destination.Contains(destination) && t.active == active)
                .Take(limit)
                .Select(t => new {
                    t.trip_id,
                    t.trip_name,
                    t.destination,
                    t.start_date,
                    t.end_date,
                    t.active
                })
                .ToList();

            return Ok(trips);
        }

        [HttpPost]
        public IActionResult CreateTrip([FromBody] Trip trip)
        {
            _context.Trips.Add(trip);
            _context.SaveChanges();

            return Ok(new {
                trip.trip_id,
                trip.trip_name,
                trip.destination,
                trip.start_date,
                trip.end_date,
                trip.active
            });
        }
    }
}
