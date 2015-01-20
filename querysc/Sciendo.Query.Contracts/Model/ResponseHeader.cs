using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.Contracts.Model
{
    public class ResponseHeader
    {
        public int status { get; set; }
        public int QTime { get; set; }
    }
}
