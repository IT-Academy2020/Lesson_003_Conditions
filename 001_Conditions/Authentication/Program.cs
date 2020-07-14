using System;

namespace Authentication
{
    class Program
    {
        static void Main()
        {
            string login = "Admin";
            string password = "P@ssw0rd";

            Console.Write("Введіть login: ");

            // На 17 рядку створюємо стрічкову локальну змінну з ім'ям usersLogin
            // і приймаємо в неї введення від користувача

            string usersLogin = Console.ReadLine(); 
            
            if (login == usersLogin)
            {
                Console.Write("Введіть password: ");
                string usersPassword = Console.ReadLine();
                
                if (password == usersPassword)
                {
                    Console.WriteLine("Привіт {0}, Ви увійшли в систему.", usersLogin);
                }
                else
                {
                    Console.WriteLine("Ви ввели невірний пароль.");
                }                
            }
            else
            {
                Console.WriteLine("Немає облікового запису з таким ім'ям.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}

