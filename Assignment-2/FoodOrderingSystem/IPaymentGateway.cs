interface IPaymentGateway
{
    void CheckBalance();
    void CheckBalance(float price); //bill pay garna price thaha hunxa parxa
}