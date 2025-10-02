using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLegado.Data;
using OLegado.DTOs;
using OLegado.Entities;

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

        [HttpGet("lista")]
        public async Task<IActionResult> GetLista()
        {
            var filmes = await _context.Filmes
                .Select(f => new { f.Id, Nome = f.Titulo })
                .ToListAsync();

            return Ok(filmes);
        }



    }
}

