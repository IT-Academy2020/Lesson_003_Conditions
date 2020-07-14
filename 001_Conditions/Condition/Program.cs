using System;

// Умовна конструкція - if (з однією гілкою).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2; // створюємо дві цілочисельні змінні

            // На 15-му рядку створюємо умовну конструкцію if, в умові якої перевіряємо: чи a менше b   

            if (a < b)      // Якщо умова задовольняє істинності, виконуємо тіло умовної конструкції.
            {
                Console.WriteLine("a < b");     // Гілка 1
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
