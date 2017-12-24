using Facebook.CoreKit;
using Foundation;
using UIKit;

namespace Congreg8.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
		string appId = "1808820906077918";
		string appName = "Congreg8";

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

			Profile.EnableUpdatesOnAccessTokenChange(true);
			Settings.AppID = appId;
			Settings.DisplayName = appName;

            return base.FinishedLaunching(app, options);//ApplicationDelegate.SharedInstance.FinishedLaunching(app, options);
        }

		public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			return ApplicationDelegate.SharedInstance.OpenUrl(application, url, sourceApplication, annotation);
		}


		public override void OnActivated(UIApplication uiApplication)
        {
            base.OnActivated(uiApplication);
            AppEvents.ActivateApp();
        }
    }
}
