using System;
using Congreg8.Api;
using Congreg8.Tests.Api;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace Congreg8.Core
{
    public class CoreApp : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.RegisterSingleton<IFacebookApi>(new MockFacebookApi());;

            RegisterNavigationServiceAppStart<ViewModels.SignInPageViewModel>();
        }
    }
}
