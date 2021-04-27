using DeveloperAssignmentTrendingGIF.Models;
using DeveloperAssignmentTrendingGIF.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace DeveloperAssignmentTrendingGIF.Services
{
    public class FetchURLDataService : ITrendingGifDataService
    {
        private const string GiphyEndPoint = "http://api.giphy.com/v1/gifs/";
        private const string apiKey = "";

        public async Task<IList<TrendingGIF>> GetTrendingGIF()
        {

            string TrendingEndPoint = GiphyEndPoint + "trending";
            List<TrendingGIF> TrendingGIFList = new List<TrendingGIF>();

            try
            {
                var giphyRes = await new HttpClient().GetAsync(TrendingEndPoint);
                var giphyContent = await giphyRes.Content.ReadAsStringAsync();
                //DeSerialization to Giphy response
                // Do forEach on GIF Object[] and build TrendingGIF.GiftUrl with profile_url:
                //TrendingGIFList.Add(new TrendingGIF { GifUrl = giphyContent });

            }
            catch (Exception e)
            {

            }
           
                     
            return null;
        }

        public async Task<IList<TrendingGIF>> SearchGIF(string userSearch)
        {

            string TrendingEndPoint = GiphyEndPoint + "search?q=" + userSearch + "&api_key=" + apiKey;
            List<TrendingGIF> TrendingGIFList = new List<TrendingGIF>();

            try
            {
                var giphyRes = await new HttpClient().GetAsync(TrendingEndPoint);
                //DeSerialization to Giphy response
                // Do forEach on GIF Object[] and build TrendingGIF.GiftUrl with profile_url:
                //TrendingGIFList.Add(new TrendingGIF { GifUrl = giphyContent });

            }
            catch (Exception e)
            {

            }


            return null;
        }
    }


}