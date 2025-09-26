using OLegado.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OLegado.Entities
{
    public class Cla
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<Personagem> Personagens;
    }


}


