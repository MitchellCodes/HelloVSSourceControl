using System;
using System.Collections.Generic;

namespace HelloVSSourceControl
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the dealership manager!");

            DisplayInStockCars();

            Console.WriteLine("Press a key to end");
            Console.ReadKey();
        }

        /// <summary>
        /// Displays a list of in stock cars, in alphabetical order
        /// </summary>
        static void DisplayInStockCars()
        {
            // Not pulling from an actual database yet...
            List<string> inStockCars = new List<string>
            {
                "Honda Prelude - Qty: 5",
                "Kia Forte - Qty: 10"
            };

            foreach(string currCar in inStockCars)
            {
                Console.WriteLine(currCar);
            }
        }
    }
}
