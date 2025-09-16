using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLegado.Data;
using OLegado.DTOs;
using OLegado.DTOs;
using OLegado.Entities;
using OLegado.Data;

namespace OLegado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FilmeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmeDTO>>> GetFilmes()
        {
            return await _context.Filmes
                .Select(f => new FilmeDTO
                {
                    Id = f.Id,
                    Titulo = f.Titulo,
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FilmeDTO>> GetFilme(int id)
        {
            var filme = await _context.Filmes.FindAsync(id);

            if (filme == null)
            {
                return NotFound();
            }

            var filmeDTO = new FilmeDTO
            {
                Id = filme.Id,
                Titulo = filme.Titulo,
            };

            return filmeDTO;
        }



    }
}

