using Newtonsoft.Json;

namespace VTEX.Transport
{
    public class SKU
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
