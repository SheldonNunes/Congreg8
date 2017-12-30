using System;
using Congreg8.Core.Api;
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

        private string helloWorld;
        public string HelloWorld
        {
            get { return helloWorld; }
            set { SetProperty(ref helloWorld, value); } 
        }


        public SignInPageViewModel(IMvxNavigationService navigationService)
        {
            this._navigationService = navigationService;

            LoginCompletedCommand = new MvxAsyncCommand<SignInResponse>(async (SignInResponse response) =>
            {
                if (response.SignInResult == null)
                    return;

                await _navigationService.Navigate<Congreg8PageViewModel>();
            });

            HelloWorld = " test";
        }
    }
}
