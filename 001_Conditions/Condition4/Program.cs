using System;

// Умовна конструкція - if-else (з декількома гілками). Каскад умовних операторів.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2;

            if (a < b)      // каскад умовних операторів
            {
                Console.WriteLine("a < b");   // Гілка 1
            }
            else if (a > b) // йдемо на нову перевірку
            {
                Console.WriteLine("a > b");   // Гілка 2
            }
            else 
            {
                Console.WriteLine("a == b");  // Гілка 3
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
