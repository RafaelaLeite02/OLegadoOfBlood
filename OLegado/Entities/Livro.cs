using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLegado.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public ICollection<Livro> livros { get; set; }
    }
}