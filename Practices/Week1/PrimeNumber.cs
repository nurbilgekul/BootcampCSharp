using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number:");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;


            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }

            }
            if (isPrime)
            {
                Console.WriteLine("It is a Prime Number!");
            }
            else
            {
                Console.WriteLine("It is not a Prime Number!");
            }
            Console.ReadKey();

        }
    }
}
