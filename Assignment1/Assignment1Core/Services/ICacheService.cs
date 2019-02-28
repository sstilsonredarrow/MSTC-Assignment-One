using System;
using System.Threading.Tasks;

namespace Assignment1Core.Services
{
    public interface ICacheService
    {
        Task<bool> Store(object obj);
        Task<object> Get(string key);
    }
}
