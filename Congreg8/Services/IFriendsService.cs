using System;
using System.Collections.Generic;
using Congreg8.Models;

namespace Congreg8.Core.Services
{
    public interface IFriendsService
    {
        List<UserTaggableFriend> GetUserFriends(string userId, string token);
    }
}
