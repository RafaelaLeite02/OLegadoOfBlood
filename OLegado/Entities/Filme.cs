using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLegado.Entities
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;

        public ICollection<PersonagemFilme> PersonagemFilmes { get; set; }
    }
}
