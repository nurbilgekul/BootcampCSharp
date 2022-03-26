using System;
using System.Collections.Generic;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi içindeki elemanlar biliniyorsa
            string[] shoppingList = new string[] { "Apple", "Orange", "Tomato" };
            Console.WriteLine($"First Member: {shoppingList[0]}");
            Console.WriteLine($"Array has {shoppingList.Length} member");
            Console.WriteLine($"Last Member: {shoppingList[shoppingList.Length - 1]}");

            //elemanların sadece kaç adet olduğu biliniyorsa
            string[] participants = new string[38];
            participants[0] = "Nur Bilge";
            participants[1] = "Pera";
            participants[37] = "Firuze";

            //42 girdi
            //Kırk iki çıktı

            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

            Console.WriteLine("Enter a number between 1 and 100:");
            int number = Convert.ToInt32(Console.ReadLine());

            int onlarBasamagi = number / 10;
            int birlerBasamagi = number % 10;
            Console.WriteLine($"{onlar[onlarBasamagi]} {birler[birlerBasamagi]}");

            //16.988.786

            //diziye eleman ekleme senaryosu
            Array.Resize(ref shoppingList, shoppingList.Length + 1);
            shoppingList[shoppingList.Length - 1] = "Cheese";

            //arraylerin aksine generic list add,remove vb methodlar barındırıyor, daha dinamik olarak yönetilebiliyor.
            List<string> newShoppingList = new List<string>();
            newShoppingList.Add("Water");
            newShoppingList.Add("Cheese");


        }
    }
}
