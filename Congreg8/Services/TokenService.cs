using System;
using Congreg8.Core.Api;

namespace Congreg8.Core.Services
{
    public class TokenService : ITokenService
    {
        private Token Token;

        public Token GetCurrentToken(){
            return Token;
        }

        public void SetCurrentToken(Token token)
        {
            Token = token;
        }
    }
}
