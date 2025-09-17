using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLegado.Data;
using OLegado.DTOs;
using OLegado.Entities;

namespace OLegado.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TipoCriaturasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TipoCriaturasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoCriaturaDTO>>> GetTipoCriatura()
        {
            return await _context.TipoCriaturas
                .Select(c => new TipoCriaturaDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TipoCriaturaDTO>> GetTipoCriatura(int id)
        {
            var tipoCriatura = await _context.TipoCriaturas.FindAsync(id);

            if (tipoCriatura == null)
            {
                return NotFound();
            }

            var tipoCriaturaDTO = new TipoCriaturaDTO
            {
                Id = tipoCriatura.Id,
                Name = tipoCriatura.Name,
            };

            return tipoCriaturaDTO;
        }

        [HttpPost]
        public async Task<ActionResult<TipoCriaturaDTO>> PostTipoCriatura(TipoCriatura tipoCriatura)
        {
            _context.TipoCriaturas.Add(tipoCriatura);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTipoCriatura), new { id = tipoCriatura.Id }, tipoCriatura);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoCriatura(int id)
        {
            var tipoCriatura = await _context.TipoCriaturas.FindAsync(id);
            if (tipoCriatura == null)
            {
                return NotFound();
            }

            _context.TipoCriaturas.Remove(tipoCriatura);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoCriaturaExists(int id)
        {
            return _context.TipoCriaturas.Any(e => e.Id == id);
        }
    }

}

