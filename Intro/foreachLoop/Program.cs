using System;
using System.Collections.Generic;

namespace foreachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> brands = new List<string>();
            brands.Add("Samsung");
            brands.Add("Xiaomi");
            brands.Add("Oppo");
            brands.Add("Apple");
            brands.Add("Arctic");

            List<string> storage = new List<string>();
            foreach (string brand in brands)
            {
                
                if (brand.StartsWith("A"))
                {
                    storage.Add(brand);
                    //brands.Remove(brand); izin verilmiyor foreachin içindeki koleksiyona müdahale ettirmiyor 
                }
                Console.WriteLine(brand);
            }
            foreach (var item in storage)
            {
                brands.Remove(item);
            }
            
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            foreach (var item in brands)
            {
                Console.WriteLine(item);
            }
        }
    }
}
