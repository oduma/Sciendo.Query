using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Sciendo.Query.DataProviders.Solr
{
    public static class SolRetriever
    {
        public static SolrResponse TryQuery(string url, Func<string> queryStringProvider)
        {
            var httpClient = new HttpClient();
            using (var getTask = httpClient.GetStringAsync(new Uri(url+"?" +queryStringProvider()))
                .ContinueWith(p => p).Result)
            {
                if (getTask.Status == TaskStatus.RanToCompletion || !string.IsNullOrEmpty(getTask.Result))
                {
                    return JsonConvert.DeserializeObject<SolrResponse>(getTask.Result);
                }
                return null;
            }

        }

    }
}
