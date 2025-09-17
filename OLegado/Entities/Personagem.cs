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
        public string Name { get; set; }
        public string FotoURL { get; set; }
        public int Idade { get; set; }
        public string Poder { get; set; }
        public string Descricao { get; set; }


        public int ClaId { get; set; }
        public Cla NomeCla { get; set; }


        public int TipoCriaturaId { get; set; }
        public TipoCriatura Criatura { get; set; }
    }
}