public class ThirdPartyPaymentGateway
{
    public void MakePayment(string accountNumber, decimal amount)
    {
        // Process the payment
        Console.WriteLine($"Processed payment of {amount:C} to account {accountNumber} using ThirdPartyPaymentGateway.");
    }

    public bool VerifyPayment(string transactionId)
    {
        // Verify the payment
        Console.WriteLine($"Verifying payment with transaction ID: {transactionId} in ThirdPartyPaymentGateway.");
        
        return true; // For simplicity, always return true
    }
}
