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

        public async Task <List<ListItem>> GetListItems()
        {
            var list = GenerateList();
            return list;
        }

        private List<ListItem> GenerateList()
        {
            return new List<ListItem>()
            {
                new ListItem
                {
                    ItemName = "The Big Lebowski",
                    ItemDescription = "Coen Brother's neo noir about mistaken identity, nihilists, and rugs that tie the room together"
                },
                 new ListItem
                {
                    ItemName = "The Thing",
                    ItemDescription = "John Carpenter's horror remake about a shapeshifting alien on the loose in an Antarctic research facility"
                },
                  new ListItem
                {
                    ItemName = "The Devil's Backbone",
                    ItemDescription = "Del Toro's ghost story set in an orphanage during the Spanish civil war"
                },
                   new ListItem
                {
                    ItemName = "Dr. Strangelove",
                    ItemDescription = "Kubrick's cold war comedy of mutually assured destruction"
                },
                    new ListItem
                {
                    ItemName = "Brazil",
                    ItemDescription = "Gilliam's love story of dystopian bureaucracy"
                }
            };
        }     
    }
}
