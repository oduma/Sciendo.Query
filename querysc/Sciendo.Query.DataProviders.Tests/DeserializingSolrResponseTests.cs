using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.DataProviders.Tests
{
    [TestFixture]
    public class DeserializingSolrResponseTests
    {
        [Test]
        public void Deseralizing_Ok()
        {
            var resultsProvider = new MockResultsProvider();
            var result = resultsProvider.GetResultRows("some query");
        }
    }
}
