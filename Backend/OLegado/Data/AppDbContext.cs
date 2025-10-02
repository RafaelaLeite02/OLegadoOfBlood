using Microsoft.EntityFrameworkCore;
using OLegado.Entities;

namespace OLegado.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Cla> Clas { get; set; }
        public DbSet<TipoCriatura> TipoCriaturas { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<PersonagemFilme> PersonagemFilmes { get; set; }
        public DbSet<PersonagemLivro> GetPersonagemLivros { get; set; }

    }
}
