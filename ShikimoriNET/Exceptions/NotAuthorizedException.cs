using System;

namespace ShikimoriNET.Exceptions
{
    public class NotAuthorizedException : Exception
    {
        public NotAuthorizedException(string message) : base(message)
        {
        }
    }
}