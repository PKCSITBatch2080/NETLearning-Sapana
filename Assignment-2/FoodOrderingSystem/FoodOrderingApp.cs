class FoodOrderingApp:Menu,IPaymentGateway
{
    public string AppName { get; set; }

    public virtual void GenerateReceipt()
    {
        Console.WriteLine("here is your receipt");
    }
    public override void TotalBill()
    {
        base.TotalBill();
        Console.WriteLine("this is child class total bill");
    }
    public void CheckBalance()
    {
        Console.WriteLine("there is sufficient balance");
    }
    public void CheckBalance(float price)
    {
        Console.WriteLine("Bill Paid");
    }


}