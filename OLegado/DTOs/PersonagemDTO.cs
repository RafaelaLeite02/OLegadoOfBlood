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

        public int? LivroId { get; set; }
        public int? FilmeId { get; set; }

        [Required]
        public string ClaNome { get; set; }
        [Required]
        public string TipoCriaturaNome { get; set; }
    }
}
