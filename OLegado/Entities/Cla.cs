using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLegado.Entities
{
    public class Cla
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public ICollection<Personagem> Personagens { get; set; }    
    }
}


