using System;
using System.IO;
using Newtonsoft.Json;
using Sciendo.Query.Contracts;
using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.DataProviders
{
    public class MockResultsProvider : ResultsProviderBase
    {
        public string MockFilePath { private get; set; }
        public override Doc[] GetResultRows(string query)
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"App_data");
            if (string.IsNullOrEmpty(MockFilePath))
                MockFilePath =
                    Path.Combine(dir,"examplequeryresult.json");
            using (var fs = File.OpenText(MockFilePath))
            {
                var txt = fs.ReadToEnd();
                var solrResponse = JsonConvert.DeserializeObject<SolrResponse>(txt, new HighlightsConverter());
                return ApplyHighlights(solrResponse);
            }            
        }
    }
}