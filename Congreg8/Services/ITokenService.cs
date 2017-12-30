using System;
using Congreg8.Core.Api;

namespace Congreg8.Core.Services
{
    public interface ITokenService
    {
        Token GetCurrentToken();

        void SetCurrentToken(Token token);
    }
}
