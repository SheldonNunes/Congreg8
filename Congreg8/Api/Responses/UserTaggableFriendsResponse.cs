using System;
using System.Collections.Generic;
using Congreg8.Models;

namespace Congreg8.Api
{
    public class UserTaggableFriendsResponse
    {
        public List<UserTaggableFriend> Data
        {
            get;
            set;
        }

        public Paging Paging
        {
            get;
            set;
        }
    }
}
