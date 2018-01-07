using System;
using System.Collections.Generic;
using Congreg8.Core.Api;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using Xamarin.Forms;

namespace Congreg8.Core.Services
{
    public class TokenService : ITokenService
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string AppID
        {
            get => AppSettings.GetValueOrDefault(nameof(AppID), null);
            set => AppSettings.AddOrUpdateValue(nameof(AppID), value);
        }

        public static DateTime ExpirationDate
        {
            get => AppSettings.GetValueOrDefault(nameof(ExpirationDate), DateTime.MaxValue);
            set => AppSettings.AddOrUpdateValue(nameof(ExpirationDate), value);
        }

        public static DateTime RefreshDate
        {
            get => AppSettings.GetValueOrDefault(nameof(RefreshDate), DateTime.MaxValue);
            set => AppSettings.AddOrUpdateValue(nameof(RefreshDate), value);
        }

        public static string TokenString
        {
            get => AppSettings.GetValueOrDefault(nameof(TokenString), null);
            set => AppSettings.AddOrUpdateValue(nameof(TokenString), value);
        }

        public static string UserId
        {
            get => AppSettings.GetValueOrDefault(nameof(UserId), null);
            set => AppSettings.AddOrUpdateValue(nameof(UserId), value);
        }


        private Token Token;

        public TokenService()
        {
            if(!String.IsNullOrWhiteSpace(TokenString) && ExpirationDate.ToUniversalTime() > DateTime.UtcNow)
                Token = new Token()
                {
                    AppID = AppID,
                    ExpirationDate = ExpirationDate,
                    RefreshDate = RefreshDate,
                    TokenString = TokenString,
                    UserId = UserId
                };
        }

        public Token GetCurrentToken(){
            return Token;
        }

        public void SetCurrentToken(Token token)
        {
            Token = token;

            AppID = Token.AppID;
            ExpirationDate = Token.ExpirationDate;
            RefreshDate = Token.RefreshDate;
            TokenString = Token.TokenString;
            UserId = Token.UserId;
        }

        private void RefreshToken(){
            
        }
    }
}
