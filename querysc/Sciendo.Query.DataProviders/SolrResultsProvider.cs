using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sciendo.Query.Contracts;
using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.DataProviders
{
    public class SolrResultsProvider:ResultsProviderBase
    {
        public override ResultsPackage GetResultsPackage(string query)
        {
            throw new NotImplementedException();
        }

        public override ResultsPackage GetFilteredResultsPackage(string criteria, string facetFieldName, string facetFieldValue)
        {
            throw new NotImplementedException();
        }
    }
}
