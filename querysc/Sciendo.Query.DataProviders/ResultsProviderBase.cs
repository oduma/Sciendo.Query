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
        public abstract ResultsPackage GetResultsPackage(string query);

        protected Dictionary<string, Dictionary<string, int>> GetFacetFields(SolrResponse solrResponse)
        {
            if(solrResponse==null || solrResponse.facet_counts==null || solrResponse.facet_counts.facet_fields==null)
                return null;
            Dictionary<string,Dictionary<string,int>> facetFields = new Dictionary<string,Dictionary<string,int>>();

            facetFields.Add("Artists", GetFacetField(solrResponse.facet_counts.facet_fields.artist_f));
            facetFields.Add("Extensions", GetFacetField(solrResponse.facet_counts.facet_fields.extension_f));
            facetFields.Add("Letters", GetFacetField(solrResponse.facet_counts.facet_fields.letter_catalog_f));
            return facetFields;
        }

        private Dictionary<string, int> GetFacetField(object[] fieldFacet)
        {

            if (fieldFacet != null || fieldFacet.Any())
            {
                var facetField = new Dictionary<string, int>();
                var newKey = string.Empty;
                var newValue = 0;
                for (int i = 0; i < fieldFacet.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        newKey = (string)((fieldFacet[i]) ?? "Unknown");
                        newValue = 0;
                    }
                    else
                        newValue = Convert.ToInt32(fieldFacet[i]);

                    if (newValue != 0)
                    {
                        facetField.Add(newKey, newValue);
                        newKey = string.Empty;
                    }
                }
                return facetField;
            }
            return null;
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
