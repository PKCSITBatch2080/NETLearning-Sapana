using System;
using System.Linq;

class Methods
{
   public void Greet()=>Console.WriteLine(" Hey, there!"); //arrow function
    public void Greet(string greeting) =>Console.WriteLine($" {greeting}, there!"); // string interpolation



    public float CalculateBMI(float weightInKg, float heightInfeet)
    {
        var  heightInM= heightInfeet*0.3048f;
        var bmi= weightInKg/ (heightInM*heightInM);
        return bmi;
    }

    public double GetMax(params double[] numbers)=> numbers.Max();  
    // max is built-in method, params keyword user garera arrary jasari pathauna parena, call garna easy vayo
    // params accept variable number of argument

    public (int,int) GetMinMax(params int[] numbers)
    {
         var smallest= numbers.Min();
         var highest= numbers.Min();
         return(smallest,highest); //tuple which will retun two intezer number

         
    }
    

}