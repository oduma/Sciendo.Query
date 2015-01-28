using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.Contracts.Model
{
    public class PageInfo
    {
        public int TotalRows { get; set; }

        public int RowsPerPage { get; set; }

        public int PageStartRow { get; set; }
    }
}
