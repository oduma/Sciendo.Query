using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.DataProviders.Solr
{
    public class SolrQueryStrategy
    {
        private Dictionary<string, int> _fieldsBoost = new Dictionary<string, int> { { "lyrics", 10 }, { "title", 5 }, { "album", 3 }, { "artist", 2 }, { "file_path", 1 } };
        
        public override string ToString()
        {

            return "wt=json&indent=true&defType=edismax&fl=" + string.Join("+",_fieldsBoost.Keys) + "&qf=" + string.Join("+", _fieldsBoost.Keys.Where(k=>_fieldsBoost[k]!=0).Select(k=>k+"^"+_fieldsBoost[k]));
        }
    }
}
