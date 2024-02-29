abstract class Menu
{
    public string ChooseCategory { get; set; } // category means food or beverages
    public float Price { get; } = 1050.25f;

    List<string> menuItems = ["Momo","Pizza","Ramen","Burger"];
   
    public virtual void TotalBill()
    {
        Console.WriteLine($"Total bill is:{Price} ");
    }

}