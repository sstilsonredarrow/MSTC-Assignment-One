using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Assignment1Core.Models;
using Assignment1Core.Services;

namespace Assignment1Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public string WelcomeText { get; set; }
        public List<DreamDestinationItem> DestinationItems { get; set; }
        private IDreamDestinationService _destinationService;

        public MainViewModel(IDreamDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            DestinationItems = await _destinationService.GetDreamDestinations();
            await RaiseAllPropertiesChanged();
        }

        private async Task<List<DreamDestinationItem>> GetDreamDestinations()
        {
            return await _destinationService.GetDreamDestinations();
        }
    }
}
