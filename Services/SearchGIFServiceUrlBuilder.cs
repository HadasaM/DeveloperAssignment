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
            query["api_key"] = "eRIquN2g1W6ADO6VAgHzOY1wS5uvW6Su";//Take from config
            query["limit"] = "2";
            if (searchParam != null)
                query["q"] = searchParam;
            builder.Query = query.ToString();
            ServiceUrl = builder.ToString();
        }
       
    }
}