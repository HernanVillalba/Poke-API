using Microsoft.Extensions.Options;
using PokemonApi.Domain.Configurations;
using PokemonApi.Domain.SourceModels;
using PokemonApi.Infrastructure.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonApi.Application.Services.API
{
    public interface IPokeService
    {
        Task<PokemonGetAllSourceModel> GetAll();
        Task<PokemonSourceModel> GetPokemonByName(string name);
    }
    public class PokeService : ApiService, IPokeService
    {
        private readonly PokeServiceConfiguration pokeServiceConfiguration;

        public PokeService(HttpClient httpClient, IOptions<PokeServiceConfiguration> options) : base(httpClient)
        {
            pokeServiceConfiguration = options.Value;
        }

        public async Task<PokemonGetAllSourceModel> GetAll()
        {
            var endopint = string.Format(pokeServiceConfiguration.UrlPokemon, "");

            var response = await Get<PokemonGetAllSourceModel>(endopint);

            return response;
        }

        public async Task<PokemonSourceModel> GetPokemonByName(string name)
        {
            string endpoint = string.Format(pokeServiceConfiguration.UrlPokemon, name);

            var response = await Get<PokemonSourceModel>(endpoint, null);

            return response;
        }
    }
}
