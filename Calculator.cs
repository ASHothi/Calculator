// See https://aka.ms/new-console-template for more information
using System;

namespace PriceCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            bool isFinished = false;

            do
            {


                Console.WriteLine("Do you want ");
            }
            while (isFinished);


            Console.WriteLine("what is the height of the wall?");
            double heightOfWall = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the width of the wall");
            double widthOfWall = double.Parse(Console.ReadLine());

            double areaOfWall = heightOfWall * widthOfWall;

            Console.WriteLine("Are there areas of the wall that don't need painting? (y/n)");
            if (Console.ReadLine().Equals("y"))
            {
                Console.WriteLine("what is the height of this area?");
                double heightOfArea = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the width of this area?");
                double widthOfArea = double.Parse(Console.ReadLine());

                areaOfWall -= (heightOfArea * widthOfArea);
            }

            Console.WriteLine("Area of Paintable wall = " + areaOfWall);

            Console.WriteLine("what paint colour are you using?");
            string paintColour = Console.ReadLine();

            double costOfPaintCans;

            switch (paintColour)
            {
                case "red":
                    costOfPaintCans = 18.99;
                    break;
                case "blue":
                    costOfPaintCans = 16.99;
                    break;
                case "green":
                    costOfPaintCans = 21.99;
                    break;
                default:
                    costOfPaintCans = 15.99;
                    break;
            }

            // Assumption 1 litre paint covers 10m^2 of wall
            int numOfPaintCans = (int) Math.Ceiling(areaOfWall/10.0);
            double totalCostOfPaint = numOfPaintCans * costOfPaintCans;

            Console.WriteLine("the number of 1 litre paint cans you need is " + numOfPaintCans + ", this will Cost £" + Math.Round(totalCostOfPaint, 2));

            double costOfDecorations = 119.99;

            Console.WriteLine("How many hours do think it will take to complete the work?");
            double hoursWorked = double.Parse(Console.ReadLine());

            Console.WriteLine("what is your hourly rate?");
            double hourlyRate = 8.0;

            // ---------- TODO redo section below ------------
            Console.WriteLine("How many miles did you travel?");
            double milesTraveled = double.Parse(Console.ReadLine());
            double fuelCostPerMile = 0.12;

            double profitPercent = 0.4;
            double taxRate = 0.2;

            // TODO Costs calculation section needs to be redone
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
// TODO redo Costs calculation section 
// TODO Add verfication for the ReadLine to make sure only numbers are entered