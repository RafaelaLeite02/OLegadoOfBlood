using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLegado.Data;
using OLegado.DTOs;
using OLegado.Entities;

namespace OLegado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LivroController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LivroDTO>>> GetLivros()
        {
            return await _context.Livros
                .Select(l => new LivroDTO
                {
                    Id = l.Id,
                    Titulo = l.Titulo,
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LivroDTO>> GetLivro(int id)
        {
            var livro = await _context.Livros.FindAsync(id);

            if (livro == null)
            {
                return NotFound();
            }

            var livroDTO = new LivroDTO
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
            };

            return livroDTO;
        }



    }
}

