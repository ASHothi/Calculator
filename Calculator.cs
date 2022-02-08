// See https://aka.ms/new-console-template for more information
using System;

namespace PriceCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            bool isFinished;
            
            do
            {
                double totalPaintableWallArea = 0;
                double totalCostOfPaint;

                for (int i = 1; true; i++)
                {
                    Console.WriteLine("what is the height (in metres) of the wall " + i + "?");
                    double heightOfWall = double.Parse(Console.ReadLine());

                    Console.WriteLine("What is the width (in metres) of the wall " + i + "?");
                    double widthOfWall = double.Parse(Console.ReadLine());

                    double areaOfWall = heightOfWall * widthOfWall;

                    // Removes any areas that don't need to be painted
                    while (true)
                    {
                        Console.WriteLine("Are there areas of the wall " + i + " that don't need painting? (y/n)");
                        if (Console.ReadLine().Equals("y"))
                        {
                            Console.WriteLine("what is the height (in metres) of this area?");
                            double heightOfArea = double.Parse(Console.ReadLine());

                            Console.WriteLine("What is the width (in metres) of this area?");
                            double widthOfArea = double.Parse(Console.ReadLine());

                            double voidArea = heightOfArea * widthOfArea;

                            areaOfWall -= voidArea;
                        }
                        else
                        {
                            break;
                        }
                    }

                    totalPaintableWallArea += areaOfWall;
                    Console.WriteLine("Wall " + i + " paintable area = " + areaOfWall + "m^2");

                    Console.WriteLine("What paint colour are you using for wall " + i + "?");
                    string paintColour = Console.ReadLine();

                    Console.WriteLine("What paint colour are you using for wall " + i + "?");
                    string paintType = Console.ReadLine();

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

                    switch (paintType)
                    {
                        case "glossy":
                            costOfPaintCans += 5;
                            break;
                        case "matte":
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("how many coats of paint will be needed for wall " + i + "?");
                    int numOfCoats = int.Parse(Console.ReadLine());

                    // Assumption 1 litre paint covers 10m^2 of wall
                    int numOfPaintCans = (int) Math.Ceiling((areaOfWall * numOfCoats) / 10.0);
                    totalCostOfPaint = numOfPaintCans * costOfPaintCans;
                    Console.WriteLine(
                        "The number of " + paintColour + " 1 litre paint cans you need for " + numOfCoats + " coat(s) of wall " + i 
                        + " is " + numOfPaintCans + "."  
                    );
                    Console.WriteLine("this will Cost £" + Math.Round(totalCostOfPaint, 2));

                    Console.WriteLine("Is there another wall you want to paint? (y/n)");
                    if (Console.ReadLine().Equals("n"))
                    {
                        break;
                    }
                }

                Console.WriteLine("Total Area of Paintable wall = " + totalPaintableWallArea);
                Console.WriteLine("Total Cost of Paint = " + totalCostOfPaint);

                Console.WriteLine("How many hours do think it will take to complete the work?");
                double hoursWorked = double.Parse(Console.ReadLine());

                Console.WriteLine("what is your hourly rate?");
                double hourlyRate = double.Parse(Console.ReadLine());

                Console.WriteLine("How many miles will you need to travel?");
                double milesTraveled = double.Parse(Console.ReadLine());
                double fuelCostPerMile = 0.12;

                Console.WriteLine("what is the percentage(%) you will be taxed by");
                double taxRate = double.Parse(Console.ReadLine());

                double totalCost = totalCostOfPaint + (milesTraveled * fuelCostPerMile);
                double costForCustomer = totalCost + (hoursWorked * hourlyRate);
                double profitAfterTax = (costForCustomer - (costForCustomer * (taxRate / 100))) - totalCost;

                Console.WriteLine("Cost of goods and travel = £" + Math.Round(totalCost, 2));
                Console.WriteLine("Quote = £" + Math.Round(costForCustomer, 2));
                Console.WriteLine("Profit made after tax = £" + Math.Round(profitAfterTax, 2));

                Console.WriteLine("Do you want to restart the program? (y/n)");
                if (Console.ReadLine().Equals("y"))
                {
                    isFinished = true;
                }
                else
                {
                    isFinished = false;
                }
            }
            while (isFinished);
        }
    }
}

// TODO Add verfication for the ReadLine to make sure only numbers are entered
// TODO doors and window
// TODO different types of paint (glossy, matte .etc)