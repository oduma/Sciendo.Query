using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.Contracts.Model
{
    public class FacetFields
    {
        public Dictionary<string, int> artist_f { get; set; }

        public Dictionary<string, int> extension_f { get; set; }

        public Dictionary<string, int> letter_catalog_f { get; set; }
    }
}
