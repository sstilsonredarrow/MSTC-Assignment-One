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
        public List<ListItem> ListItems { get; set; }
        private IListPageService _listService;

        public ListViewModel(IListPageService listService)
        {
            _listService = listService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            ListItems = await _listService.GetListItems();
            await RaiseAllPropertiesChanged();
        }
    }
}
