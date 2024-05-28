public interface IPaymentGateway
{
    void ProcessPayment(string accountNumber, decimal amount);
    bool ValidatePayment(string transactionId);
}
