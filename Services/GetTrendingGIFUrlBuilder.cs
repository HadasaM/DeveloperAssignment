using System;
using System.Web;

namespace DeveloperAssignmentTrendingGIF.Services
{
    public class TrendingGIFServiceUrlBuilder : GighyUrlBuilder
    {
        string TrendingEndPoint = GiphyEndPoint + "trending";
               
        public override void Build()
        {
            var builder = new UriBuilder(TrendingEndPoint);
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["api_key"] = "eRIquN2g1W6ADO6VAgHzOY1wS5uvW6Su";//Move to config file
            query["limit"] = "100";
            builder.Query = query.ToString();
            ServiceUrl =  builder.ToString();
        }       
    }


}