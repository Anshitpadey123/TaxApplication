
using System;
using TaxLibrary;

class Program
{
    static void Main()
    {
        TaxCalculator obj = new TaxCalculator();

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Annual Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        double oldTax = obj.CalculateOldRegimeTax(income);
        double newTax = obj.CalculateNewRegimeTax(income);

        Console.WriteLine("\n--- Employee Tax Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Income: " + income);
        Console.WriteLine("Old Regime Tax: " + oldTax);
        Console.WriteLine("New Regime Tax: " + newTax);

        Console.ReadKey();
    }
}