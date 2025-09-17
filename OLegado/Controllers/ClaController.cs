using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLegado.Data;
using OLegado.DTOs;
using OLegado.Entities;

namespace OLegado.Controllers
{
 
    
        [Route("api/[controller]")]
        [ApiController]
        public class ClasController : ControllerBase
        {
            private readonly AppDbContext _context;

            public ClasController(AppDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<ClaDTO>>> GetClas()
            {
                return await _context.Clas
                    .Select(c => new ClaDTO
                    {
                        Id = c.Id,
                        Name = c.Nome,
                    })
                    .ToListAsync();
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<ClaDTO>> GetCla(int id)
            {
                var cla = await _context.Clas.FindAsync(id);

                if(cla == null)
                {
                    return NotFound();
                }

                var claDTO = new ClaDTO
                {
                    Id = cla.Id,
                    Name = cla.Nome,
                };

                return claDTO;
            }

            [HttpPost]
            public async Task<ActionResult<ClaDTO>> PostCla(Cla cla)
            {
                _context.Clas.Add(cla);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetCla), new { id = cla.Id }, cla);
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCla(int id)
            {
                var cla = await _context.Clas.FindAsync(id);
                if(cla == null)
                {
                    return NotFound();
                }

                _context.Clas.Remove(cla);  
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool ClaExists(int id)
            {
                return _context.Clas.Any(e => e.Id == id);
            }
        }
    
}
