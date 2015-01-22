using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.Contracts.Model
{
    public class Highlighting
    {
        public string[] lyrics { get; set; }

        public string[] title { get; set; }

        public string[] album { get; set; }

        public string[] artist { get; set; }
    }
}
