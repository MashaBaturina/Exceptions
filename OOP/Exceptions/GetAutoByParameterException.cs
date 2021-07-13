using System;

namespace Exceptions
{
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException(string message) : base(message)     
        {
        }
    }
}
