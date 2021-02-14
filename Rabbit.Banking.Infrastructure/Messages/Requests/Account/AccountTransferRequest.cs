namespace Rabbit.Banking.Infrastructure.Messages.Requests.Account
{
    public class AccountTransferRequest
    {
        public string ToAccountNumber { get; set; }

        public string FromAccountNumber { get; set; }

        public decimal Amount { get; set; }
    }
}
