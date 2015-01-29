using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.DataProviders.Solr
{
    public class SolrQueryStrategy
    {
        public SolrQueryStrategy(string query, int numRows, int startRow)
        {
            _query = query;
            _numRows = numRows;
            _startRow = startRow;
        }

        public SolrQueryStrategy(string query,int numRows, int startRow, string filterField, string filterValue):this(query, numRows, startRow)
        {
            _filterField=filterField;
            _filterValue=filterValue;
        }

        private Dictionary<string, FieldProperty> _outputFields = new Dictionary<string, FieldProperty> { 
        { "lyrics", new FieldProperty { Boost = 10, Highlight = true } }, 
        { "title", new FieldProperty { Boost = 5, Highlight = true } }, 
        { "album", new FieldProperty { Boost = 3, Highlight = true } }, 
        { "artist", new FieldProperty { Boost = 2, Highlight = true } }, 
        { "file_path", new FieldProperty { Boost = 1, Highlight = false }},
        { "file_path_id", new FieldProperty{IsId=true}}};

        private string[] _facetFields = new[] { "artist_f", "extension_f", "letter_catalog_f" };
        private readonly string _query;
        private readonly string _filterField;
        private readonly string _filterValue;
        private readonly int _numRows;
        private readonly int _startRow;

        
        public string GetQueryString()
        {
            if (string.IsNullOrEmpty(_query))
                return null;
            return "q="+_query +"&rows="+_numRows +"&start="+_startRow
                +"&wt=json&indent=true&stopwords=true&lowercaseOperators=true&defType=edismax&fl=" 
                + string.Join("+",_outputFields.Keys) 
                + "&qf=" + string.Join("+", _outputFields.Where(o=>o.Value.Boost.HasValue).Select(o=>o.Key+"^"+o.Value.Boost))
                + "&hl=true&hl.simple.pre=<em>&hl.simple.post=<%2Fem>&hl.requireFieldMatch=false&hl.highlightMultiTerm=true&hl.fl=" + string.Join("+",_outputFields.Where(o=>o.Value.Highlight).Select(o=>o.Key))
                + "&facet=true&facet.mincount=1&facet.limit=-1&facet.missing=true&facet.field=" + string.Join("&facet.field=", _facetFields);
        }

        public string GetFilterString()
        {
            var temp=GetQueryString();
            if (string.IsNullOrEmpty(temp))
                return temp;
            if (!string.IsNullOrEmpty(_filterField)&&!string.IsNullOrEmpty(_filterValue))
                temp="fq="+_filterField+":\""+_filterValue+"\"&"+temp;
            return temp;
        }

    }
}
