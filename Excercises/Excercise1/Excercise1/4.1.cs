// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number:");

            
            var number = Console.ReadLine();
            var number1 = Int32.Parse(number);

            if (number1 >=1 && number1 <= 10)
            {
                Console.WriteLine("valid");
            } 
            else 
            {
                Console.WriteLine("invalid");
             }

            
        }
    }
}