using System;
using System.Collections.Generic;
using Assignment1Core.Models;

namespace Assignment1Core.Services
{
    public interface IListService
    {
        List<Foods> GetFoods();
    }
}
