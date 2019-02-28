using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Assignment1Core.ViewModels
{
    public class TestViewModel : MvxViewModel
    {
        public string TestText => "Welcome! Click the button to explore the list!";
        
        public IMvxAsyncCommand ViewCommand => new MvxAsyncCommand(async () => await ViewList());
        private readonly IMvxNavigationService _navigationService;

        public TestViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private async Task ViewList()
        {
            await _navigationService.Navigate<MainViewModel>();
        }
    }
}
