using System;
using System.IO;
using Newtonsoft.Json;
using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.DataProviders
{
    public class MockResultsProvider : ResultsProviderBase
    {
        public override Doc[] GetResultRows(string query)
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"App_data");
            var mockFilePath =
                    Path.Combine(dir,"examplequeryresult.json");
            using (var fs = File.OpenText(mockFilePath))
            {
                var txt = fs.ReadToEnd();
                var solrResponse = JsonConvert.DeserializeObject<SolrResponse>(txt, new HighlightsConverter());
                return ApplyHighlights(solrResponse);
            }            
        }
    }
}