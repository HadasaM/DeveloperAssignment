using DeveloperAssignmentTrendingGIF.Infra;
using DeveloperAssignmentTrendingGIF.Models;
using DeveloperAssignmentTrendingGIF.Services;
using DeveloperAssignmentTrendingGIF.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace DeveloperAssignmentTrendingGIF.Controllers
{
    public class TrendingGiftController : ApiController
    {
        [HttpGet]
        [Route("TrendingGift")]
        [CacheFilter(TimeDuration = 86400)]
        public HttpResponseMessage GetTrendingGIF()
        {
            try
            {
                IGifDataService trendingGif = new FetchURLDataService();
                var task = trendingGif.GetTrendingGIF();
                return Request.CreateResponse(HttpStatusCode.OK, task.Result);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("TrendingGift/{searchParam}")]
        [CacheFilter(TimeDuration = 100)]
        public HttpResponseMessage SearchGIF(string searchParam)
        {
            try
            {
                IGifDataService trendingGif = new FetchURLDataService();
                var task = trendingGif.SearchGIF(searchParam).Result;
                return Request.CreateResponse(HttpStatusCode.OK, task);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


    }
}
