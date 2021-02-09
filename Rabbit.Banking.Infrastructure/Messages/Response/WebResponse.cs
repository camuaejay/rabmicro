namespace Rabbit.Banking.Infrastructure.Messages.Response
{
    using Newtonsoft.Json;

    public class WebResponse<T> : BaseWebBaseResponse
    {
        public WebResponse(T data)
        {
            this.Data = data;
        }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
