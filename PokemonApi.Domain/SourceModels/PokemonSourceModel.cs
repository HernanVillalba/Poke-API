using PokemonApi.Domain.SubModels;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokemonApi.Domain.SourceModels
{
    public class PokemonSourceModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abilities")]
        public List<Ability> Abilities { get; set; }
    }
}
