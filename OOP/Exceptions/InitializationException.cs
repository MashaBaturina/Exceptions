using System;

namespace Exceptions
{
    public class InitializationException : Exception
    {
        public InitializationException(string message) : base(message)
        {
        }
    }
}
