using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is "+ FirstName + " "+ LastName);

            var myFullName = String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
