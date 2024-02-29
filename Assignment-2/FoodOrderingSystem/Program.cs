class Program
{
    public static void Main()
    {
        Console.WriteLine("This is food ordering system!");

        FoodOrderingApp foodOrderingApp = new();
        foodOrderingApp.TotalBill();

        foodOrderingApp.ChooseCategory = "beverages";

        Customer customer = new();
        customer.CheckBalance();

       


       
    }
        
 }