using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.Contracts
{
    public interface IResultsProvider
    {
        ResultRow[] GetResultRows(string query);
    }
}