using Newtonsoft.Json;

namespace Sciendo.Query.DataProviders.Solr
{
    public class ResponseHeader
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        public int QTime { get; set; }
    }
}
