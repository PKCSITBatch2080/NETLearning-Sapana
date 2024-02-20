using System;

class Methods
{
   public void Greet()
    {
        Console.WriteLine(" Hey, there!");
    }
    public void Greet(string greeting)
    {
        Console.WriteLine($" {greeting}, there!"); // string interpolation

    }

    public float CalculateBMI(float weightInKg, float heightInfeet)
    {
        var  heightInM= heightInfeet*0.3048f;
        var bmi= weightInKg/ (heightInM*heightInM);
        return bmi;
    }

}