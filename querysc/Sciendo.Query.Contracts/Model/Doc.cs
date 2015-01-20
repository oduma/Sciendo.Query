using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.Contracts.Model
{
    public class Doc
    {
        public string filePath { get; set; }
        public string artist { get; set; }
        public string album { get; set; }
        public string title { get; set; }
        public string lyrics { get; set; }

    }
}
