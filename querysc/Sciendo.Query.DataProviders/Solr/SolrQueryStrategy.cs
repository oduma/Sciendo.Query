using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.DataProviders.Solr
{
    public class SolrQueryStrategy
    {
        private Dictionary<string, FieldProperty> _outputFields = new Dictionary<string, FieldProperty> { 
        { "lyrics", new FieldProperty { Boost = 10, Highlight = true } }, 
        { "title", new FieldProperty { Boost = 5, Highlight = true } }, 
        { "album", new FieldProperty { Boost = 3, Highlight = true } }, 
        { "artist", new FieldProperty { Boost = 2, Highlight = true } }, 
        { "file_path", new FieldProperty { Boost = 1, Highlight = false }},
        { "file_path_id", new FieldProperty{IsId=true}}};

        private string[] facetFields= new []{}
        
        public override string ToString()
        {
            return "wt=json&indent=true&stopwords=true&lowercaseOperators=true&defType=edismax&fl=" 
                + string.Join("+",_outputFields.Keys) 
                + "&qf=" + string.Join("+", _outputFields.Where(o=>o.Value.Boost.HasValue).Select(o=>o.Key+"^"+o.Value.Boost))
                + "&hl=true&hl.simple.pre=<em>&hl.simple.post=<%2Fem>&hl.requireFieldMatch=true&hl.highlightMultiTerm=true&hl.fl=" + string.Join("+",_outputFields.Where(o=>o.Value.Highlight).Select(o=>o.Key));
        }
    }
}
