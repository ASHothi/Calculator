// See https://aka.ms/new-console-template for more information
using System;

namespace PriceCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the height of the wall?");
            double heightOfWall = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the width of the wall");
            double widthOfWall = double.Parse(Console.ReadLine());

            double AreaOfWall = heightOfWall * widthOfWall;

            Console.WriteLine("Are there areas of the wall that don't need painting? (y/n)");
            if (Console.ReadLine().Equals("y"))
            {
                Console.WriteLine("what is the height of this area?");
                double heightOfArea = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the width of this area");
                double widthOfArea = double.Parse(Console.ReadLine());

                AreaOfWall -= (heightOfArea * widthOfArea);
            }

            Console.WriteLine("Area of Paintable wall = " + AreaOfWall);

            // REDO section below
            Console.WriteLine("How many paint cans did you Buy?");
            int numOfPaintCans = int.Parse(Console.ReadLine());
            
            double costOfPaintCans = 15.99;
            double costOfDecorations = 119.99;

            Console.WriteLine("How many hours did you work?");
            double hoursWorked = double.Parse(Console.ReadLine());
            double hourlyRate = 8.0;

            Console.WriteLine("How many miles did you travel?");
            double milesTraveled = double.Parse(Console.ReadLine());
            double fuelCostPerMile = 0.12;

            double profitPercent = 0.4;
            double taxRate = 0.2;

            // T0DO Costs calculation section needs to be redone
            double totalCost = (numOfPaintCans * costOfPaintCans) + (milesTraveled * fuelCostPerMile) + costOfDecorations;
            //double profit = (totalCost * profitPercent);
            double costForCustomer = totalCost + (hoursWorked * hourlyRate);
            double profitAfterTax = (costForCustomer - (costForCustomer * taxRate)) - totalCost;

            Console.WriteLine("Cost of goods and travel = £" + Math.Round(totalCost, 2));
            //Console.WriteLine("In order to earn " + (profitPercent * 100) + "% profit charge £" + Math.Round(costForCustomer, 2));
            Console.WriteLine("Profit made after tax = £" + Math.Round(profitAfterTax, 2));   
        }
    }
}

// TODO has to generate quote beforehand
// TODO allow multiple walls to be added 
// TODO if statement to remove areas that are not paintable
// TODO User Input through readline
// TODO redo Costs calculation section 
// TODO Add verfication for the ReadLine to make sure only numbers are entered