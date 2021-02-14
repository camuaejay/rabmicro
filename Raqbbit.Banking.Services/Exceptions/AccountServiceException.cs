namespace Rabbit.Banking.Services.Exceptions
{
    using System;

    public class AccountServiceException : Exception
    {
        public AccountServiceException(string message, Exception innerException) 
            : base(string.Empty, innerException)
        {
        }
    }
}
