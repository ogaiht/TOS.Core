using System;

namespace TOS.Common.Utils
{
    public class ExceptionHelper : IExceptionHelper
    {
        public void CheckArgumentNullException(object param, string paramName)
        {
            if (param == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public void CheckInvalidOperationException(bool passesCheck, string message)
        {
            if (!passesCheck)
            {
                throw new InvalidOperationException(message);
            }
        }

        public void CheckArgumentException(bool passesCheck, string message, string parameterName)
        {
            if (!passesCheck)
            {
                throw new ArgumentException(message, parameterName);
            }
        }
    }
}
