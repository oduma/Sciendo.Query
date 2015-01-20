using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Sciendo.Query.Contracts.Model
{
    public class Response
    {
        public int numFound { get; set; }

        public int start { get; set; }

        public Doc[] docs { get; set; }
    }
}
