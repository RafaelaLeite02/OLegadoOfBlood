using OLegado.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLegado.Entities
{
    public class PersonagemFilme
    {
        public int Id { get; set; }
        public int PersonagemId { get; set; }
        public Personagem PersonagemF { get; set; }

        public int FilmeId { get; set; }
        public Filme TituloF { get; set; }
    }
}