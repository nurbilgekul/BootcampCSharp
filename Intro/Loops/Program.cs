using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Amaç: sayı tahmin oyunu
             * 1.Program rastgele bir sayı üretir.
             * 2.Kullanıcıdan bir sayı tahmini istenir.
             * 3.Girilen tahmine göre aşağı ya da yukarı biçiminde kullanıcı yönlendirilir.
             * 4.Sayı bulunana dek 2. adıma dönülür.
             */
            bool isGameFinished=false;

            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(0, 100);

            //while döngüsü mantıksal koşul önerme üzerine
            while (!isGameFinished)
            {
                Console.WriteLine("Tahmininizi girin:");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < randomNumber)
                {
                    Console.WriteLine("Yukarı");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Aşağı");
                }
                else
                {
                    Console.WriteLine("Bildiniz!");
                    isGameFinished = true;
                }
            }

            do
            {
                Console.WriteLine("Tahmininizi girin:");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < randomNumber)
                {
                    Console.WriteLine("Yukarı");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Aşağı");
                }
                else
                {
                    Console.WriteLine("Bildiniz!");
                    isGameFinished = true;
                }
            } while (!isGameFinished);


        }
    }
}
