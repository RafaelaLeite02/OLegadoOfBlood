using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLegado.Data;
using OLegado.DTOs;
using OLegado.Entities;

namespace OLegado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagemController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PersonagemController(AppDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonagemDTO>>> GetPersonagens()
        { 
            var personagens = await _context.Personagens.ToListAsync();

            var personagemDTOs = personagens.Select(p => new PersonagemDTO
            {
                Id = p.Id,
                Name = p.Name,
                FotoURL = p.FotoURL,
                Idade = p.Idade,
                Poder = p.Poder,
                Descricao = p.Descricao,
                ClaId = p.ClaId,
                TipoCriaturaId = p.TipoCriaturaId,

            }).ToList();

 
            return Ok(personagemDTOs);
        }

      
        [HttpPost]
        public async Task<ActionResult<PersonagemDTO>> PostPersonagens(Personagem personagem)
        {
            _context.Personagens.Add(personagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPersonagens), new { id = personagem.Id }, personagem );
        }

      
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonagem(int id, Personagem personagem)
        {
            if (id != personagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(personagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonagemExists(id))
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

        private bool PersonagemExists(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonagem(int id)
        {
            var personagem = await _context.Personagens.FindAsync(id);
            if (personagem  == null)
            {
                return NotFound();
            }

            _context.Personagens.Remove(personagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonagensExists(int id)
        {
            return _context.Filmes.Any(e => e.Id == id);
        }
    }
}
