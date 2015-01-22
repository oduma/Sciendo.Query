using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.DataProviders.Solr
{
    public class FieldProperty
    {
        public int? Boost { get; set; }
        public bool Highlight { get; set; }
        public bool IsId { get; set; }
    }
}
