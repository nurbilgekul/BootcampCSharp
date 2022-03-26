using System;

namespace CompositeConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Month:");
            string month = Console.ReadLine();
            if (month == "December" || month == "January" || month == "February")
            {
                Console.WriteLine("Winter");
            }
            else if (month == "March" || month == "April" || month == "May")
            {
                Console.WriteLine("Spring");
            }
            else if (month == "June" || month == "July" || month == "August")
            {
                Console.WriteLine("Summer");
            }
            else
            {
                Console.WriteLine("Fall");
            }

            DateTime today = DateTime.Now;
            //DateTime today = new DateTime(2022, 5, 3);

            if (today.Month == 5 && today.Day == 3)
            {
                Console.WriteLine("Happy Birthday!");
            }

        }
    }
}
