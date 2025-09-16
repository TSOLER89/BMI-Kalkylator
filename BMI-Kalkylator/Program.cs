using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till BMI Kalkylator");

        Console.Write("Ange din vikt (kg om metric, lbs om imperial): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Ange din längd (meter om metric, inches om imperial): ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Ange enhet (metric/imperial), standard är metric: ");
        string unit = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(unit))
        {
            unit = "metric";
        }

        double bmi = CalculateBMI(weight, height, unit);
        Console.WriteLine($"Ditt BMI är: {bmi:F2}");

        // Exempel på namngivna argument
        double bmi1 = CalculateBMI(weight: weight, height: height, unit: unit);
        Console.WriteLine($"BMI med namngivna argument: {bmi1:F2}");
    }

    static double CalculateBMI(double weight, double height, string unit = "metric")
    {
        if (unit.ToLower() == "metric")
        {
            return weight / (height * height);
        }
        else if (unit.ToLower() == "imperial")
        {
            return 703 * (weight / (height * height));
        }
        else
        {
            Console.WriteLine("Okänd enhet, returnerar 0");
            return 0;
        }
    }
}
