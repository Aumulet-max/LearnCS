using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            // List (dynamic array)
            List<int> numbers = new List<int>();
            numbers.Add(64);
            numbers.Add(128);
            numbers.Add(256);
            Console.WriteLine($"The first number is {numbers[0]}");
            Console.WriteLine($"The second number is {numbers[1]}");
            Console.WriteLine($"The third number is {numbers[2]}");
            numbers.Remove(128);
            Console.WriteLine($"After removeing 128,The new second number is {numbers[1]}");
            numbers.Add(111);
            numbers[0] = numbers[1] + numbers[2];
            Console.WriteLine($"The first number is {numbers[0]}");

            // Dictionary (key-value pairs)
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Apple", 1.5f);
            products.Add("Banana", 0.5f);
            products.Add("Orange", 0.8f);
            Console.WriteLine($"The price of Apple is ${products["Apple"]}");
            Console.WriteLine($"The price of Banana is ${products["Banana"]}");
            Console.WriteLine($"The price of Orange is ${products["Orange"]}");

            // If-Else statement
            if (a > b) Console.WriteLine("a is greater than b");

            if (products.Count > 10) Console.WriteLine("Products are more than 10");
            else Console.WriteLine("Products are less than or equal to 10");

            int age = 15;
            if (age >= 18) Console.WriteLine("You are an adult");
            else if (age >= 13) Console.WriteLine("You are a teenager");
            else Console.WriteLine("You are a child");

            // Switch statement
            char grade = 'B';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    break;
                case 'C':
                    Console.WriteLine("Average");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

            //For loop
            for (int i = 0; i <5; i++) Console.WriteLine($"For loop iteration {i}");

            //While loop
            bool isTrue = true;
            int counter = 0;
            while (isTrue)
            {
                Console.WriteLine("Eternity");
                if (counter == 10) isTrue = false;
                counter++;
            }

            //Foreach loop
            foreach (string car in cars) Console.WriteLine($"car: {car}");

            //Functions
            string Hello(string name)
            {
                return $"Hello {name}!";
            }

            /*string h = Hello();
            Console.WriteLine(h);*/
            Console.WriteLine(Hello("AUM"));

            /*string NumberCompare(int x, int y)
            {
                if (x > y) return $"{x} is greater than {y}";
                else if (x < y) return $"{x} is less than {y}";
                else return $"{x} is equal to {y}";
            }
            Console.WriteLine(NumberCompare(5, 10));*/

            void NumberCompare(int x, int y)
            {
                if (x > y) Console.WriteLine ($"{x} > {y}");
                else if (x < y) Console.WriteLine ($"{x} < {y}");
                else Console.WriteLine ($"{x} = {y}");
            }
            NumberCompare(5, 10);
        }
    }
}
