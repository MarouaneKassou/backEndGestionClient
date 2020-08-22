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
    public class GroupesController : ControllerBase
    {
        private readonly GestionClient_dbContext _context = new GestionClient_dbContext();

        public GroupesController()
        {
            
        }

        // GET: api/Groupes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Groupe>>> GetGroupe()
        {
            return await _context.Groupe.ToListAsync();
        }

        // GET: api/Groupes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Groupe>> GetGroupe(int id)
        {
            var groupe = await _context.Groupe.FindAsync(id);

            if (groupe == null)
            {
                return NotFound();
            }

            return groupe;
        }

        // PUT: api/Groupes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupe(int id, Groupe groupe)
        {
            if (id != groupe.Id)
            {
                return BadRequest();
            }

            _context.Entry(groupe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupeExists(id))
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

        // POST: api/Groupes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Groupe>> PostGroupe(Groupe groupe)
        {
            _context.Groupe.Add(groupe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGroupe", new { id = groupe.Id }, groupe);
        }

        // DELETE: api/Groupes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Groupe>> DeleteGroupe(int id)
        {
            var groupe = await _context.Groupe.FindAsync(id);
            if (groupe == null)
            {
                return NotFound();
            }

            _context.Groupe.Remove(groupe);
            await _context.SaveChangesAsync();

            return groupe;
        }

        private bool GroupeExists(int id)
        {
            return _context.Groupe.Any(e => e.Id == id);
        }
    }
}
