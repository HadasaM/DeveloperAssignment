using DeveloperAssignmentTrendingGIF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAssignmentTrendingGIF.Shared
{
    interface IGifDataService
    {
        Task<List<string>> GetTrendingGIF();
        Task<List<string>> SearchGIF(string userSearch);
    }
}
