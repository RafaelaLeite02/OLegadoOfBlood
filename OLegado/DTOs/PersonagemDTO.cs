using OLegado.Entities;

namespace OLegado.DTOs
{
    public class PersonagemDTO
    {
        public string Name { get; set; } = string.Empty;
        public string FotoURL { get; set; } = string.Empty;
        public string Idade { get; set; }
        public string Poder { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public string ClaNome { get; set; }

        public string TipoCriaturaNome { get; set; }
    }
}
