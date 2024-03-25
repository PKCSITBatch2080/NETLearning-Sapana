using System;
using System.Threading;
using System.Threading.Tasks;

public class ParallelAndAsync
{
    // Parallel Programming
    // Tasks - that takes CPU time and independent
    int[] numbers = [5,6,8,10,15,65];
    private void CalculateSquares(int n)
    {
        var square = n * (long)n;
        Console.WriteLine($"Square of {n} is {square}");
        Thread.Sleep(1000); // 1 sec sleep hunxa
    }
    // Sequential method
    public void ProcessNumbers()
    {
        Console.WriteLine("Sequential Loop:");
        foreach(var num in numbers)
        {
            CalculateSquares(num); //yeuta number ko square le arko number lai ashara gardaina
        }
    }
    // parallel loop
    // Parallel  is faster -> improve performace, save time
     public void ProcessNumbersParallel()
    {
        Console.WriteLine("Parallel Loop:");
        // TPL -> task parallel library
        Parallel.ForEach(numbers, CalculateSquares); //it takes two argument 
    }

    // asynchronous programming -> async and await keyword
    public async Task MakeTea()
    {
       await IgniteStove();
       await BoilWaterOnTeapot();
       await PrepareMasala();
       await AddIngrediants();

    }
    private async Task IgniteStove()
    {
       await Task.Delay(1000); // delay is itself a asynchronous method
    }
    private async Task BoilWaterOnTeapot()
    {
    }
    private async Task PrepareMasala()
    {
    }
    private async Task<bool> AddIngrediants() //it return task of bool
    {
        return false;
    }
}