using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MightyRest.Models;

namespace MightyRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        private readonly mightygamingContext _context;

        public StationsController(mightygamingContext context)
        {
            _context = context;
        }

        // GET: api/Stations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Station>>> GetStation()
        {
            return await _context.Station
                .Include(station => station.StationsBookings)
                    .ThenInclude(sb => sb.BookingIdbookingNavigation)
                .Include(station => station.StationsEquipment)
                    .ThenInclude(se => se.EquipmentSerialnumberNavigation)
                .ToListAsync();
        }

        // GET: api/Stations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Station>> GetStation(int id)
        {
            var station = await _context.Station.FindAsync(id);

            if (station == null)
            {
                return NotFound();
            }

            return station;
        }

        // PUT: api/Stations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStation(int id, Station station)
        {
            if (id != station.Stationnumber)
            {
                return BadRequest();
            }

            _context.Entry(station).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Stations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Station>> PostStation(Station station)
        {
            _context.Station.Add(station);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StationExists(station.Stationnumber))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStation", new { id = station.Stationnumber }, station);
        }

        // DELETE: api/Stations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Station>> DeleteStation(int id)
        {
            var station = await _context.Station.FindAsync(id);
            if (station == null)
            {
                return NotFound();
            }

            _context.Station.Remove(station);
            await _context.SaveChangesAsync();

            return station;
        }

        private bool StationExists(int id)
        {
            return _context.Station.Any(e => e.Stationnumber == id);
        }
    }
}
