using Newtonsoft.Json;
using Sciendo.Query.Contracts;
using Sciendo.Query.Contracts.Model;
using System.IO;

namespace Sciendo.Query.DataProviders
{
    public class MockResultsProvider : IResultsProvider
    {
        public Doc[] GetResultRows(string query)
        {
            using (var fs = File.OpenText(@"C:\Code\Sciendo\Sciendo.Query\querysc\Sciendo.Query.DataProviders\examplequeryresult.json"))
            {
                var txt = fs.ReadToEnd();
                var solrResponse = JsonConvert.DeserializeObject<SolrResponse>(txt);
                return solrResponse.response.docs;
            }
        }
    }
}