using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace PokemonApi.Domain.SubModels
{
    public class Ability
    {
        [JsonProperty("ability", NullValueHandling = NullValueHandling.Ignore)]
        public Species AbilityAbility { get; set; }

        [JsonProperty("is_hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHidden { get; set; }

        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public long? Slot { get; set; }
    }
}
