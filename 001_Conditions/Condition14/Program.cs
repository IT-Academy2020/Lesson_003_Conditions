using System;

// Оператор багатозначного вибору - switch-case (перемикач). Провалювання.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть номер дня тижня: 1-2-3-4-5-6-7: ");
            
            string day = Console.ReadLine();

            switch (day)
            {
                // Для порожніх операторів case дозволено "провалювання" від одного оператора до іншого. 
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("Цей день тижня - Робочий.");
                    break;
                case "6":
                case "7":
                    Console.WriteLine("Цей день тижня - Вихідний.");
                    break;

                default:
                    Console.WriteLine("Ви ввели неіснуючий день тижня.");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
