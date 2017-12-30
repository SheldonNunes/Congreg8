using System;
using Congreg8.Core.Api;
using MvvmCross.Core.ViewModels;
using Xamarin.Forms;

namespace Congreg8.Core.Controls
{
    public class FacebookButton : Button
    {
        private IMvxCommand<SignInResponse> loginCompleted;
        public IMvxCommand<SignInResponse> LoginCompleted
        {
            get { return loginCompleted; }
            set { loginCompleted = value; }
        }

        public static BindableProperty LoginCompletedProperty = BindableProperty.Create(
            propertyName: "LoginCompleted",
            returnType: typeof(IMvxCommand<SignInResponse>),
            declaringType: typeof(FacebookButton),
            defaultValue: default(IMvxCommand),
            propertyChanged: LoginCompletedPropertyChanged);

        private static void LoginCompletedPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (FacebookButton)bindable;
            control.LoginCompleted = (IMvxCommand<SignInResponse>)newValue;
        }

        public void OnFacebookLoginCompleted(object sender, SignInResponse e)
        {
            LoginCompleted.Execute(e);
        }

        public FacebookButton()
        {
        }
    }
}
