class Program
{
    public static void Main()
    {
        string filePath = @"D:\Dotnet-git\NETLearning-Sapana\Assignment-3\Inflation.csv";
        InflationAnalysis analysis = new InflationAnalysis();
        analysis.ReadInflationData(filePath);

        Console.WriteLine("Inflation rates for countries for the year 2021:");
        var data = analysis.GetInflationRatesForYear(2021);
        foreach (var inflation in data)
        {
            Console.WriteLine($"{inflation.RegionalMember}: {inflation.InflationRate}%");
        }

        Console.WriteLine("\nYear when Nepal has highest inflation:");
        string countryName = "Nepal";
        int yearWithHighestInflationForNepal = analysis.GetYearWithHighestInflationForCountry(countryName);
        Console.WriteLine(yearWithHighestInflationForNepal);

        Console.WriteLine("\nTop 10 regions (countries) where inflation is highest for all time:");
        foreach (var inflation in analysis.GetTop10RegionsWithHighestInflation())
        {
            Console.WriteLine($"{inflation.RegionalMember}: {inflation.InflationRate}%");
        }

        Console.WriteLine("\nTop 3 South Asian countries with lowest inflation rate for year 2020:");
        foreach (var inflation in analysis.GetTop3SouthAsianCountriesWithLowestInflationForYear(2020))
        {
            Console.WriteLine($"{inflation.RegionalMember}: {inflation.InflationRate}%");
        }

    }
}