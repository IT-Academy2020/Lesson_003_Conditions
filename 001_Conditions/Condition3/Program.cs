using System;

// Умовна конструкція - if-else (з двома гілками).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2;

            // Якщо тіло блоку if або else складається з одного виразу, то операторні дужки можна опустити

            if (a < b)
                Console.WriteLine("a < b");           // Гілка 1 
            else
                Console.WriteLine("a не меньше b");   // Гілка 2
            
            // Delay.
            Console.ReadKey();
        }
    }
}
