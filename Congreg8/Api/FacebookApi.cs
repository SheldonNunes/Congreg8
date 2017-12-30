using System;
using System.Collections.Generic;
using Congreg8.Models;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Congreg8.Core.Api;

namespace Congreg8.Api
{
    public class FacebookApi : BaseApi, IFacebookApi
    {
        public Token token;

        private readonly string Uri = BaseURI + "{0}/taggable_friends?access_token={1}";

        public List<UserTaggableFriends> GetUserTaggableFriends(string id, string token)
        {
            var request = WebRequest.Create(string.Format(Uri, id, token));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    var content = reader.ReadToEnd();
                    if (string.IsNullOrWhiteSpace(content))
                    {
                        Console.Out.WriteLine("Response contained empty body...");
                    }
                    else
                    {
                        var friends = JsonConvert.DeserializeObject<UserTaggableFriendsResponse>(content);

                    }

                }
            }


            return new List<UserTaggableFriends>();
        }
    }
}
