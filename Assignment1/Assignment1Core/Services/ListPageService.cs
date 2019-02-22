using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1Core.Models;

namespace Assignment1Core.Services
{
    public class ListPageService : IListPageService
    {
        public ListPageService()
        {
        }

        public async Task<List<ListItem>> GetListItems()
        {
            var listItems = GenerateList();
            return listItems;
        }

        private List<ListItem> GenerateList()
        {
            return new List<ListItem>()
            {
                new ListItem
                {
                    ItemName = "Complete the MainViewModel and related.",
                    ItemDescription = "Needs welcome text and a button to navigate."
                },
                new ListItem
                {
                    ItemName = "Complete the ListViewModel and related",
                    ItemDescription = "I'll need to call the list through a service too."
                },
                new ListItem
                {
                    ItemName = "Write a list of things",
                    ItemDescription = "There's gotta be something to display."
                },
                new ListItem
                {
                    ItemName = "Put it all together",
                    ItemDescription = "Make the MainPage's button link to the ListPage."
                }
            };
        }
    }
}
