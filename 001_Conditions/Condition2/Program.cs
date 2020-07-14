using System;

// Умовна конструкція - if - else (з двома гілками).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 3, b = 2;

            if (a < b)  // Якщо умова задовільняє істинності, виконуємо тіло блоку if.
            {
                Console.WriteLine("a < b");               // Гілка 1
            }
            else        // Інакше, виконуємо тіло блоку else.       
            {
                Console.WriteLine("a не меньше b");       // Гілка 2
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
