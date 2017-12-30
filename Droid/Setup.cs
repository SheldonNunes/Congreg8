using System;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Platform;

namespace Congreg8.Droid
{
    public class Setup : MvvmCross.Forms.Droid.Platform.MvxFormsAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.CoreApp();
        }

        protected override MvxFormsApplication CreateFormsApplication()
        {
            return new App();
        }
    }
}
