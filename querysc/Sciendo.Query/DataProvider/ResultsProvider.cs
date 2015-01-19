using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sciendo.Query.Models;

namespace Sciendo.Query.DataProvider
{
    public class ResultsProvider
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