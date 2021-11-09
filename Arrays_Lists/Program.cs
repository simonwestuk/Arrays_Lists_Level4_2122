using System;

namespace Arrays_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);

                string oddEven = numbers[i] % 2 == 0 ? "Even" : "Odd";

                Console.WriteLine($"{numbers[i]} is {oddEven}");
            }            

        }
    }
}
