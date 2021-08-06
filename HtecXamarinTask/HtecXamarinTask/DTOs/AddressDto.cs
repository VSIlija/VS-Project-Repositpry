using Newtonsoft.Json;

namespace HtecXamarinTask.DTOs
{
    public class AddressDto
    {
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "suite")]
        public string Suite { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty(PropertyName = "geo")]
        public GeoLocationDto Geo { get; set; }
    }
}
