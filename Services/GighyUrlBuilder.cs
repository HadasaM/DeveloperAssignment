using System;

namespace DeveloperAssignmentTrendingGIF.Services
{
    public class GighyUrlBuilder
    {
        protected const string GiphyEndPoint = "http://api.giphy.com/v1/gifs/";
        protected string ServiceUrl { get; set; }
        protected const string ApiKey = "eRIquN2g1W6ADO6VAgHzOY1wS5uvW6Su";//Move to config file
        protected const string Limit = "100";
        public virtual void Build()
        {


        }
        public string GetServiceURL()
        {
            return ServiceUrl;
        }
    }
}