using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Sciendo.Query.Contracts.Model;
using Sciendo.Query.DataProviders.Solr;

namespace Sciendo.Query.DataProviders
{
    public class MockResultsProvider : ResultsProviderBase
    {
        public override ResultsPackage GetResultsPackage(string query)
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"App_data");
            var mockFilePath =
                    Path.Combine(dir,"examplequeryresult.json");
            using (var fs = File.OpenText(mockFilePath))
            {
                var txt = fs.ReadToEnd();
                var solrResponse = JsonConvert.DeserializeObject<SolrResponse>(txt, new DictionariesConverter());

                return new ResultsPackage
                {
                    ResultRows = ApplyHighlights(solrResponse),
                    FacetFields = GetFacetFields(solrResponse)
                };
            }            
        }
    }
}