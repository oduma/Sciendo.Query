using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sciendo.Query.Contracts;
using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.DataProviders
{
    public class SolrResultsProvider:IResultsProvider
    {
        public ResultRow[] GetResultRows(string query)
        {
            throw new NotImplementedException();
        }
    }
}
