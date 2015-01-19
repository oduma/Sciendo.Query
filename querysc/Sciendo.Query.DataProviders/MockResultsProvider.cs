using Sciendo.Query.Contracts;
using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.DataProviders
{
    public class MockResultsProvider : IResultsProvider
    {
        public ResultRow[] GetResultRows(string query)
        {
            return new ResultRow[]
            {
                new ResultRow
                {
                    album = "1album",
                    artist = "1artist",
                    filePath = "1filePath",
                    lyrics = "1lyrics",
                    title = "1title"
                },
                new ResultRow
                {
                    album = "2album",
                    artist = "2artist",
                    filePath = "2filePath",
                    lyrics = "2lyrics",
                    title = "2title"
                },
                new ResultRow
                {
                    album = "1album",
                    artist = "1artist",
                    filePath = "1filePath",
                    lyrics = "1lyrics",
                    title = "1title"
                },
                new ResultRow
                {
                    album = "2album",
                    artist = "2artist",
                    filePath = "2filePath",
                    lyrics = "2lyrics",
                    title = "2title"
                },
                new ResultRow
                {
                    album = "1album",
                    artist = "1artist",
                    filePath = "1filePath",
                    lyrics = "1lyrics",
                    title = "1title"
                },
                new ResultRow
                {
                    album = "2album",
                    artist = "2artist",
                    filePath = "2filePath",
                    lyrics = "2lyrics",
                    title = "2title"
                }


            };
        }
    }
}