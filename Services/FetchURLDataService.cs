using DeveloperAssignmentTrendingGIF.Models;
using DeveloperAssignmentTrendingGIF.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace DeveloperAssignmentTrendingGIF.Services
{
    public class FetchURLDataService : FetchURLDataServiceBase, IGifDataService
    {

        public async Task<List<string>> GetTrendingGIF()
        {
            try
            {
                GighyUrlBuilder builder = new TrendingGIFServiceUrlBuilder();
                return await GetGifUrlDataFromGighy(builder);        
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async Task<List<string>> SearchGIF(string userRequestedCriteria)
        {
            try
            {
                GighyUrlBuilder builder = new SearchGIFServiceUrlBuilder(userRequestedCriteria);
                return await GetGifUrlDataFromGighy(builder);
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}

