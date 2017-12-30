using System.Collections.Generic;
using Congreg8.Core.Api;
using Congreg8.Core.Controls;
using Congreg8.iOS.Renderers;
using Facebook.LoginKit;
using Foundation;
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
            //base.OnElementChanged(button);
            if (base.Control == null)
            {
                var loginButton = new LoginButton()
                {
                    LoginBehavior = LoginBehavior.Native,
                    ReadPermissions = readPermissions.ToArray(),
                };
                SetNativeControl(loginButton);

                FacebookButton el = (FacebookButton)this.Element;
                loginButton.Completed += (sender, e) =>
                {
                    var response = new SignInResponse()
                    {
                        SignInResult = new SignInResponse.Result()
                        {
                            Token = new Token()
                            {
                                AppID = e.Result.Token.AppID,
                                ExpirationDate = (System.DateTime)e.Result.Token.ExpirationDate,
                                TokenString = e.Result.Token.TokenString,
                                UserId = e.Result.Token.UserID,
                                RefreshDate = (System.DateTime)e.Result.Token.RefreshDate

                            }
                        }
                    };

                    el.OnFacebookLoginCompleted(sender, response);
                }; 
            }
        }
    }
}
