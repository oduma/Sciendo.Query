using NUnit.Framework;
using System.Linq;

namespace Sciendo.Query.DataProviders.Tests
{
    [TestFixture]
    public class DeserializingSolrResponseTests
    {
        [Test]
        public void Deseralizing_Ok()
        {
            var resultsProvider = new MockResultsProvider();
            var result = resultsProvider.GetResultsPackage("some query");
            Assert.IsNotNull(result);
            Assert.True(result.ResultRows[0].lyrics.Contains("<em>"));
            Assert.AreEqual(3, result.Fields.Length);
            Assert.True(result.Fields[0].Values.Any());
            Assert.True(result.Fields[1].Values.Any());
            Assert.True(result.Fields[2].Values.Any());
        }
    }
}
