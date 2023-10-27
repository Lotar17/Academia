using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComisionesController : ControllerBase
    {
        private readonly AcademiaDbContext _context;

        public ComisionesController(AcademiaDbContext context)
        {
            _context = context;
        }

        // GET: api/Comisiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comisione>>> GetComisiones()
        {
          if (_context.Comisiones == null)
          {
              return NotFound();
          }
            return await _context.Comisiones.ToListAsync();
        }

        // GET: api/Comisiones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comisione>> GetComisione(int id)
        {
          if (_context.Comisiones == null)
          {
              return NotFound();
          }
            var comisione = await _context.Comisiones.FindAsync(id);

            if (comisione == null)
            {
                return NotFound();
            }

            return comisione;
        }

        // PUT: api/Comisiones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComisione(int id, Comisione comisione)
        {
            if (id != comisione.IdComision)
            {
                return BadRequest();
            }

            _context.Entry(comisione).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComisioneExists(id))
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

        // POST: api/Comisiones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comisione>> PostComisione(Comisione comisione)
        {
          if (_context.Comisiones == null)
          {
              return Problem("Entity set 'AcademiaDbContext.Comisiones'  is null.");
          }
            _context.Comisiones.Add(comisione);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComisione", new { id = comisione.IdComision }, comisione);
        }

        // DELETE: api/Comisiones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComisione(int id)
        {
            if (_context.Comisiones == null)
            {
                return NotFound();
            }
            var comisione = await _context.Comisiones.FindAsync(id);
            if (comisione == null)
            {
                return NotFound();
            }

            _context.Comisiones.Remove(comisione);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComisioneExists(int id)
        {
            return (_context.Comisiones?.Any(e => e.IdComision == id)).GetValueOrDefault();
        }
    }
}
