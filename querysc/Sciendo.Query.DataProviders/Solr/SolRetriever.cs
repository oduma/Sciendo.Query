using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.DataProviders.Solr
{
    public static class SolRetriever
    {
        //public static TrySendResponse TryQuery<T>(string url, string query, SolrQueryStrategy solrQueryStrategy)
        //{
        //    HttpClient httpClient = new HttpClient();
        //    using (var postTask = httpClient.PostAsJsonAsync<T>(new Uri(url), package)
        //        .ContinueWith((p) => p).Result)
        //    {
        //        if (postTask.Status != TaskStatus.RanToCompletion || !postTask.Result.IsSuccessStatusCode || postTask.Result.Content == null)
        //            return new TrySendResponse { Status = Status.NotIndexed };

        //        using (var readTask = postTask.Result.Content.ReadAsStringAsync().ContinueWith((r) => r).Result)
        //        {
        //            if (readTask.Status != TaskStatus.RanToCompletion || string.IsNullOrEmpty(readTask.Result))
        //                return new TrySendResponse { Status = Status.NotIndexed };
        //            var solrUpdateResponse = JsonConvert.DeserializeObject<SolrUpdateResponse>(readTask.Result);
        //            if (solrUpdateResponse.responseHeader.status != 0)
        //                return new TrySendResponse { Status = Status.NotIndexed, Time = solrUpdateResponse.responseHeader.QTime };
        //            return new TrySendResponse { Status = Status.Done, Time = solrUpdateResponse.responseHeader.QTime };

        //        }
        //    }

        //}

    }
}
