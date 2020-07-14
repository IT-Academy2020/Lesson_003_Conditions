using System;

// Тернарний умовний оператор.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2, c = -5, max = 0;

            max = a > b ? c = a : c = b; // спочатку с = а, а тільки потім max = c

            Console.WriteLine(max);
            Console.WriteLine(c);

            // Delay.
            Console.ReadKey();
        }
    }
}
