using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.Contracts.Model
{
    public class ResultsPackage
    {
        public Doc[] ResultRows { get; set; }
        public Field[] Fields { get; set; } 
    }
}
