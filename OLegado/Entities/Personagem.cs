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
        public int Idade { get; set; }  
        public string Poder { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;


        public int ClaId { get; set; }
        public Cla Nome { get; set; }    


        public int TipoCriaturaId { get; set; }
        public TipoCriatura Criatura { get; set; }
    }
}