using DeveloperAssignmentTrendingGIF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace DeveloperAssignmentTrendingGIF.Services
{
    public class FetchURLDataServiceBase
    {

        protected async Task<List<string>> GetGifUrlDataFromGighy(GighyUrlBuilder builder)
        {
            List<string> UrlList = new List<string>();
            builder.Build();
            string Uri = builder.GetServiceURL(); 
            var giphyRes = new HttpClient().GetAsync(Uri);
            var res = await giphyRes.Result.Content.ReadAsStringAsync();
            var GiphyResponseObj = JsonConvert.DeserializeObject<GiphyResponse>(res) as GiphyResponse;
            foreach (var o in GiphyResponseObj.GigObjList)
                UrlList.Add(o.URL);
            return UrlList;
        }
        
    }
}