﻿using System;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Assignment1Core.ViewModels;

namespace Assignment1Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication application, 
            IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<TestViewModel>();
        }
    }
}
