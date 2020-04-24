using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************
 * CIT 365
 * Assignment: W01- Your First Visual Studio C# Application
 * 
 * Completed On: 4/20/2020
 * Author: Elizabeth Berry
 ***********************************************************/

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Store two variables:
            //  your name
            //  your location
            string name = "Elizabeth Berry";
            string location = "Rexburg, Idaho";

            //3. Output two WriteLine statements 
            //  that display those two variables with proper labels
            //  using String Interpolation.
            Console.WriteLine($"I am {name}.");
            Console.WriteLine($"I am in {location}.");

            //4. Output the current date but not the current time.
            DateTime now = DateTime.Now;
            string curDay = now.ToString("MM-dd-yyyy");

            Console.WriteLine($"Today is {curDay}.");

            //4. Output the number of days until Christmas this year and,
            //  of course, apply an appropriate label to that output. 
            int year = DateTime.Now.Year;
            DateTime nextXmas = new DateTime(year, 12, 25);
            int daysTilXmas = nextXmas.Subtract(now).Days;

            Console.WriteLine($"There are {daysTilXmas} days until Christmas.");

            //5. Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
            //6. Add these requirements to the code:
            // Provide appropriate text labels when requesting dimensional input.
            // Cause the program to pause in the console so that the application 
            // does not automatically terminate when launched from the Visual Studio run debugger tool. 
            double width, height, woodLength, glassArea; string widthString, heightString;
            Console.WriteLine("\nEnter the width of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet.");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres.");

            Console.WriteLine("\nPress Any Key to Exit.");
            while (!Console.KeyAvailable)
            {
                //do nothing
            };

        }
    }
}
