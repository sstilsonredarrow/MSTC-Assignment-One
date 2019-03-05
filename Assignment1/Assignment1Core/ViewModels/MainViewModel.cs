using System;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Assignment1Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public string WelcomeText { get; set; }
        private readonly IMvxNavigationService _navigationService;
        public IMvxAsyncCommand PushButton => new MvxAsyncCommand(async () => await ListClicked());

        public MainViewModel(IMvxNavigationService navService)
        {
            WelcomeText = "Hello There!";
            _navigationService = navService;
        }

        private async Task ListClicked()
        {
           await _navigationService.Navigate<ListViewModel>();
        }
    }
}
