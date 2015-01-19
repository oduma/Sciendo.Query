using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sciendo.IOC;
using Sciendo.Query.Contracts;
using Sciendo.Query.DataProviders;

namespace Sciendo.Query
{
    public class IocConfig
    {
        public static void RegisterComponents(Container container)
        {
            container.Add(new RegisteredType().For<MockResultsProvider>().BasedOn<IResultsProvider>().IdentifiedBy("mockResultsProvider").With(LifeStyle.Transient));
            container.Add(new RegisteredType().For<SolrResultsProvider>().BasedOn<IResultsProvider>().IdentifiedBy("solrResultsProvider").With(LifeStyle.Transient));
        }
    }
}