using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.Contracts
{
    public interface IResultsProvider
    {
        ResultsPackage GetResultRows(string query);

    }
}