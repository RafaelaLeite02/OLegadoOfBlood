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

        [HttpGet("lista")]
        public async Task<IActionResult> GetLista()
        {
            var livros = await _context.Livros

                .Select(l => new { l.Id, Nome = l.Titulo })
                .ToListAsync();

            return Ok(livros);
        }



    }
}

