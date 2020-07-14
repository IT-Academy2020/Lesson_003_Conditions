using System;

// Тернарний умовний оператор.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            string @string = "Hello ";

            Console.WriteLine("Введіть свій логін:");

            // На 17 рядку створюємо змінну з ім'ям login типу string і приймаємо в неї введенні дані від користувача

            string login = Console.ReadLine();

            // На 21 рядку змінній @string присвоюємо значення, що повертається з тернарного оператора

            @string += login == "Admin" ? "Administrator" : "User"; 

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
