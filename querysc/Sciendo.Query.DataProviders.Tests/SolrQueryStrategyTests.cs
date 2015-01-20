using NUnit.Framework;
using Sciendo.Query.DataProviders.Solr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.DataProviders.Tests
{
    [TestFixture]
    public class SolrQueryStrategyTests
    {
        [Test]
        public void SolrStrategy_ok()
        {
            SolrQueryStrategy solrStrategy = new SolrQueryStrategy();
            Assert.AreEqual("wt=json&indent=true&defType=edismax&qf=lyrics^10+title^5+album^3+artist^2+file_path^1", solrStrategy.ToString());
        }
    }
}
