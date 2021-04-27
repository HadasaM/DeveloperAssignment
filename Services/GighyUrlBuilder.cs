using System;

namespace DeveloperAssignmentTrendingGIF.Services
{
    public class GighyUrlBuilder
    {
        protected const string GiphyEndPoint = "http://api.giphy.com/v1/gifs/";
        protected string ServiceUrl { get; set; }
        public virtual void Build()
        {


        }
        public string GetServiceURL()
        {
            return ServiceUrl;
        }
    }
}