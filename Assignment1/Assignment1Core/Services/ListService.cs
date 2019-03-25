using System;
using System.Collections.Generic;
using Assignment1Core.Models;

namespace Assignment1Core.Services
{
    public class ListService : IListService
    {
        public List<Foods> GetFoods()
        {
            return new List<Foods>()
            {
                new Foods
                {
                    Name = "Pizza",
                    Description = "Flatbread with sauce, cheese, and a variety of other toppings"
                },
                new Foods
                {
                    Name = "Sandwich",
                    Description = "Food typically consisting of vegetables, sliced cheese or meat, placed on or between slices of bread"
                },
                new Foods
                {
                    Name = "Ramen",
                    Description = "A Japanese dish that consists of Chinese-style wheat noodles served in a meat or (occasionally) fish-based broth"
                },
                new Foods
                {
                    Name = "Donut",
                    Description = "Dough fried in oil usually in the shape of a circle"
                },
                new Foods
                {
                    Name = "Hamburger",
                    Description = "sandwich consisting of one or more cooked patties of ground meat, usually beef, placed inside a sliced bread roll or bun"
                }
            };
        }
    }
}
