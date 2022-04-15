using System;

namespace Lab3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string userInput;
            Console.Write("Enter a number:");
            userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            
            if (number == 0 || number == 1)
            {
                Console.WriteLine("not prime number");
            }
            else
            {
                for(int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("not a prime number");
                        return;
                    }
                }
                Console.WriteLine("prime number");
            }
        }
    }
}
