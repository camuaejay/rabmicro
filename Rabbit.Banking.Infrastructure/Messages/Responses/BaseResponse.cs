namespace Rabbit.Banking.Infrastructure.Messages.Responses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BaseResponse
    {
        public BaseResponse()
        {
            Errors = new List<string>();
            Message = string.Empty;
            Success = false;
        }

        public List<string> Errors { get; set; }

        public string Message { get; set; }

        public bool Success { get; set; }
    }
}
