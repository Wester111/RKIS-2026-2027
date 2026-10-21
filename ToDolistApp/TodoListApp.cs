using System;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работу выполнил Вахрамеев");
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите год рождения: ");
            string yearInput = Console.ReadLine();

            int birthYear = Convert.ToInt32(yearInput);
            int currentYear = 2026;
            int age = currentYear - birthYear;

            Console.WriteLine($"Добавлен пользователь {firstName} {lastName}, возраст {age}");
            //Лекция 3
            string[] todos = new string[2];
            int todoCount = 0;
            while (true)
            {
                Console.Write("\n Введите команду: ");
                string inputCommand = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    continue;

                // Разделение на части ввода
                string[] parts = inputCommand.Split(' ', 2);
                string command = parts[0].ToLower();

                if (command == "exit")
                {
                    Console.WriteLine("Выполняется выход");
                    break;
                }
                else
                {
                    Console.WriteLine("Неизвестная команда. Введите 'help' для списка команд.");
                }
            }

        }
    }
}
