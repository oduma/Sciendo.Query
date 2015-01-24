using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.DataProviders.Solr
{
    public class Response
    {
        public int numFound { get; set; }

        public int start { get; set; }

        public Doc[] docs { get; set; }
    }
}
