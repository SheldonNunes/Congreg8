using System;
using System.Collections.Generic;
using System.IO;
using Congreg8.Api;
using Congreg8.Models;
using Newtonsoft.Json;

namespace Congreg8.Tests.Api
{
    public class MockFacebookApi : IFacebookApi
    {
        public List<UserTaggableFriend> GetUserTaggableFriends(string id, string token){
            using (StreamReader r = new StreamReader("MockFacebookFriendsResponse.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<UserTaggableFriendsResponse>(json);
                return items.Data;
            }

        }
    }

}
