using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Enter a number so we can fizz buzz: ");
            num = Convert.ToDouble(Console.ReadLine());

            int i = 1;
            while (i <= num)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                i++;
            }

            Console.ReadLine();
        }
    }
}
