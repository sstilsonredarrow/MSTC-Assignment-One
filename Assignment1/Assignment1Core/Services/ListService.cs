using System;
using System.Collections.Generic;
using Assignment1Core.Models;

namespace Assignment1Core.Services
{
    public class ListService : IListService
    {
        public ListService()
        {
        }

        public List<Pastime> GetPastimes()
        {
            List<Pastime> pastimes = GenerateList();
            return pastimes;
        }

        private List<Pastime> GenerateList()
        {
            return new List<Pastime>()
            {
                new Pastime
                {
                    Name = "Ultimate Frisbee",
                    Description = "Get the frisbee across the field"
                },
                new Pastime
                {
                    Name = "Curling",
                    Description = "A winter sport of sliding rocks onto a target"
                },
                new Pastime
                {
                    Name = "Gaming",
                    Description = "Videos games, mostly on Xbox"
                },
                new Pastime
                {
                    Name = "Hiking",
                    Description = "Just walking, but longer"
                }
            };
        }
    }
}
