using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLegado.Data;
using OLegado.DTOs;
using OLegado.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OLegado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonagemController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PersonagemController(AppDbContext context)
        {
            _context = context;
        }

        // POST
        [HttpPost]
        public IActionResult CriarPersonagem([FromBody] PersonagemDTO dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var cla = _context.Clas.FirstOrDefault(c => c.Nome == dto.ClaNome);
                if (cla == null)
                    return BadRequest($"Clã '{dto.ClaNome}' não encontrado.");

                var tipoCriatura = _context.TipoCriaturas.FirstOrDefault(t => t.Nome == dto.TipoCriaturaNome);
                if (tipoCriatura == null)
                    return BadRequest($"Tipo de Criatura '{dto.TipoCriaturaNome}' não encontrado.");

                var personagem = new Personagem
                {
                    Name = dto.Name,
                    FotoURL = dto.FotoURL,
                    Idade = dto.Idade,
                    Poder = dto.Poder,
                    Descricao = dto.Descricao,
                    ClaId = cla.Id,
                    TipoCriaturaId = tipoCriatura.Id,
                    LivroId = dto.LivroId,
                    FilmeId = dto.FilmeId,
                    FonteMidia = dto.FonteMidia,
                };

                _context.Personagens.Add(personagem);
                _context.SaveChanges();

                return CreatedAtAction(nameof(GetById), new { id = personagem.Id }, personagem);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno: {ex.Message}");
            }
        }

        
        [HttpGet]
        public IActionResult GetAll([FromQuery] string filtro)
        {
            
            var query = _context.Personagens.AsQueryable();

            query = query
                 .Include(p => p.Cla)
                 .Include(p => p.TipoCriatura);

            if (!string.IsNullOrEmpty(filtro) && filtro.ToLower() != "todos")
            {
                query = query.Where(p => p.FonteMidia.ToLower() == filtro.ToLower());
            }

            var personagens = query
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.FotoURL,
                    p.Idade,
                    p.Poder,
                    p.Descricao,
                    Cla = p.Cla.Nome,
                    TipoCriatura = p.TipoCriatura.Nome,
                    FonteMidia = p.FonteMidia
                })
                .ToList();

            return Ok(personagens);
        }

        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var personagem = _context.Personagens
                .Where(p => p.Id == id)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.FotoURL,
                    p.Idade,
                    p.Poder,
                    p.Descricao,
                    Cla = p.Cla.Nome,
                    TipoCriatura = p.TipoCriatura.Nome,
                    FonteMidia = p.FonteMidia
                })
                .FirstOrDefault();

            if (personagem == null)
                return NotFound();

            return Ok(personagem);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var personagem = _context.Personagens.FirstOrDefault(p => p.Id == id);
            if (personagem == null)
                return NotFound($"Personagem com ID {id} não encontrado.");

            _context.Personagens.Remove(personagem);
            _context.SaveChanges();

            return NoContent(); 
        }
    }
}