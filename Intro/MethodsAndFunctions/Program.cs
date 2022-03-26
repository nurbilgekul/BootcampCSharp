using System;

namespace MethodsAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //void methods do not return a value
            showOutput("nbk");
        }

        static void showOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}
