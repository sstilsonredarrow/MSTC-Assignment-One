using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1Core.Models;
using Assignment1Core.Services;
using MvvmCross.ViewModels;

namespace Assignment1Core.ViewModels
{
    public class ListViewModel : MvxViewModel
    {
        public List<Foods> Foods { get; set; }
        public IListService _listService { get; set; }

        public ListViewModel(IListService listService)
        {
            _listService = listService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            Foods = _listService.GetFoods();
            await RaiseAllPropertiesChanged();
        }
    }
}
