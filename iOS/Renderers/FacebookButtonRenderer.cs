using System.Collections.Generic;
using Congreg8.Controls;
using Congreg8.iOS.Renderers;
using Congreg8.iOS.Services;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FacebookButton), typeof(FacebookButtonRenderer))]
namespace Congreg8.iOS.Renderers
{
    public class FacebookButtonRenderer : ButtonRenderer
	{
        List<string> readPermissions = new List<string> { "public_profile", "user_friends" };

        protected override void OnElementChanged(ElementChangedEventArgs<Button> button)
		{
			//base.OnElementChanged(e);

            if(base.Control == null){
                var loginButton = new Facebook.LoginKit.LoginButton()
                {
                    LoginBehavior = Facebook.LoginKit.LoginBehavior.Native,
                    ReadPermissions = readPermissions.ToArray(),
                    Delegate = new FacebookLoginService(),
                };
                SetNativeControl(loginButton);

                //loginButton.Completed += (sender, e) => {
                //    if (e.Error != null)
                //    {
                //        // Handle if there was an error
                //    }

                //    if (e.Result.IsCancelled)
                //    {
                //        // Handle if the user cancelled the login request
                //    }

                //    loginButton.

                //    // Handle your successful login
                //};
			}

		}
	}
}
