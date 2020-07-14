using System;

// Тернарний умовний оператор. Обмеження пов'язані з тіпобезопасностью.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            double b = 0.0;
            int max;

            // Вирази [?] І [:] - повинні бути одного типу.

            max = (int)((a > b) ? a : b);

            // ... або так

            max = (a > b) ? a : (int)b;

            Console.WriteLine(max);

            // Delay.
            Console.ReadKey();
        }
    }
}
