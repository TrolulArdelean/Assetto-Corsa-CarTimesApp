using Newtonsoft.Json;

namespace Assetto_Corsa_CarTimesApp.Models
{
    public class TrackLayout
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("length")]
        public string Length { get; private set; }

        public string TrackNameInPersonalBestIni { get; set; }
    }
}
