// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

using demo1.Math;

namespace demo1 
{
    class Porgram
    {
        static void Main(string[] args)
        {
            /* var number = 2;
               Console.WriteLine(number);
               Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
               Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);*/

            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Doe";
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(3, 5);
            //var result = Calculator.Add(3, 5);
            Console.WriteLine(result);
        }
    }
}
   
