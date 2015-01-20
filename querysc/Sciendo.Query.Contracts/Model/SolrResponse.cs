using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.Contracts.Model
{
    public class SolrResponse
    {
        public ResponseHeader responseHeader { get; set; }

        public Response response { get; set; }
    }
}
