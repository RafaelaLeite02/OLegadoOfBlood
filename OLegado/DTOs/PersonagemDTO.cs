using OLegado.Entities;

namespace OLegado.DTOs
{
    public class PersonagemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FotoURL { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Poder { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public int ClaId { get; set; }
        public virtual Cla Cla { get; set; }

        public int TipoCriaturaId { get; set; }
        public virtual TipoCriatura TipoCriatura { get; set; }
    }
}
