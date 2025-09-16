using OLegado.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLegado.Entities
{
    public class PersonagemLivro
    {
        public int Id { get; set; }
        public int PersonagemId { get; set; }
        public Personagem PersonagemL { get; set; }

        public int LivroId { get; set; }
        public Livro TituloL { get; set; }
    }
}
