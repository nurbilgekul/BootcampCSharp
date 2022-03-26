using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the traffic light(R/G/Y):");
            string choosing = Console.ReadLine();

            if (choosing == "R")
            {
                Console.WriteLine("Stop!");
            }
            else if (choosing == "Y")
            {
                Console.WriteLine("Warning!");
            }
            else if (choosing == "G")
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            switch (choosing)
            {
                case "R":
                    Console.WriteLine("Stop!");
                    break;
                case "Y":
                    Console.WriteLine("Warning!");
                    break;
                case "G":
                    Console.WriteLine("Pass!");
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
            //caselerin birleşmesi
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday: 
                case DayOfWeek.Saturday:
                    Console.WriteLine("Weekend!");
                    break;

                case DayOfWeek.Monday:    
                case DayOfWeek.Tuesday:   
                case DayOfWeek.Wednesday:            
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Weekday!");
                    break;
                
                default: //else yerine
                    break;
            }
        }
    }
}
