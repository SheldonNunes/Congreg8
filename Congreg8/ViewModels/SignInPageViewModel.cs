using System;
using Congreg8.Core.Api;
using Congreg8.Core.Services;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace Congreg8.Core.ViewModels
{
    public class SignInPageViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        private IMvxCommand<SignInResponse> loginCompleted;
        public IMvxCommand<SignInResponse> LoginCompletedCommand
        {
            get { return loginCompleted; }
            set { 
                SetProperty(ref loginCompleted, value);
            }
        }

        public SignInPageViewModel(IMvxNavigationService navigationService, ITokenService tokenService)
        {
            this._navigationService = navigationService;

            LoginCompletedCommand = new MvxAsyncCommand<SignInResponse>(async (SignInResponse response) =>
            {
                if (response.SignInResult == null)
                    return;

                tokenService.SetCurrentToken(response.SignInResult.Token);
                await _navigationService.Navigate<Congreg8PageViewModel>();
            });
        }
    }
}
