using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaNoticias.Data;
using SistemaNoticias.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaNoticias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespuestaComentarioController : ControllerBase
    {
        private readonly SistemaNoticiasContext _context;

        public RespuestaComentarioController(SistemaNoticiasContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RespuestaComentario>>> GetRespuestaComentarios()
        {
            return await _context.RespuestaComentarios.Include(rc => rc.Comentario).Include(rc => rc.Usuario).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RespuestaComentario>> GetRespuestaComentario(int id)
        {
            var respuestaComentario = await _context.RespuestaComentarios.Include(rc => rc.Comentario).Include(rc => rc.Usuario).FirstOrDefaultAsync(rc => rc.IdRespuesta == id);
            if (respuestaComentario == null)
            {
                return NotFound();
            }
            return respuestaComentario;
        }

        [HttpPost]
        public async Task<ActionResult<RespuestaComentario>> PostRespuestaComentario(RespuestaComentario respuestaComentario)
        {
            if (respuestaComentario == null || string.IsNullOrWhiteSpace(respuestaComentario.Contenido))
            {
                return BadRequest("El contenido de la respuesta es obligatorio.");
            }

            _context.RespuestaComentarios.Add(respuestaComentario);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetRespuestaComentario), new { id = respuestaComentario.IdRespuesta }, respuestaComentario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRespuestaComentario(int id, RespuestaComentario respuestaComentario)
        {
            if (id != respuestaComentario.IdRespuesta || respuestaComentario == null)
            {
                return BadRequest();
            }

            _context.Entry(respuestaComentario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RespuestaComentarioExists(id))
                {
                    return NotFound();
                }
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRespuestaComentario(int id)
        {
            var respuestaComentario = await _context.RespuestaComentarios.FindAsync(id);
            if (respuestaComentario == null)
            {
                return NotFound();
            }

            _context.RespuestaComentarios.Remove(respuestaComentario);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool RespuestaComentarioExists(int id)
        {
            return _context.RespuestaComentarios.Any(e => e.IdRespuesta == id);
        }
    }
}
