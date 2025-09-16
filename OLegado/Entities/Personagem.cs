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


        public Personagem(string name, string fotoURL, int idade, string poder, string descricao, int claId)
        {
            Name = name;
            FotoURL = fotoURL;
            Idade = idade;
            Poder = poder;
            Descricao = descricao;
            ClaId = claId;
        }
    }
}