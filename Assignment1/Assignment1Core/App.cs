using System;
using Assignment1Core.Services;
using Assignment1Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Assignment1Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            RegisterCustomAppStart<AppStart>();
            Mvx.IoCProvider.RegisterType<IListPageService, ListPageService>();
        }
    }
}
