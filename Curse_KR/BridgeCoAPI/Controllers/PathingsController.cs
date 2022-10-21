using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BridgesCoModels.Context;
using BridgesCoModels.Models;

namespace BridgeCoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PathingsController : ControllerBase
    {
        private readonly BridgesCOContext _context;

        public PathingsController(BridgesCOContext context)
        {
            _context = context;
        }

        // GET: api/Pathings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pathing>>> GetPathing()
        {
            return await _context.Pathing.Include(x=>x.Order_Id).ToListAsync();
        }

        // GET: api/Pathings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pathing>> GetPathing(int id)
        {
            var pathing = await _context.Pathing.FindAsync(id);

            if (pathing == null)
            {
                return NotFound();
            }
            await _context.Entry(pathing).Reference(x => x.Order_Id).LoadAsync();
         
            return pathing;
        }

        // PUT: api/Pathings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPathing(int id, Pathing pathing)
        {
            if (id != pathing.Id_Pathing)
            {
                return BadRequest();
            }

            _context.Entry(pathing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PathingExists(id))
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

        // POST: api/Pathings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pathing>> PostPathing(Pathing pathing)
        {
            _context.Pathing.Add(pathing);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PathingExists(pathing.Id_Pathing))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPathing", new { id = pathing.Id_Pathing }, pathing);
        }

        // DELETE: api/Pathings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePathing(int id)
        {
            var pathing = await _context.Pathing.FindAsync(id);
            if (pathing == null)
            {
                return NotFound();
            }

            _context.Pathing.Remove(pathing);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PathingExists(int id)
        {
            return _context.Pathing.Any(e => e.Id_Pathing == id);
        }
    }
}
