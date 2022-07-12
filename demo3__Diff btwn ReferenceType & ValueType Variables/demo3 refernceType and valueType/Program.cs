// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Person
{
    public int Age;
}

 class Program
{
    static void Main(string[] args)
    {
        var number = 1;                   //here numebr is a value type variable, 
        Increment(number);                                     
        Console.WriteLine(number);        // Here the output would be 1, because value type variable

        var person = new Person           // Here person is refernce type variable 
        {
            Age = 20
        };
        MakeOld(person);    
        Console.WriteLine(person.Age);    // here the output would be 30 

    }

    public static void Increment (int number)
    {
        number += 10;
    }

    public static void MakeOld(Person person)
    {
        person.Age += 10;
    }
}