using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokemonApi.Application.Services.API;
using PokemonApi.Domain.SourceModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokemonApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly ILogger<PokemonController> logger;
        private readonly IPokeService pokeService;
        public PokemonController(ILogger<PokemonController> logger, IPokeService pokeService)
        {
            this.logger = logger;
            this.pokeService = pokeService;
        }
        /// <summary>
        /// Obtiene todos los pokemones
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await pokeService.GetAll());
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            return Ok(await pokeService.GetPokemonByName(name));
        }
    }
}
