using System;
using Congreg8.Core.Services;
using UIKit;

namespace Congreg8.iOS.Services
{
    public class CrossAppNavigator : ICrossAppNavigator
    {
        public CrossAppNavigator()
        {
        }

        public void NavigateToLink(string url)
        {
            UIApplication.SharedApplication.OpenUrl(new Foundation.NSUrl(url));
        }
    }
}
