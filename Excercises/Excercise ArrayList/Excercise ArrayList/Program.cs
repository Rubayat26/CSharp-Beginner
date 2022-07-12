using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises.ArrayList
{
    public class ArrayList
    {

        public static void Excercise1()
        {
            Console.WriteLine();
        }


        public static void Excercise2()
        {
            Console.WriteLine("enter a name: ");
            var str = Console.ReadLine();

            //var strReverse = str.Reverse();
            var name = str.ToCharArray();

            Array.Reverse(name);

            Console.WriteLine(new string(name));

        }



    }
}
