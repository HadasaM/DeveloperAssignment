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
            query["api_key"] = ApiKey;//Move to config file
            query["limit"] = Limit;
            builder.Query = query.ToString();
            ServiceUrl =  builder.ToString();
        }       
    }


}