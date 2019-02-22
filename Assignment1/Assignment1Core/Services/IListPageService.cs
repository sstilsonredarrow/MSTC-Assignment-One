using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1Core.Models;

namespace Assignment1Core.Services
{
    public interface IListPageService
    {
        Task<List<ListItem>> GetListItems();
    }
}
