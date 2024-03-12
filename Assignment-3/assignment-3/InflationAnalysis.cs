class InflationAnalysis
{
    List <Inflation> AsianPacificInflation;

    public InflationAnalysis()
    {
       AsianPacificInflation = new ();
    }

     public void ReadInflationData(string filePath)
{
    using (var reader = new StreamReader(filePath))
    {
        reader.ReadLine(); // Skip header row
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] values = line.Split(',');
            
            // Ensure that values array has the expected number of elements
            if (values.Length >= 6)
            {
                string inflationRateString = values[2].Replace("%", "");
                if (!string.IsNullOrWhiteSpace(inflationRateString))
                {
                    double inflationRate;
                    if (double.TryParse(inflationRateString, out inflationRate))
                    {
                        Inflation inflationData = new Inflation
                        {
                            RegionalMember = values[0],
                            Year = int.Parse(values[1]),
                            InflationRate = inflationRate,
                            UnitOfMeasurement = values[3],
                            Subregion = values[4],
                            CountryCode = values[5]
                        };
                        AsianPacificInflation.Add(inflationData);
                    }
                    else
                    {
                        // Handle invalid inflation rate
                        Console.WriteLine($"Invalid inflation rate: {inflationRateString}");
                    }
                }
                else
                {
                    // Handle missing inflation rate
                    Console.WriteLine("Missing inflation rate");
                }
            }
            else
            {
                // Handle invalid or missing data
                Console.WriteLine($"Invalid data: {line}");
            }
        }
    }
}


    public List<Inflation> GetInflationRatesForYear(int year)
    {
        return AsianPacificInflation.Where(inflation => inflation.Year == year).ToList();
    }

    public int GetYearWithHighestInflationForCountry(string countryName)
    {
        return AsianPacificInflation
            .Where(inflation => inflation.RegionalMember == countryName)
            .OrderByDescending(inflation => inflation.InflationRate)
            .Select(inflation => inflation.Year)
            .FirstOrDefault();
    }

    public List<Inflation> GetTop10RegionsWithHighestInflation()
    {
        return AsianPacificInflation
            .Where(inflation => !string.IsNullOrEmpty(inflation.CountryCode))
            .GroupBy(inflation => inflation.RegionalMember)
            .Select(group => new Inflation
            {
                RegionalMember = group.Key,
                InflationRate = group.Average(inflation => inflation.InflationRate)
            })
            .OrderByDescending(inflation => inflation.InflationRate)
            .Take(10)
            .ToList();
    }

    public List<Inflation> GetTop3SouthAsianCountriesWithLowestInflationForYear(int year)
    {
        return AsianPacificInflation
            .Where(inflation => inflation.Year == year && inflation.Subregion == "South Asia")
            .OrderBy(inflation => inflation.InflationRate)
            .Take(3)
            .ToList();
    }

}

