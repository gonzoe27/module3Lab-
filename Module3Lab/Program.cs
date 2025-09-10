using System;

//Namespace hold the class files for the project 
namespace TacoBurritoLab
{
    class Program
    {
        //Define the main method - this is a method that 
        //Is automatically called when the program is ran
        static void Main(string[] args)
        {
            //Display a welcome message to users 
            Console.WriteLine("Welcome to the Taco and Burrito Decision Maker!");

            //Prompt the user for their hunger level and get the value 
            Console.WriteLine("How hungry are you (1-10)?");
            int hungerLevel = int.Parse(Console.ReadLine());

            //Conditional Statement to test the gunger level and make a sugggestion
            if (hungerLevel >= 8)
            {
                Console.WriteLine("You're super Hungry! Order both tacos and burritos.");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("You're moderately hungry. Go for tacos!");
            }
            else
            {
                Console.WriteLine("You're not that hungry. Opt for a burrito.");
            }//end of if else block

            // ternary operator - condition statement to make a final recommendation 
            string recommendation = (hungerLevel >= 5) ? "Tacos" : "Burrito";
            Console.WriteLine($"I recommend: {recommendation}");

            //Switch statment - test a single variable and performs the code block
            //with the cas that matches the variable value 
            switch (hungerLevel)
            {
                case 10:
                    Console.WriteLine("You're a Taco and burrito champion");
                    break;
                case 9:
                case 11:
                //case blocks can be empty 
                case 8:
                    Console.WriteLine("Taco time!");
                    break;
                case 5:
                    Console.WriteLine("Burrito it is!");
                    break;
                default:
                    Console.WriteLine("Maybe just grab a Snack!");
                    break;
            }

        }//end main method
    }//end class
}//end namespace

