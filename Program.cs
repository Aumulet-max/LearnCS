using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5, b = 2;
            // Addition
            Console.WriteLine($"a + b = {a + b}");
            /*
             * Multi line comment
             */

            // Array
            string[] cars = new string[3];
            cars[0] = "Ford";
            cars[1] = "BMW";
            cars[2] = "Toyota";
            Console.WriteLine($"The first car is {cars[0]}");
            Console.WriteLine($"The second car is {cars[1]}");
            Console.WriteLine($"The third car is {cars[2]}");

        }
    }
}
