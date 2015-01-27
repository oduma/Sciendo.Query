using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sciendo.Query.Contracts;
using Sciendo.Query.Contracts.Model;
using Sciendo.Query.DataProviders.Solr;

namespace Sciendo.Query.DataProviders
{
    public class SolrResultsProvider:ResultsProviderBase
    {
        public override ResultsPackage GetResultsPackage(string query)
        {
            var solrResponse = SolRetriever.TryQuery("http://localhost:8080/solr/medialib/select", (new SolrQueryStrategy(query)).GetQueryString);
            if (solrResponse == null)
                return null;

            return new ResultsPackage
            {
                ResultRows = ApplyHighlights(solrResponse),
                Fields = GetFields(solrResponse)
            };

        }

        public override ResultsPackage GetFilteredResultsPackage(string criteria, string facetFieldName, string facetFieldValue)
        {
            var solrResponse = SolRetriever.TryQuery("http://localhost:8080/solr/medialib/select", (new SolrQueryStrategy(criteria,facetFieldName,facetFieldValue)).GetFilterString);
            if (solrResponse == null)
                return null;

            return new ResultsPackage
            {
                ResultRows = ApplyHighlights(solrResponse),
                Fields = GetFields(solrResponse)
            };
        }
    }
}
