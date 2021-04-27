using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeveloperAssignmentTrendingGIF.Models
{
    [JsonObject]
    public class GiphyResponse
    {
        [JsonProperty("data")]
        public Gif[] GigObjList { get; set; }


    }
    [JsonObject]
    public class Gif
    {
        [JsonProperty("type")]
        public string Type  { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("url")]
        public string URL { get; set; }

    }
}