using System;
using System.Collections.Generic;
using Congreg8.Core.Controls;
using Congreg8.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Forms.Views;
using Xamarin.Forms;

namespace Congreg8.Core.Views
{
    public partial class SignInPage : GradientPage<SignInPageViewModel>
    {
        public SignInPage()
        {
            InitializeComponent();
        }
    }
}
