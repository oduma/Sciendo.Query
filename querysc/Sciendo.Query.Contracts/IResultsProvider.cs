using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.Contracts
{
    public interface IResultsProvider
    {
        ResultsPackage GetResultsPackage(string query, int numRow, int startRow);


        ResultsPackage GetFilteredResultsPackage(string criteria, int numRow, int startRow, string facetFieldName, string facetFieldValue);
    }
}