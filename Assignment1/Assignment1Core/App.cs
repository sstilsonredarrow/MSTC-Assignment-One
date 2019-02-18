using System;
using Assignment1Core.ViewModels;
using MvvmCross.ViewModels;

namespace Assignment1Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            RegisterCustomAppStart<AppStart>();
        }
    }
}
