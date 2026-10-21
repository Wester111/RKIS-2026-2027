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
                string input = Console.ReadLine()?.Trim() ?? ""; //"?.Trim() ?? "";"-очистка от нуля, лишних пробелов и замена null на пустую строку
                if (string.IsNullOrEmpty(input))
                    continue;

                switch (input.ToLower())
                {
                    case "exit":
                        Console.WriteLine("ВСЁ!");
                        return; // Выход из метода Main
                    case "help":
                        Console.WriteLine(@"Доступные команды:
help    - список команд
profile - данные пользователя
add ... - добавить задачу
view    - показать задачи
exit    - выход");
                        break;
                    
                    default:
                        Console.WriteLine("Неизвестная команда. Введите 'help' для списка команд.");
                        break;
                }



            }

        }
    }
}
