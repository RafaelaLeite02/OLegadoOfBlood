using OLegado.Entities;
using System.ComponentModel.DataAnnotations;

namespace OLegado.DTOs
{
    public class PersonagemDTO
    {
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

        
        public string ClaNome { get; set; }
      
        public string TipoCriaturaNome { get; set; }
    }
}
