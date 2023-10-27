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
    public class AlumnosInscripcionesController : ControllerBase
    {
        private readonly AcademiaDbContext _context;

        public AlumnosInscripcionesController(AcademiaDbContext context)
        {
            _context = context;
        }

        // GET: api/AlumnosInscripciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlumnosInscripcione>>> GetAlumnosInscripciones()
        {
          if (_context.AlumnosInscripciones == null)
          {
              return NotFound();
          }
            return await _context.AlumnosInscripciones.ToListAsync();
        }

        // GET: api/AlumnosInscripciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlumnosInscripcione>> GetAlumnosInscripcione(int id)
        {
          if (_context.AlumnosInscripciones == null)
          {
              return NotFound();
          }
            var alumnosInscripcione = await _context.AlumnosInscripciones.FindAsync(id);

            if (alumnosInscripcione == null)
            {
                return NotFound();
            }

            return alumnosInscripcione;
        }

        // PUT: api/AlumnosInscripciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumnosInscripcione(int id, AlumnosInscripcione alumnosInscripcione)
        {
            if (id != alumnosInscripcione.IdInscripcion)
            {
                return BadRequest();
            }

            _context.Entry(alumnosInscripcione).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnosInscripcioneExists(id))
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

        // POST: api/AlumnosInscripciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlumnosInscripcione>> PostAlumnosInscripcione(AlumnosInscripcione alumnosInscripcione)
        {
          if (_context.AlumnosInscripciones == null)
          {
              return Problem("Entity set 'AcademiaDbContext.AlumnosInscripciones'  is null.");
          }
            _context.AlumnosInscripciones.Add(alumnosInscripcione);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlumnosInscripcione", new { id = alumnosInscripcione.IdInscripcion }, alumnosInscripcione);
        }

        // DELETE: api/AlumnosInscripciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumnosInscripcione(int id)
        {
            if (_context.AlumnosInscripciones == null)
            {
                return NotFound();
            }
            var alumnosInscripcione = await _context.AlumnosInscripciones.FindAsync(id);
            if (alumnosInscripcione == null)
            {
                return NotFound();
            }

            _context.AlumnosInscripciones.Remove(alumnosInscripcione);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlumnosInscripcioneExists(int id)
        {
            return (_context.AlumnosInscripciones?.Any(e => e.IdInscripcion == id)).GetValueOrDefault();
        }
    }
}
