using System;
using System.Collections.Generic;

namespace Congreg8.Core.Api
{
    public class SignInResponse
    {

        public class Result
        {
            public string[] GrantedPermissions
            {
                get;
                set;
            }

            public Token Token
            {
                get;
                set;
            }
        }


        public SignInResponse.Result SignInResult
        {
            get;
            set;
        }
    }
}
