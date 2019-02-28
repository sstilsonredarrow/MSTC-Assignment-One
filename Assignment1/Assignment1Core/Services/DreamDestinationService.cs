using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1Core.Models;

namespace Assignment1Core.Services
{
    public class DreamDestinationService : IDreamDestinationService
    {
        public DreamDestinationService()
        {
        }

        public async Task<List<DreamDestinationItem>> GetDreamDestinations()
        {
            var destination = GenerateDestination();
            return destination;
        }

        private List<DreamDestinationItem> GenerateDestination()
        {
            return new List<DreamDestinationItem>()
            {
                new DreamDestinationItem
                {
                    ItemName = "New Zealand",
                    Description = "The home of Middle Earth."
                },
                new DreamDestinationItem
                {
                    ItemName = "Spain",
                    Description = "The food is fantastic and I love the culture."
                },
                new DreamDestinationItem
                {
                    ItemName = "Hawaii",
                    Description = "Who wouldn't want to visit a tropical island?"
                },
                new DreamDestinationItem
                {
                    ItemName = "Ireland",
                    Description = "It looks beautiful and my family is from there."
                },
                new DreamDestinationItem
                {
                    ItemName = "Mexico",
                    Description = "It'd be cool to see it during Dia de los Muertos."
                }
            };
        }
    }
}
