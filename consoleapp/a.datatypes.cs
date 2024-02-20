using System;
class Datatypes
{
   public void Learn()
    {
        byte a = 255;
        short b = 23444;
        int d = 343423224;
        long c = 42343428757878788;
        // float weight= 49.5f; // f represent float
        // double weight2=49.3423432432432; //by default double linxa yedi float ra decimal ma xa vanye
        // decimal weight3=49.545454545454545454545m;// m for decimal

        // char name='s';// single quote for character
        // string Name="Sapana";
        // bool isFemale= false;
        DateTime date = DateTime.Now; // now le chai current date time dinxa
        Console.WriteLine(date);

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        int? g = null;
        Console.WriteLine(g);
    }
}