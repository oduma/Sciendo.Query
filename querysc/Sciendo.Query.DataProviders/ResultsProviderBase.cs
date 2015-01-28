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
        public abstract ResultsPackage GetResultsPackage(string query, int numRow, int startRow);

        protected Field[] GetFields(SolrResponse solrResponse)
        {
            if(solrResponse==null || solrResponse.facet_counts==null || solrResponse.facet_counts.facet_fields==null)
                return null;
            return new Field[] {new Field{Name="Artists", Values=GetFacetField(solrResponse.facet_counts.facet_fields.artist_f).Where(a=>a!=null).ToArray()},
            new Field{Name="Extensions", Values=GetFacetField(solrResponse.facet_counts.facet_fields.extension_f).Where(a=>a!=null).ToArray()},
            new Field{Name="Letters", Values=GetFacetField(solrResponse.facet_counts.facet_fields.letter_catalog_f).Where(a=>a!=null).ToArray()}
        };
        }

        private IEnumerable<FieldValue> GetFacetField(object[] fieldFacet)
        {

            if (fieldFacet != null || fieldFacet.Any())
            {
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
                        yield return new FieldValue { Key = newKey, Count = newValue };
                        newKey = string.Empty;
                    }
                }
            }
            yield return null;
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

        protected PageInfo GetNewPageInfo (SolrResponse response, int numRowsRequested, int startRow)
        {
            return new PageInfo { TotalRows = response.response.numFound, RowsPerPage = numRowsRequested, PageStartRow = startRow };
        }

        public abstract ResultsPackage GetFilteredResultsPackage(string criteria, int numRow, int startRow, string facetFieldName, string facetFieldValue);
    }
}
