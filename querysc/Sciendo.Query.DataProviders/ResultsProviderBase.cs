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
    public abstract class ResultsProviderBase:IResultsProvider
    {
        public abstract ResultsPackage GetResultRows(string query);

        protected Dictionary<string, Dictionary<string, int>> GetFacetFields(SolrResponse solrResponse)
        {
            throw new NotImplementedException();
        }

        protected Doc[] ApplyHighlights(SolrResponse response)
        {
            return response.response.docs.Join(response.highlighting, d => d.file_path_id, h => h.Key,
                (d, h) =>
                    new Doc
                    {
                        album = (h.Value.album == null) ? d.album : h.Value.album[0],
                        artist = (h.Value.artist == null) ? d.artist : h.Value.artist,
                        file_path_id = d.file_path_id,
                        lyrics = (h.Value.lyrics == null) ? d.lyrics : h.Value.lyrics[0],
                        title = (h.Value.title == null) ? d.title : h.Value.title[0],
                        file_path = d.file_path
                    }).ToArray();
        }
    }
}
