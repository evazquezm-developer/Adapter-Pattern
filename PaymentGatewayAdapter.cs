public class PaymentGatewayAdapter : IPaymentGateway
{
    private readonly ThirdPartyPaymentGateway _thirdPartyPaymentGateway;

    public PaymentGatewayAdapter(ThirdPartyPaymentGateway thirdPartyPaymentGateway)
    {
        _thirdPartyPaymentGateway = thirdPartyPaymentGateway;
    }

    public void ProcessPayment(string accountNumber, decimal amount)
    {
        _thirdPartyPaymentGateway.MakePayment(accountNumber, amount);
    }

    public bool ValidatePayment(string transactionId)
    {
        return _thirdPartyPaymentGateway.VerifyPayment(transactionId);
    }
}
