using Newtonsoft.Json;
using System.Collections.Generic;

namespace Assetto_Corsa_CarTimesApp.Models
{
    public class CarUiJson
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }
}
