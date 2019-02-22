using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Assignment1Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public string WelcomeText => "Welcome to Orion Olson's Assignment 1 Program!";
        public string ButtonText => "Check out this list of things!";
        public IMvxAsyncCommand DisplayListCommand => new MvxAsyncCommand(async () => await DisplayListClicked());
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navService)
        {
            _navigationService = navService;
        }

        private async Task DisplayListClicked()
        {
            await _navigationService.Navigate<ListViewModel>();
        }
    }
}
