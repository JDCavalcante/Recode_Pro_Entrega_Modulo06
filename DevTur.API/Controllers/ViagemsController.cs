using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevTur.API.Models;

namespace DevTur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViagemsController : ControllerBase
    {
        private readonly DEVTURContext _context;

        public ViagemsController(DEVTURContext context)
        {
            _context = context;
        }

        // GET: api/Viagems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Viagem>>> GetViagem()
        {
            return await _context.Viagem.ToListAsync();
        }

        // GET: api/Viagems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Viagem>> GetViagem(long id)
        {
            var viagem = await _context.Viagem.FindAsync(id);

            if (viagem == null)
            {
                return NotFound();
            }

            return viagem;
        }

        // PUT: api/Viagems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViagem(long id, Viagem viagem)
        {
            if (id != viagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(viagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViagemExists(id))
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

        // POST: api/Viagems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Viagem>> PostViagem(Viagem viagem)
        {
            _context.Viagem.Add(viagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetViagem", new { id = viagem.Id }, viagem);
        }

        // DELETE: api/Viagems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteViagem(long id)
        {
            var viagem = await _context.Viagem.FindAsync(id);
            if (viagem == null)
            {
                return NotFound();
            }

            _context.Viagem.Remove(viagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ViagemExists(long id)
        {
            return _context.Viagem.Any(e => e.Id == id);
        }
    }
}
