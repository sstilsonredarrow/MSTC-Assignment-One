using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1Core.Models;

namespace Assignment1Core.Services
{
    public class CacheService : ICacheService
    {
        public CacheService()
        {
        }

        public Task<bool> Store(object obj)
        {
            try
            {
                if (obj is List<DreamDestinationItem>)
                {
                    BlobCache.Secure.InsertObject("MainMenu", obj);
                    return Task.FromResult(true);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return Task.FromResult(false);
            }
            return Task.FromResult(false);
        }
    }
}
