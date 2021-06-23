using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.Infrastructure.Models
{
    public abstract class ModelBase
    {
    }

    public abstract class SourceModelBase
    {
        protected SourceModelBase()
        {

        }

        public string ToJson() => JsonConvert.SerializeObject(this);

        public StringContent Serialize() => new(ToJson(), Encoding.UTF8, "application/json");
    }
}
