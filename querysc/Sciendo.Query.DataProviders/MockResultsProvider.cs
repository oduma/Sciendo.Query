using Sciendo.Query.Contracts;
using Sciendo.Query.Contracts.Model;

namespace Sciendo.Query.DataProviders
{
    public class MockResultsProvider : IResultsProvider
    {
        public Doc[] GetResultRows(string query)
        {
            return new Doc[]
            {
                new Doc
                {
                    album = "1album",
                    artist = "1artist",
                    filePath = "1filePath",
                    lyrics = "1lyrics",
                    title = "1title"
                },
                new Doc
                {
                    album = "2album",
                    artist = "2artist",
                    filePath = "2filePath",
                    lyrics = "2lyrics",
                    title = "2title"
                },
                new Doc
                {
                    album = "1album",
                    artist = "1artist",
                    filePath = "1filePath",
                    lyrics = "1lyrics",
                    title = "1title"
                },
                new Doc
                {
                    album = "2album",
                    artist = "2artist",
                    filePath = "2filePath",
                    lyrics = "2lyrics",
                    title = "2title"
                },
                new Doc
                {
                    album = "1album",
                    artist = "1artist",
                    filePath = "1filePath",
                    lyrics = "1lyrics",
                    title = "1title"
                },
                new Doc
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