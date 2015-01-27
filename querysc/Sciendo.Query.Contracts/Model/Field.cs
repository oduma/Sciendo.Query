using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sciendo.Query.Contracts.Model
{
    public class Field
    {
        public string Name { get; set; }

        public FieldValue[] Values { get; set; }
    }
}
