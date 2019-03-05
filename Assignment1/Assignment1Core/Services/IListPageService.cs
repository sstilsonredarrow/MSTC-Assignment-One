using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Assignment1Core.Models;

namespace Assignment1Core.Services
{
    public interface IListPageService
    {
        Task <List<ListItem>> GetListItems();
    }
}
