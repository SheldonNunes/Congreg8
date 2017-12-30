using System;
namespace Congreg8.Core.Api
{
    public class Token
    {
        public string AppID
        {
            get;
            set;
        }

        public DateTime ExpirationDate
        {
            get;
            set;
        }

        public DateTime RefreshDate
        {
            get;
            set;
        }

        public string TokenString
        {
            get;
            set;
        }

        public string UserId
        {
            get;
            set;
        }
    }
}
