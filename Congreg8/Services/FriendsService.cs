using System;
using System.Collections.Generic;
using Congreg8.Api;
using Congreg8.Models;

namespace Congreg8.Services
{
    public class FriendsService
    {
        private readonly IFacebookApi facebookApi;

        public FriendsService(IFacebookApi facebookApi)
        {
            this.facebookApi = facebookApi;

        }

        //public List<UserTaggableFriends> GetUserFriends(){
        //    var friends = facebookApi.GetUserTaggableFriends();
        //    return friends;
        //}
    }
}
