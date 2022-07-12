// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new List<int>() { 1, 2 });
            numbers.AddRange(new int[3] { 1, 2, 3 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);

            }

            Console.WriteLine(numbers.IndexOf(1));
            Console.WriteLine(numbers.LastIndexOf(1));

            Console.WriteLine(numbers.Count());

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            Console.WriteLine(numbers.Count());

        }
    }
}
