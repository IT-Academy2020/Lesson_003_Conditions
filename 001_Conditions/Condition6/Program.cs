﻿using System;

// Тернарний умовний оператор.

// Тернарний оператор [?:].
// Тернарний оператор [?:], є скороченою формою конструкції if ... else.
// [?:] - включає в себе три операнда - (умова? Якщо умова ІСТИННА: Якщо умова ПОМИЛКОВА)

// Алгоритм роботи тернарного оператора: (логічний вираз)? вираз 1: вираз 2
// 1. Обчислюється логічний вираз (умова).
// 2. Якщо логічний вираз істинний, то обчислюється значення виразу 1, в іншому випадку - значення виразу 2.
// 3. Обчислене значення повертається.
namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2, max = 0;

            // Змінній max, присвоюємо значення, що повертається у резултаті виконання тернарного оператора.

            max = (a > b) ? a : b;   // ЯКЩО:  (a > b)  ТО:  повернути a  ІНАКШН: повернути b;

            Console.WriteLine(max);

            // Delay.
            Console.ReadKey();
        }
    }
}