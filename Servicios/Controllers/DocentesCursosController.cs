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
    public class DocentesCursosController : ControllerBase
    {
        private readonly AcademiaDbContext _context;

        public DocentesCursosController(AcademiaDbContext context)
        {
            _context = context;
        }

        // GET: api/DocentesCursoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocentesCurso>>> GetDocentesCursos()
        {
          if (_context.DocentesCursos == null)
          {
              return NotFound();
          }
            return await _context.DocentesCursos.ToListAsync();
        }

        // GET: api/DocentesCursoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocentesCurso>> GetDocentesCurso(int id)
        {
          if (_context.DocentesCursos == null)
          {
              return NotFound();
          }
            var docentesCurso = await _context.DocentesCursos.FindAsync(id);

            if (docentesCurso == null)
            {
                return NotFound();
            }

            return docentesCurso;
        }

        // PUT: api/DocentesCursoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocentesCurso(int id, DocentesCurso docentesCurso)
        {
            if (id != docentesCurso.IdDictado)
            {
                return BadRequest();
            }

            _context.Entry(docentesCurso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocentesCursoExists(id))
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

        // POST: api/DocentesCursoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DocentesCurso>> PostDocentesCurso(DocentesCurso docentesCurso)
        {
          if (_context.DocentesCursos == null)
          {
              return Problem("Entity set 'AcademiaDbContext.DocentesCursos'  is null.");
          }
            _context.DocentesCursos.Add(docentesCurso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocentesCurso", new { id = docentesCurso.IdDictado }, docentesCurso);
        }

        // DELETE: api/DocentesCursoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocentesCurso(int id)
        {
            if (_context.DocentesCursos == null)
            {
                return NotFound();
            }
            var docentesCurso = await _context.DocentesCursos.FindAsync(id);
            if (docentesCurso == null)
            {
                return NotFound();
            }

            _context.DocentesCursos.Remove(docentesCurso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DocentesCursoExists(int id)
        {
            return (_context.DocentesCursos?.Any(e => e.IdDictado == id)).GetValueOrDefault();
        }
    }
}
