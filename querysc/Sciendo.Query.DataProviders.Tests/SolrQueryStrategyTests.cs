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
            Assert.AreEqual("wt=json&indent=true&stopwords=true&lowercaseOperators=true&defType=edismax&fl=lyrics+title+album+artist+file_path+file_path_id&qf=lyrics^10+title^5+album^3+artist^2+file_path^1&hl=true&hl.simple.pre=<em>&hl.simple.post=<%2Fem>&hl.requireFieldMatch=true&hl.highlightMultiTerm=true&hl.fl=lyrics+title+album+artist&facet=true&facet.missing=true&facet.field=artist_f&facet.field=extension_f&facet.field=letter_catalog_f", solrStrategy.ToString());
        }
    }
}
