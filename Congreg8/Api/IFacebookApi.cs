using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congreg8.Models;

namespace Congreg8.Api
{
    public interface IFacebookApi
    {
        List<UserTaggableFriends> GetUserTaggableFriends(string id, string token);
    }
}
