using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLegado.Entities
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FotoURL { get; set; } = string.Empty;
        public string Idade { get; set; }  
        public string Poder { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string FonteMidia { get; set; } = string.Empty;
        public string Habilidades { get; set; } 
        public string Personalidade { get; set; } 
        public int? NivelPoder { get; set; }

        public int? LivroId { get; set; }
        public int? FilmeId { get; set; }


        public int ClaId { get; set; }
        public Cla Cla { get; set; }

        public int TipoCriaturaId { get; set; }
        public TipoCriatura TipoCriatura { get; set; }

    }
}