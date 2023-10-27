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
    public class ModulosUsuariosController : ControllerBase
    {
        private readonly AcademiaDbContext _context;

        public ModulosUsuariosController(AcademiaDbContext context)
        {
            _context = context;
        }

        // GET: api/ModulosUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModulosUsuario>>> GetModulosUsuarios()
        {
          if (_context.ModulosUsuarios == null)
          {
              return NotFound();
          }
            return await _context.ModulosUsuarios.ToListAsync();
        }

        // GET: api/ModulosUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ModulosUsuario>> GetModulosUsuario(int id)
        {
          if (_context.ModulosUsuarios == null)
          {
              return NotFound();
          }
            var modulosUsuario = await _context.ModulosUsuarios.FindAsync(id);

            if (modulosUsuario == null)
            {
                return NotFound();
            }

            return modulosUsuario;
        }

        // PUT: api/ModulosUsuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModulosUsuario(int id, ModulosUsuario modulosUsuario)
        {
            if (id != modulosUsuario.IdModuloUsuario)
            {
                return BadRequest();
            }

            _context.Entry(modulosUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModulosUsuarioExists(id))
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

        // POST: api/ModulosUsuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ModulosUsuario>> PostModulosUsuario(ModulosUsuario modulosUsuario)
        {
          if (_context.ModulosUsuarios == null)
          {
              return Problem("Entity set 'AcademiaDbContext.ModulosUsuarios'  is null.");
          }
            _context.ModulosUsuarios.Add(modulosUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModulosUsuario", new { id = modulosUsuario.IdModuloUsuario }, modulosUsuario);
        }

        // DELETE: api/ModulosUsuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModulosUsuario(int id)
        {
            if (_context.ModulosUsuarios == null)
            {
                return NotFound();
            }
            var modulosUsuario = await _context.ModulosUsuarios.FindAsync(id);
            if (modulosUsuario == null)
            {
                return NotFound();
            }

            _context.ModulosUsuarios.Remove(modulosUsuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ModulosUsuarioExists(int id)
        {
            return (_context.ModulosUsuarios?.Any(e => e.IdModuloUsuario == id)).GetValueOrDefault();
        }
    }
}
