class Customer : FoodOrderingApp
{
    static string customerLocation="Bagbazar";
    public void ReceiveFood()
    {
        Console.WriteLine("Food Received");

    }
    public override void GenerateReceipt()
    {
        base.GenerateReceipt();
    }
}