using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1Core.Models;

namespace Assignment1Core.Services
{
    public interface IDreamDestinationService
    {
        Task<List<DreamDestinationItem>> GetDreamDestinations();
    }
}
