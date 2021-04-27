using System;
using System.Runtime.Serialization;

namespace GoatlyCore.Exceptions
{
    public class WebGoatModelException : AbstractWebGoatException
    {
        public WebGoatModelException()
        {
        }

        public WebGoatModelException(string? message) : base(message)
        {
        }

        public WebGoatModelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public WebGoatModelException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}