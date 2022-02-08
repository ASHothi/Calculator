// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace PriceCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int numOfPaintCans = 10;
            double costOfPaintCans = 15.99;
            double costOfDecorations = 119.99;

            double daysWorked = 2.5;
            double dayRate = 25.0;

            double milesTraveled = 5.29;
            double fuelCostPerMile = 0.12;

            double profitPercent = 0.4;
            double taxRate = 0.2;

            double totalCost = (numOfPaintCans * costOfPaintCans) + (milesTraveled * fuelCostPerMile) + costOfDecorations;
            double profit = (totalCost * profitPercent);
            double costForCustomer = totalCost + profit + (daysWorked * dayRate);
            double profitAfterTax = profit - (profit * taxRate);

            Console.WriteLine("Cost of goods and travel is £" + totalCost + ".");
            Console.WriteLine("In order to earn " + (profitPercent * 100) + "% profit charge £" + Math.Round(costForCustomer, 2) + ".");
            Console.WriteLine("Profit made after tax = £" + Math.Round(profitAfterTax, 2) + ".");
        }
    }
}
