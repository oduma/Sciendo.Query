using NUnit.Framework;

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
            Assert.IsNotNull(result);
            Assert.True(result[0].lyrics.Contains("<em>"));
        }
    }
}
