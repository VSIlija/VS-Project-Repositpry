using Newtonsoft.Json;

namespace HtecXamarinTask.DTOs
{
    public class CompanyDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "catchPhrase")]
        public string CatchPhrase { get; set; }

        [JsonProperty(PropertyName = "bs")]
        public string Bs { get; set; }
    }
}
