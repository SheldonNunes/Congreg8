using System;
using Congreg8.Core.Api;

namespace Congreg8.Core.Services
{
    public class TokenService
    {
        private Token Token;

        Token GetCurrentToken(){
            return Token;
        }

        void SetCurrentToken(Token token)
        {
            Token = token;
        }
    }
}
