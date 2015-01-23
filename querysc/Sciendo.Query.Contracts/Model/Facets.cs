using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.Contracts.Model
{
    public class Facets
    {
        public object facet_queries { get; set; }

        public FacetFields facet_fields { get; set; }

        public object facet_dates { get; set; }

        public object facet_intervals { get; set; }

        public object facet_ranges { get; set; }
    }
}
