using System;
using System.Threading;


namespace PerfectNumbers
{
    class Program
    {
        private static int number;
        private static string answer;
        private static string answer2;
        private static int total = 0;
        private static int result;

        static void Main(string[] args)
        {
        Try:
            try
            {
                Console.WriteLine("Enter a Number ");
                Console.WriteLine("");
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("");
                Console.WriteLine("Please Write a Number");
                Thread.Sleep(1500);
                Console.Clear();
                goto Try;
            }
            Console.WriteLine("Do You Want To See Process ?   Y / N");
            answer = Console.ReadLine();
            if (answer == "Y" || answer == "y" || answer == "N" || answer == "n")
            {
                goto Continue;
            }
            else
            { 
            Console.WriteLine("");
            Console.WriteLine("Please Write Y or N");
            Thread.Sleep(1500);
            goto Try;
            Console.Clear();
        }
        Continue:
            Console.WriteLine("");
            if (answer == "Y" || answer == "y")
            {
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {

                        result = number % i;
                        Console.WriteLine("{0} % {1} = {2}", number, i, result);
                        total += i;
                        Thread.Sleep(500);
                    }
                    else
                    {
                        result = number % i;
                        Console.WriteLine("{0} % {1} = {2}", number, i, result);
                        Thread.Sleep(500);
                    }
                }
            }
            else if (answer == "N" || answer == "n")
            { 
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {

                    result = number % i;
                    total += i;
                }
                else
                {
                    result = number % i;
                }
            }
        }
            if (total == number)
            {
                Console.WriteLine("Congratulations ! Your Number's a Perfect Number ");
            }
            else
            {
                Console.WriteLine("Sorry Your Number isn't a Perfect Number");
                Console.WriteLine("Total = " + total);
            }
                Console.WriteLine("Do You Want To Try Again?  Y / N");
                answer2 = Console.ReadLine();
            if (answer2 == "Y" || answer2 == "y" || answer2 == "N" || answer2 == "n")
            {
                if (answer2 == "Y" || answer2 == "y")
                {
                    Console.Clear();
                    goto Try;

                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Please Write Y or N");
                Thread.Sleep(1500);
                Console.Clear();
                goto Try;
            }
        }
    }
}
