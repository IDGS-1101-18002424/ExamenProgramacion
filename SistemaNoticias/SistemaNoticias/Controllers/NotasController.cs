using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaNoticias.Data;
using SistemaNoticias.Models;

namespace SistemaNoticias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        private readonly SistemaNoticiasContext _context;

        public NotaController(SistemaNoticiasContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nota>>> GetNotas()
        {
            return await _context.Notas.Include(n => n.Personal).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Nota>> GetNota(int id)
        {
            var nota = await _context.Notas.Include(n => n.Personal).FirstOrDefaultAsync(n => n.IdNota == id);
            if (nota == null)
            {
                return NotFound();
            }
            return nota;
        }

        [HttpPost]
        public async Task<ActionResult<Nota>> PostNota(Nota nota)
        {
            if (nota == null ||
                string.IsNullOrWhiteSpace(nota.Titulo) ||
                string.IsNullOrWhiteSpace(nota.Contenido) ||
                nota.IdPersonal <= 0) // Validación del ID Personal
            {
                return BadRequest("El título, contenido y ID de personal son obligatorios.");
            }

            _context.Notas.Add(nota);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetNota), new { id = nota.IdNota }, nota);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutNota(int id, Nota nota)
        {
            if (id != nota.IdNota || nota == null)
            {
                return BadRequest();
            }

            _context.Entry(nota).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotaExists(id))
                {
                    return NotFound();
                }
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNota(int id)
        {
            var nota = await _context.Notas.FindAsync(id);
            if (nota == null)
            {
                return NotFound();
            }

            _context.Notas.Remove(nota);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool NotaExists(int id)
        {
            return _context.Notas.Any(e => e.IdNota == id);
        }
    }
}
