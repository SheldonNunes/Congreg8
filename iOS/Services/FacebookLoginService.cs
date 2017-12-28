using System;
using Facebook.LoginKit;
using Foundation;
using Congreg8.Api;

namespace Congreg8.iOS.Services
{
    public class FacebookLoginService : LoginButtonDelegate
    {
        public override void DidComplete(LoginButton loginButton, LoginManagerLoginResult result, NSError error)
        {
            if (error == null)
            {
                if (!result.IsCancelled)
                {
                    Facebook.CoreKit.GraphRequest request = new Facebook.CoreKit.GraphRequest("/" + result.Token.UserID + "/taggable_friends", null, "GET");

                    var facebookApi = new FacebookApi();
                    var test = facebookApi.GetUserTaggableFriends(result.Token.UserID, result.Token.TokenString);
                    //request.Start(HandleGraphRequestHandler);
                }
            }
        }

        public override void DidLogOut(LoginButton loginButton)
        {
            throw new NotImplementedException();
        }

        void HandleGraphRequestHandler(Facebook.CoreKit.GraphRequestConnection connection, NSObject result, NSError error)
        {
            var test = "hello";
        }
    }
}
