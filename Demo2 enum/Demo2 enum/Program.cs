

using System;

namespace HelloWorld
{
	public enum Colors   // It needs to be defined at the namespace level (outside any class)! 
	{
		red = 1,
		green = 2,
		blue = 3,
		white = 4,
		black = 5

	}

	public enum Fruits   // It needs to be defined at the namespace level (outside any class)! 
	{
		apple = 1,
		banana= 2

	}

	public enum Veg   // It needs to be defined at the namespace level (outside any class)! 
	{
		cucumber = 2 
	}


	public class Program
	{
		public static void Main(string[] args)
		{
			var itemRed = Colors.red;

			Console.WriteLine((int)itemRed);  // Using casting to convert to int


			// How to get the keys?

			var itemX = 4;

			Console.WriteLine((Colors)itemX);  // Using casting to convert to Colors


			// How to convert enums to strings? 

			var itemBlue = Colors.blue;

			Console.WriteLine(itemBlue.ToString());


			// How to convert strings to enums? 

			var colorName = "green";

			var newEnum = (Veg)Enum.Parse(typeof(Colors), colorName);  /* here the enum.parse returns an object which is
																		  then converted to enum using casting,
			                                                            here we are getting the value from colrs enum 
			                                                            and assigning a key to the enum veg*/

			Console.WriteLine(newEnum);       // To see the key        
			Console.WriteLine((int)newEnum);  // To see the value
		}
	}
}

                // we can use t5he string to enum method if we try to bind a value of one enum top another enum i guess