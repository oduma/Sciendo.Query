using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.Contracts
{
    public interface IResultsProvider
    {
        ResultsPackage GetResultsPackage(string query);


        ResultsPackage GetFilteredResultsPackage(string criteria, string facetFieldName, string facetFieldValue);
    }
}