using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokemonApi.Domain.SubModels
{
    public class Abilities
    {
        [JsonPropertyName("abiliti")]
        public List<Ability> Ability { get; set; }
        
        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonPropertyName("slot")]
        public int Slot { get; set; }
    }
}
