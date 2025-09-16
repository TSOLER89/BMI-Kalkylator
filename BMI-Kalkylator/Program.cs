using System;

namespace BMI_Kalkylator
{
    internal class Program
    {
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
            if (unit == "metric")
            {
                return weight / (height * height);
            }
            else if (unit == "imperial")
            {
                return 703 * (weight / (height * height));
            }
            else
            {
                Console.WriteLine("Okänd enhet, returnerar 0");
                return 0;

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till BMI Kalkylatorn!");

            Console.Write("Ange din vikt i kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Ange din längd i meter ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Ange enhet (metric/imperial), standard är metric: ");
            string unit = Console.ReadLine();

            if (string.IsNullOrEmpty(unit))
            {
                unit = "metric";
            }

            // 1. Vanligt anrop
            double bmi1 = CalculateBMI(weight), (height);
            Console.WriteLine($"BMI (metric, default): {bmi1:F2}");

            // 2. Namngivna argument i annan ordning
            double bmi2 = CalculateBMI(height, weight);
            Console.WriteLine($"BMI (metric, named args): {bmi2:F2}");

            // 3. Hårdkodat exempel med imperial (lbs/inches)
            double bmi3 = CalculateBMI(weight, height);
            Console.WriteLine($"BMI (imperial): {bmi3:F2}");

            Console.WriteLine("\nTryck Enter för att avsluta...");
            Console.ReadLine();
        }
    }
}

