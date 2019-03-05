using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Assignment1Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public string WelcomeText => "Welcome to Tegan's Assignment 1";
        public IMvxAsyncCommand DisplayListCommand => new MvxAsyncCommand(async () => await DisplayListClicked());
        private readonly IMvxNavigationService _navigationService;

        private async Task DisplayListClicked()
        {
            await _navigationService.Navigate<ListViewModel>();
        }

        public MainViewModel(IMvxNavigationService navService)
        {
            _navigationService = navService;
        }
    }
}
