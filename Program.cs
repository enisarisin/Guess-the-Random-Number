using System;

namespace Guess_the_Random_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(50);
            Console.WriteLine("Keep a number between 1-50 in your mind");
            int count = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Input your number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n != randomNumber)
                {
                    if (n < randomNumber)
                    {
                        Console.WriteLine("Increase");
                        count++;
                        Console.WriteLine("Remain = {0}", count);
                    }
                    else
                    {
                        Console.WriteLine("Decrease");
                        count++;
                        Console.WriteLine("Remain = {0}", count);
                    }
                }
                else
                {
                    Console.WriteLine("Correct !");
                }
            }
            Console.WriteLine("Random Number: {0}", randomNumber);
            Console.WriteLine("Press a button for exit");

            Console.ReadLine();
        }
    }
}
