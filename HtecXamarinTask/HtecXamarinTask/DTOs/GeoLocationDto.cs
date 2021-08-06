using Newtonsoft.Json;

namespace HtecXamarinTask.DTOs
{
    public class GeoLocationDto
    {
        [JsonProperty(PropertyName = "lat")]
        public string Lat { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public string Lng { get; set; }
    }
}
