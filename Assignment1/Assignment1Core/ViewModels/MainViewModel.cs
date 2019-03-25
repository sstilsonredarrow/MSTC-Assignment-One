using System;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Assignment1Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public string WelcomeText => "Welcome!";
        private readonly IMvxNavigationService _navigationService;
        public IMvxAsyncCommand ButtonPress => new MvxAsyncCommand(async () => await Clicked());

        public MainViewModel(IMvxNavigationService Service)
        {
            _navigationService = Service;
        }

        private async Task Clicked()
        {
            await _navigationService.Navigate<ListViewModel>();
        }
    }
}
