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
    public class EspecialidadesController : ControllerBase
    {
        private readonly AcademiaDbContext _context;

        public EspecialidadesController(AcademiaDbContext context)
        {
            _context = context;
        }

        // GET: api/Especialidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Especialidade>>> GetEspecialidades()
        {
          if (_context.Especialidades == null)
          {
              return NotFound();
          }
            return await _context.Especialidades.ToListAsync();
        }

        // GET: api/Especialidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Especialidade>> GetEspecialidade(int id)
        {
          if (_context.Especialidades == null)
          {
              return NotFound();
          }
            var especialidade = await _context.Especialidades.FindAsync(id);

            if (especialidade == null)
            {
                return NotFound();
            }

            return especialidade;
        }

        // PUT: api/Especialidades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspecialidade(int id, Especialidade especialidade)
        {
            if (id != especialidade.IdEspecialidad)
            {
                return BadRequest();
            }

            _context.Entry(especialidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspecialidadeExists(id))
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

        // POST: api/Especialidades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Especialidade>> PostEspecialidade(Especialidade especialidade)
        {
          if (_context.Especialidades == null)
          {
              return Problem("Entity set 'AcademiaDbContext.Especialidades'  is null.");
          }
            _context.Especialidades.Add(especialidade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEspecialidade", new { id = especialidade.IdEspecialidad }, especialidade);
        }

        // DELETE: api/Especialidades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEspecialidade(int id)
        {
            if (_context.Especialidades == null)
            {
                return NotFound();
            }
            var especialidade = await _context.Especialidades.FindAsync(id);
            if (especialidade == null)
            {
                return NotFound();
            }

            _context.Especialidades.Remove(especialidade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EspecialidadeExists(int id)
        {
            return (_context.Especialidades?.Any(e => e.IdEspecialidad == id)).GetValueOrDefault();
        }
    }
}
