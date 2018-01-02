using System;
using Congreg8.Api;
using Congreg8.Core.Services;
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

            Mvx.RegisterSingleton<IFacebookApi>(new MockFacebookApi());


            var tokenService = Mvx.Resolve<ITokenService>();
            var token = tokenService.GetCurrentToken();

            if (token == null || token.ExpirationDate < DateTime.Now)
            {
                RegisterNavigationServiceAppStart<ViewModels.SignInPageViewModel>();
            } else {
                RegisterNavigationServiceAppStart<ViewModels.Congreg8PageViewModel>();
            }
            
        }
    }
}
