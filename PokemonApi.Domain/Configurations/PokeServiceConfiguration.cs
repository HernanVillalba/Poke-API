using PokemonApi.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.Domain.Configurations
{
    public class PokeServiceConfiguration : HttpConfiguration
    {
        public string UrlPokemon { get; set; }
        public PokeServiceConfiguration() { }
    }
}
