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
        // GET: api/TrendingGift
        public HttpResponseMessage GetTrendingGIF()
        {
            try
            {
                ITrendingGifDataService trendingGif = new FetchURLDataService();
                var result = trendingGif.GetTrendingGIF();
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        public HttpResponseMessage SearchGIF(string searchParameter)
        {
            try
            {
                ITrendingGifDataService trendingGif = new FetchURLDataService();
                var result = trendingGif.SearchGIF(searchParameter).Result;
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


    }
}
