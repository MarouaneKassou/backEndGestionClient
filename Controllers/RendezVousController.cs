using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionClientsCore.Models;

namespace GestionClientsCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RendezVousController : ControllerBase
    {
        private readonly GestionClient_dbContext _context = new GestionClient_dbContext();

        public RendezVousController()
        {
          
        }

        // GET: api/RendezVous
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RendezVous>>> GetRendezVous()
        {
            return await _context.RendezVous.ToListAsync();
        }

        // GET: api/RendezVous/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RendezVous>> GetRendezVous(int id)
        {
            var rendezVous = await _context.RendezVous.FindAsync(id);

            if (rendezVous == null)
            {
                return NotFound();
            }

            return rendezVous;
        }

        // PUT: api/RendezVous/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRendezVous(int id, RendezVous rendezVous)
        {
            if (id != rendezVous.Id)
            {
                return BadRequest();
            }

            _context.Entry(rendezVous).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RendezVousExists(id))
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

        // POST: api/RendezVous
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RendezVous>> PostRendezVous(RendezVous rendezVous)
        {
            _context.RendezVous.Add(rendezVous);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRendezVous", new { id = rendezVous.Id }, rendezVous);
        }

        // DELETE: api/RendezVous/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RendezVous>> DeleteRendezVous(int id)
        {
            var rendezVous = await _context.RendezVous.FindAsync(id);
            if (rendezVous == null)
            {
                return NotFound();
            }

            _context.RendezVous.Remove(rendezVous);
            await _context.SaveChangesAsync();

            return rendezVous;
        }

        private bool RendezVousExists(int id)
        {
            return _context.RendezVous.Any(e => e.Id == id);
        }
    }
}
