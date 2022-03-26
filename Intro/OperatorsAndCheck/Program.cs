using System;

namespace OperatorsAndCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // + işareti veri tiplerine göre işlevi değişir
            int x = 3 + 5;
            string newWord = "Bilgi" + "sayar";

            Console.WriteLine(newWord);
            Console.WriteLine(x.ToString());

            byte bigNumber = 254;
            byte smallNumber = 2;

            //snipped surround with chechked
            try
            {
                checked
                {
                    byte total = (byte)(bigNumber + smallNumber);
                    Console.WriteLine(total); //byte'ın sınırı 255 sonrasında başa sarıyor 0 verdi sonuç.
                }

            }
            catch (OverflowException)
            {
                Console.WriteLine("Total cannot cast to byte data type");
            }

            Console.WriteLine("Number 1 is:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 2 is:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int division = number1 / number2;
                Console.WriteLine($"Result:{ division}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input only digits");  
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Number 2 cannot be 0!");
            }
        }
    }
}
