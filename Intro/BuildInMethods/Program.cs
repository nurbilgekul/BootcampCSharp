using System;
using System.Collections.Generic;

namespace BuildInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime giriniz:");

            string word = Console.ReadLine();

            //int index = word.IndexOf('i');
            //int index = word.IndexOf('x');
            //int index = word.IndexOf('i',2);

            int startIndex = 0;
            Console.WriteLine("Aradığınız harf:");
            string character = Console.ReadLine();

            Console.Write($"{character} harfinin index değerleri: ");
            while (word.IndexOf(character, startIndex) != -1)
            {
                int findingIndex = word.IndexOf(character, startIndex);
                Console.Write($"{findingIndex}, ");
                startIndex = findingIndex + 1;
            }
            //Console.WriteLine(index);


            List<string> emails = new List<string>()
            {
                "nurbilgekul@gmail.com",
                "nur.bilge@microsoft.com",
                "nurbilge.kul@marmara.edu.tr",
                "nurbilge@yahoo.com",
                "nbilge@mynet.com"
                //"nurbilge"
            };
            List<string> publicDomains = new List<string>()
            {
                "yahoo.com",
                "gmail.com",
                "mynet.com"

            };

            List<string> companyEmails = new List<string>();

            foreach (var mail in emails)
            {
                //foreach (var domain in publicDomains)
                //{
                //    if (!mail.EndsWith(domain))
                //    {

                //    }
                //}
                string[] mailParts = mail.Split('@');
                if (mailParts.Length > 1)
                {
                    string mailDomain = mail.Split('@')[1];
                    bool isExists = publicDomains.Contains(mailDomain);

                    if (!isExists)
                    {
                        companyEmails.Add(mail);
                    }
                }

            }
            Console.WriteLine("Company Emails:");
            foreach (var mail in companyEmails)
            {
                Console.WriteLine(mail);
            }

            List<string> cities = new List<string>() { "Ankara", "Ankara", "Ankara", "Sinop", "İstanbul", "Eskişehir", "Ankara" };

            List<string> newCities = new List<string>();

            foreach (var city in cities)
            {
                for (int i = 0; i < cities.Capacity-1; i++)
                {
                    if (!newCities.Contains(city))
                    {
                        newCities.Add(city);
                    }
                }
                
            }
            int x = 0;
            foreach (var newCity in newCities)
            {
                
                Console.WriteLine(newCities[x]);
                x++;
            }
            
        }
    }
}
