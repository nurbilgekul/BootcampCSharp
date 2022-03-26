using System;

namespace LoopinsideLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Çarpım Tablosu
             */

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <=9; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
                Console.WriteLine("------------");
            }

            //kullanıcı bir sayı girecek uygulama girilen sayının asal olup olmadığını tespit edecek.
            //1-10000'e kadar bütün asal sayıları ekrana yazdıran uygulama.
            //random integer list küçükten büyüğe sırala
            //herhangi bir formülü program yap
        }
    }
}
