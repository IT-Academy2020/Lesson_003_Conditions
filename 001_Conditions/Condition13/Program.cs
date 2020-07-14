using System;

// Оператор багатозначного вибору - switch-case (перемикач). 

namespace Condition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть номер дня тижня: 1-2-3-4-5-6-7: ");
            
            string myDay = Console.ReadLine();

            // Конвертуємо значення стрічкової змінної myDay в цілочисельне значення
            // і записуємо його в змінну з ім'ям day типу int

            int day = Convert.ToInt32(myDay);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Понеділок.");
                    break;
                case 2:
                    Console.WriteLine("Вівторок.");
                    break;
                case 3:
                    Console.WriteLine("Середа.");
                    break;
                case 4:
                    Console.WriteLine("Четвер.");
                    break;
                case 5:
                    Console.WriteLine("Пятниця.");
                    break;
                case 6:
                    Console.WriteLine("Субота.");
                    break;
                case 7:
                    Console.WriteLine("Неділя.");
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
