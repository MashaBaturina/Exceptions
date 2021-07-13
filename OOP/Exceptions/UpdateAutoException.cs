using System;

namespace Exceptions
{
    public class UpdateAutoException : Exception
    {
        public UpdateAutoException(string message) : base(message)
        {
        }
    }
}
