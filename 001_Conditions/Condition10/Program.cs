using System;

// Тернарний умовний оператор.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            double quantity = 10;    // Кількість одиниць товару.            
            double price = 100;      // Ціна за одиницю товару.           
            double discount = 0.75;  // Знижка на загальну вартість - 25%.
            double cost;             // Загальна вартість.  

            // ЯКЩО: Купили 10 одиниць товару і більше. ТО: надати знижку в 25%. ІНАКШЕ: Знижку не надавати.

            cost = quantity >= 10 ? quantity * price * discount : quantity * price;

            Console.WriteLine("Загальна вартість товару: {0} у.е.", cost);

            // Delay.
            Console.ReadKey();
        }
    }
}
