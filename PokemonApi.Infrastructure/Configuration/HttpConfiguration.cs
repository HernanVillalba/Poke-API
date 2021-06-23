namespace PokemonApi.Infrastructure.Configuration
{
    public abstract class HttpConfiguration
    {
        public virtual string UrlBase { get; set; }
        public HttpConfiguration() { }
    }
}
