using Newtonsoft.Json;
using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.DataProviders.Solr
{
    public class Response
    {
        [JsonProperty("numFound")]
        public int NumFound { get; set; }
        [JsonProperty("start")]
        public int Start { get; set; }
        [JsonProperty("docs")]
        public Doc[] Docs { get; set; }
    }
}
