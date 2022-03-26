using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = { "Math", "C#", "Html", "Css", "JavaScript","SQL" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            int[] ages = { 42, 29, 23, 26, 29, 29 };
            int totalAge = 0;
            for (int i = 0; i < ages.Length; i++)
            {
                //totalAge = totalAge + ages[i];
                totalAge += ages[i];
            }
            int average = totalAge / ages.Length;
            Console.WriteLine($"Yaş Ortalaması:{average}");

            //dizideki en küçük elemanı bulma
            int[] numbers = { 36, 12, 26, 9, -4, 22, 8 };

            int minNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine($"Minimum number:{minNumber}");
        }
    }
}
