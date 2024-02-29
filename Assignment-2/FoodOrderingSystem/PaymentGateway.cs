interface IPaymentGateway
{
    void CheckBalance();
    void PayBill(float price); //bill pay garna price thaha hunxa parxa
}