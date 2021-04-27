using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeveloperAssignmentTrendingGIF.Services
{
    public class SearchGIFServiceUrlBuilder : GighyUrlBuilder
    {
        private const string searchGifEndPoint = GiphyEndPoint + "search";
        private readonly string searchParam;

        public SearchGIFServiceUrlBuilder(string searchParameter)
        {
            searchParam = searchParameter;
        }

         public override void Build()
        {
            var builder = new UriBuilder(searchGifEndPoint);
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["api_key"] = ApiKey;//Move to config file
            query["limit"] = Limit;
            if (searchParam != null)
                query["q"] = searchParam;
            builder.Query = query.ToString();
            ServiceUrl = builder.ToString();
        }
       
    }
}