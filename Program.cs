
class Program
{
    static void Main(string[] args)
    {
        // Create instances manually without dependency injection
        ThirdPartyPaymentGateway thirdPartyPaymentGateway = new ThirdPartyPaymentGateway();
        IPaymentGateway paymentGateway = new PaymentGatewayAdapter(thirdPartyPaymentGateway);

        // Use the payment gateway
        string accountNumber = "1234567890";
        decimal amount = 150.00m;
        string transactionId = "TXN12345";

        paymentGateway.ProcessPayment(accountNumber, amount);
        
        bool isValid = paymentGateway.ValidatePayment(transactionId);

        Console.WriteLine($"The payment validation result for transaction ID {transactionId} is {isValid}");
    }
}