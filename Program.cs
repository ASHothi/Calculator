// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace PriceCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many paint cans did you Buy?");
            int numOfPaintCans = int.Parse(Console.ReadLine());
            
            double costOfPaintCans = 15.99;
            double costOfDecorations = 119.99;

            Console.WriteLine("How many days did you work?");
            double daysWorked = double.Parse(Console.ReadLine());
            double dayRate = 25.0;

            double milesTraveled = 5.29;
            double fuelCostPerMile = 0.12;

            double profitPercent = 0.4;
            double taxRate = 0.2;

            double totalCost = (numOfPaintCans * costOfPaintCans) + (milesTraveled * fuelCostPerMile) + costOfDecorations;
            double profit = (totalCost * profitPercent);
            double costForCustomer = totalCost + profit + (daysWorked * dayRate);
            double profitAfterTax = profit - (profit * taxRate);

            Console.WriteLine("Cost of goods and travel = £" + Math.Round(totalCost, 2));
            Console.WriteLine("In order to earn " + (profitPercent * 100) + "% profit charge £" + Math.Round(costForCustomer, 2));
            Console.WriteLine("Profit made after tax = £" + Math.Round(profitAfterTax, 2));
        }
    }
}

// TODO User Input through readline
// TODO redo Costs section calculation
// TODO Add verfication for the ReadLine to make sure only numbers are entered 