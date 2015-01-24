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
            Assert.AreEqual(3, result.FacetFields.Keys.Count);
            Assert.True(result.FacetFields["Artists"].Keys.Any());
            Assert.True(result.FacetFields["Extensions"].Keys.Any());
            Assert.True(result.FacetFields["Letters"].Keys.Any());
        }
    }
}
