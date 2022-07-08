using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercises.Loop
{
    public class Loops
    {
        public static void Excercise1()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) { count++; }

            }
            Console.WriteLine(count);

        }

        public static void Excercise2()
        {
            var number = 0;

            while (true)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();

                if (input == "ok")
                    break;
                
                number = number + Convert.ToInt32(input); 
            }
            Console.WriteLine("total of inputs " + number);
        }


        public static void Excercise3()
        {

        }
    }
}
