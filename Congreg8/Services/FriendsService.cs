using System;
using System.Collections.Generic;
using Congreg8.Api;
using Congreg8.Core.Services;
using Congreg8.Models;

namespace Congreg8.Services
{
    public class FriendsService : IFriendsService
    {
        private readonly IFacebookApi facebookApi;

        public FriendsService(IFacebookApi facebookApi)
        {
            this.facebookApi = facebookApi;

        }

        public List<UserTaggableFriend> GetUserFriends(string userId, string token){
            var friends = facebookApi.GetUserTaggableFriends(userId, token);
            return friends;
        }
    }
}
