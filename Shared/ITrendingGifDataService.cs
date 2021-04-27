using DeveloperAssignmentTrendingGIF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAssignmentTrendingGIF.Shared
{
    interface ITrendingGifDataService
    {
        Task<IList<TrendingGIF>> GetTrendingGIF();
        Task<IList<TrendingGIF>> SearchGIF(string userSearch);
    }
}
