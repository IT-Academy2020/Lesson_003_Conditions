using System;

// Оператор багатозначного вибору - switch-case (перемикач). 

namespace Condition
{
    class Program
    {
        static void Main()
        {
            // Пропонуємо користувачеві вибрати напій.
            Console.WriteLine("Розміри стаканчиків кави: 1 = Маленький, 2 = Середній, 3 = Великий ");
            Console.Write("Будь ласка, зробіть свій вибір: ");

            // Приймаємо введення від користувача.
            string coffeeSize = Console.ReadLine();

            int cost = 0;

            // Якщо оператор case має в своєму тілі код, то не підтримує "провалювання".
            switch (coffeeSize)
            {
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 25;
                    break;
                case "3":
                    cost += 50;
                    break;
                default:
                    Console.WriteLine("Неправильний вибір. Будь ласка виберіть 1, 2, або 3.");
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("Внесіть {0} копійок.", cost);
                Console.WriteLine("Дякую!");
            }
            else
            {
                Console.Write("Будь ласка, повторіть вибір.");
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
