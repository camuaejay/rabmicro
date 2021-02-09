namespace Rabbit.Banking.Data.Exceptions
{
    using System;

    public class AccountDataException : Exception
    {
        public AccountDataException(string message, Exception innerException) 
            : base(string.Empty, innerException)
        {
        }
    }
}
