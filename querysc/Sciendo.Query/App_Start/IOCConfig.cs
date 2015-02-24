using Sciendo.IOC;
using Sciendo.Query.Contracts;
using Sciendo.Query.DataProviders.Player;
using Sciendo.Query.DataProviders.Player.Mocks;
using Sciendo.Query.DataProviders.Solr;
using Sciendo.Query.DataProviders.Solr.Mocks;

namespace Sciendo.Query
{
    public class IocConfig
    {
        public static void RegisterComponents(Container container)
        {
            container.Add(new RegisteredType().For<MockResultsProvider>().BasedOn<IResultsProvider>().IdentifiedBy("mockResultsProvider").With(LifeStyle.Transient));
            container.Add(new RegisteredType().For<SolrResultsProvider>().BasedOn<IResultsProvider>().IdentifiedBy("solrResultsProvider").With(LifeStyle.Transient));
            container.Add(new RegisteredType().For<MockPlayerProcess>().BasedOn<IPlayerProcess>().IdentifiedBy("mockProcess").With(LifeStyle.Transient));
            container.Add(new RegisteredType().For<ClementinePlayerProcess>().BasedOn<IPlayerProcess>().IdentifiedBy("clementineProcess").With(LifeStyle.Transient));
        }
    }
}